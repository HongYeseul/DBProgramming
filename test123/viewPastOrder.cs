using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test123
{
    public partial class viewPastOrder : Form
    {
        DBManager manager = DBManager.GetInstance();
        List<string> listCount = new List<string>();
        public viewPastOrder()
        {
            InitializeComponent();
        }

        private void viewPastOrder_Load(object sender, EventArgs e)
        {
            this.btnUpDown.Maximum = 10;
            this.btnUpDown.Minimum = 1;

            loadForm();

            for(int i=0; i< dataGridView1.Rows.Count; i++)
            {
                Console.WriteLine(dataGridView1.Rows[i].Cells[3].Value);
                listCount.Add(dataGridView1.Rows[i].Cells[3].Value.ToString());
            }

        }

        private void loadForm()
        {
            string query = "SELECT CoffeeSold.id, OrderNumber AS '주문번호', Seller AS '판매자', CoffeeCount AS '판매량', CoffeeMenu AS '커피메뉴', Date AS '판매일', Cancel AS '유효여부' FROM CoffeeSold join CoffeeSoldId on CoffeeSold.OrderNumber = SoldId join CoffeeMenu on CoffeeSold.CoffeeType = CoffeeMenu.id";
            MySqlDataReader rdr = manager.Select(query);

            DataTable dt = new DataTable();
            dt.Load(rdr);
            dataGridView1.DataSource = dt;
            rdr.Close();
        }

        string modifyCount;
        string orderNum;
        private void btnModify_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;

            DataTable dtChanges = new DataTable();

            DataTable dtSoldCoffee = (DataTable)dataGridView1.DataSource;

            dtChanges = dtSoldCoffee.GetChanges(DataRowState.Modified);

            string update_query = string.Empty;

            if(dtChanges != null)
            {
                for(int i=0; i<dtChanges.Rows.Count; i++)
                {
                    update_query = "UPDATE CoffeeSold SET CoffeeCount = '#CoffeeCount' WHERE id = #id";

                    modifyCount = dtChanges.Rows[i]["판매량"].ToString();
                    orderNum = dtChanges.Rows[i]["주문번호"].ToString();

                    update_query = update_query.Replace("#CoffeeCount", dtChanges.Rows[i]["판매량"].ToString());
                    update_query = update_query.Replace("#id", dtChanges.Rows[i]["id"].ToString());

                    manager.Query(update_query);

                }
            }
            dtChanges = null;

            this.Cursor = Cursors.Default;

            // CoffeeSoldLog 에 수정 내역 추가
            string logQuery = "INSERT INTO CoffeeSoldLog(who,orderNum , CoffeeSoldLog.when, coffeeMenu, beforeModifyCount, afterModifyCount) " +
                "VALUES('#who', #orderNum ,'#when', '#coffeeMenu', '#beforeModifyCount', '#afterModifyCount')";

            int rowidx = dataGridView1.CurrentRow.Index;
            
            logQuery = logQuery.Replace("#who", LoginManager.GetInstance().ID);
            logQuery = logQuery.Replace("#orderNum", orderNum);
            logQuery = logQuery.Replace("#when", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            logQuery = logQuery.Replace("#coffeeMenu", dataGridView1.Rows[rowidx].Cells[4].Value.ToString());
            logQuery = logQuery.Replace("#beforeModifyCount", listCount[rowidx]);
            logQuery = logQuery.Replace("#afterModifyCount", modifyCount);

            Console.WriteLine(logQuery);
            manager.Query(logQuery);

            listCount[rowidx] = modifyCount;
            
            MessageBox.Show("수정되었습니다");
            
        }

        private void btnRemoveRow_Click(object sender, EventArgs e)
        {
            Console.WriteLine(btnUpDown.Value.ToString());

            string query = "UPDATE CoffeeSoldId SET Cancel = '삭제됨' WHERE SoldId = " + btnUpDown.Value.ToString();

            int rowidx = dataGridView1.CurrentRow.Index;
            string logQuery = "INSERT INTO CoffeeSoldLog(who,orderNum , CoffeeSoldLog.when, coffeeMenu, beforeModifyCount, afterModifyCount) " +
                "VALUES('#who', #orderNum ,'#when', '#coffeeMenu', '#beforeModifyCount', '#afterModifyCount')";

            logQuery = logQuery.Replace("#who", LoginManager.GetInstance().ID);
            logQuery = logQuery.Replace("#orderNum", dataGridView1.Rows[rowidx].Cells[1].Value.ToString());
            logQuery = logQuery.Replace("#when", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            logQuery = logQuery.Replace("#coffeeMenu", dataGridView1.Rows[rowidx].Cells[4].Value.ToString());
            logQuery = logQuery.Replace("#beforeModifyCount", "삭제");
            logQuery = logQuery.Replace("#afterModifyCount", "삭제");

            Console.WriteLine(logQuery);
            manager.Query(logQuery);
            manager.Query(query);
            loadForm();
        }
    }
}
