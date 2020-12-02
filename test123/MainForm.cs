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
    public partial class MainForm : Form
    {
        DBManager manager = DBManager.GetInstance();
        LoginManager LoginManager = LoginManager.GetInstance();
        String stdDetails = "{0, -10}{1, 5}";
        List<string> CoffeeName = new List<string>();

        List<string> CoffeeId = new List<string>();
        List<string> CoffeeNum = new List<string>();

        LoginForm Lf;
        public MainForm()
        {
            InitializeComponent();
            InitializeDateTimePicker();
            InitName();
        }
        public MainForm(LoginForm loginF)
        {
            InitializeComponent();
            InitializeDateTimePicker();
            InitName();
            this.Lf = loginF;
        }

        private void InitializeDateTimePicker()
        {
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }

        public void InitName()
        {
            labelName.Text = LoginManager.ID;
        }

        public void InitMenu()
        {
            listBoxCoffeeMenu.Items.Clear();
            listBoxOrderMenu.Items.Clear();
            listBoxCoffeeMenu.Items.Add(String.Format(stdDetails, "커피명", "가격"));
            listBoxOrderMenu.Items.Add(String.Format(stdDetails, "커피명", "갯수"));

            string q = "SELECT * FROM CoffeeMenu";
            MySqlDataReader rdr = manager.Select(q);

            while (rdr.Read())
            {
                string CoffeeName = rdr["CoffeeMenu"].ToString();
                string CoffeeCost = rdr["CoffeeCost"].ToString();

                this.CoffeeName.Add(rdr["CoffeeMenu"].ToString());
                string str = string.Format(stdDetails, CoffeeName, CoffeeCost);
                listBoxCoffeeMenu.Items.Add(str);
            }
            
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            InitMenu();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtBoxNum.Text = "";
            CoffeeId.Clear();
            CoffeeNum.Clear();
            CoffeeName.Clear();
            InitMenu();
        }

        private void listBoxCoffeeMenu_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void comboBoxSelect_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int idx = comboBoxSelect.SelectedIndex;

            //if (labelName.Text != "admin")
                //return;

            switch (idx)
            {
                case 0:
                    // 사용자별 일일 판매액 & 사용자별 일일 판매량 
                    dataGridView1.DataSource = manager.GridSelect("SELECT Date AS 날짜, Seller AS 사용자이름, SUM(CoffeeCount) AS 판매량, SUM(CoffeeCost*CoffeeCount) AS 판매액 " +
                        "FROM CoffeeSold join CoffeeMenu on CoffeeSold.CoffeeType = CoffeeMenu.id GROUP BY Seller, Date");
                    break;
                case 1:
                    // 커피종류별 일일 판매량 / 커피종류별 일일 판매액
                    dataGridView1.DataSource = manager.GridSelect("SELECT Date AS 날짜, CoffeeMenu.CoffeeMenu AS 커피종류, SUM(CoffeeCount) AS 판매량, SUM(CoffeeCost*CoffeeCount) AS 판매액 " +
                        "FROM CoffeeSold join CoffeeMenu on CoffeeSold.coffeeType = CoffeeMenu.id GROUP BY CoffeeMenu.CoffeeMenu, Date");
                    break;
                case 2:
                    // 커피종류별 월별 누적 판매량 / 커피종류별 월별 누적 판매액
                    dataGridView1.DataSource = manager.GridSelect("SELECT DATE_FORMAT(Date,'%Y-%m') AS 날짜, CoffeeMenu.CoffeeMenu AS 커피종류, SUM(CoffeeCount) AS 판매량, SUM(CoffeeCost*CoffeeCount)AS 판매액 " +
                        "FROM CoffeeSold join CoffeeMenu on CoffeeSold.CoffeeType = CoffeeMenu.id GROUP BY CoffeeMenu.CoffeeMenu, DATE_FORMAT(date,'%Y-%m')");
                    break;
                case 3:
                    dataGridView1.DataSource = manager.GridSelect("SELECT DATE_FORMAT(Date,'%H') AS '시간(시)', CoffeeMenu.CoffeeMenu AS 커피종류, SUM(CoffeeCount) AS 판매량, SUM(CoffeeCost*CoffeeCount)AS 판매액 " +
                        "FROM CoffeeSold join CoffeeMenu on CoffeeSold.CoffeeType = CoffeeMenu.id GROUP BY CoffeeMenu.CoffeeMenu, DATE_FORMAT(date,'%H')");
                    break;
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            String time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string who = LoginManager.ID;

            if(Properties.Settings.Default.idCount <= 10)
            {
                if (listBoxOrderMenu.Items.Count > 1)
                {
                    string lastId = Properties.Settings.Default.idCount.ToString();
                    string query = "INSERT INTO CoffeeSoldId (SoldId) VALUES (" + lastId + ") ON DUPLICATE KEY UPDATE SoldId = "+lastId+", Cancel='유효함'";
                    manager.Query(query);

                    for (int i = 0; i < CoffeeId.Count; i++)
                    {
                        manager.Query(String.Format("INSERT INTO CoffeeSold (OrderNumber, Seller, CoffeeCount, CoffeeType, Date) VALUES ('{4}','{0}','{1}','{2}','{3}')",
                                    who, CoffeeNum[i], CoffeeId[i], time, lastId));
                    }

                    Properties.Settings.Default.idCount = (Properties.Settings.Default.idCount) % 10 + 1;
                    Properties.Settings.Default.Save();
                }
            }
            
            
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            if(LoginManager.ID != "admin")
                manager.Query(String.Format("UPDATE UserTimeLog SET LogoutTime = '{0}' WHERE LoginTime = '{1}'", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), LoginManager.LoginTime));
            
            MessageBox.Show("폼을 종료합니다.");
            this.Close();
        }

        private void 메뉴추가ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewMenu m = new AddNewMenu(this);
            m.Show();
        }

        private void 사용자로그ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimeLog nf = new TimeLog();
            nf.Show();
        }

        private void 주문ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewPastOrder nf = new viewPastOrder();
            nf.Show();
        }

        private void btnAddMenu_Click(object sender, EventArgs e)
        {
            //listBoxCoffeeMenu.Items.Add(String.Format(stdDetails, "커피명", "가격"));

            listBoxOrderMenu.Items.Add(String.Format(stdDetails, CoffeeName[listBoxCoffeeMenu.SelectedIndex-1], txtBoxNum.Text + "개"));

            CoffeeId.Add(listBoxCoffeeMenu.SelectedIndex.ToString());
            CoffeeNum.Add(txtBoxNum.Text);

            txtBoxNum.Text = "";
            Console.WriteLine(listBoxCoffeeMenu.SelectedIndex);
        }

        private void 메뉴수정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuModify nf = new MenuModify();
            nf.Show();
        }

        private void 수정로그보기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewModifyLog nf = new viewModifyLog();
            nf.Show();
        }

        private void 신규유저등록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewUserStatus nf = new NewUserStatus();
            nf.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Lf.Close();
        }
    }
}
