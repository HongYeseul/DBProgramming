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
    public partial class viewModifyLog : Form
    {
        public viewModifyLog()
        {
            InitializeComponent();
        }

        private void viewModifyLog_Load(object sender, EventArgs e)
        {
            string query1 = "SELECT who AS 수정자, CoffeeCostLog.when AS 수정날짜, coffeeMenu AS 커피메뉴, beforeModifyCost AS 수정전가격, afterModifyCost AS 수정후가격 FROM CoffeeCostLog";
            string query2 = "SELECT orderNum AS 주문번호, who AS 수정자, CoffeeSoldLog.when AS 수정날짜, coffeeMenu AS 커피메뉴, beforeModifyCount AS 수정전갯수, afterModifyCount AS 수정후갯수 FROM CoffeeSoldLog";

            MySqlDataReader rdr1 = DBManager.GetInstance().Select(query1);

            DataTable dt = new DataTable();
            dt.Load(rdr1);
            dataGridView1.DataSource = dt;
            rdr1.Close();

            MySqlDataReader rdr2 = DBManager.GetInstance().Select(query2);
            DataTable dt2 = new DataTable();
            dt2.Load(rdr2);
            dataGridView2.DataSource = dt2;
            rdr2.Close();
        }
    }
}
