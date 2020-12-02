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
    public partial class MenuModify : Form
    {
        DBManager manager = DBManager.GetInstance();
        LoginManager LoginManager = LoginManager.GetInstance();

        List<string> cost = new List<string>();

        public MenuModify()
        {
            InitializeComponent();
        }

        private void MenuModify_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM CoffeeMenu";

            MySqlDataReader rdr = manager.Select(query);

            while (rdr.Read())
            {
                string menu = rdr["CoffeeMenu"].ToString();
                listBoxMenu.Items.Add(menu);
                cost.Add(rdr["CoffeeCost"].ToString());
            }
            rdr.Close();
        }

        private void listBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMoney.Text = cost[listBoxMenu.SelectedIndex];
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string query = "UPDATE CoffeeMenu SET CoffeeCost = #CoffeeCost WHERE CoffeeMenu = '#CoffeeMenu'";

            query = query.Replace("#CoffeeCost", txtMoney.Text);
            query = query.Replace("#CoffeeMenu", listBoxMenu.SelectedItem.ToString());

            string logQuery = "INSERT INTO CoffeeCostLog(who, CoffeeCostLog.when, coffeeMenu, beforeModifyCost, afterModifyCost) " +
                "VALUES('#who','#when', '#coffeeMenu', #beforeModifyCost, #afterModifyCost)";


            logQuery = logQuery.Replace("#who", LoginManager.ID);
            logQuery = logQuery.Replace("#when", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            logQuery = logQuery.Replace("#coffeeMenu", listBoxMenu.SelectedItem.ToString());
            logQuery = logQuery.Replace("#beforeModifyCost", cost[listBoxMenu.SelectedIndex]);
            logQuery = logQuery.Replace("#afterModifyCost", txtMoney.Text);

            Console.WriteLine(query);
            Console.WriteLine(logQuery);
            manager.Query(query);
            manager.Query(logQuery);

            cost[listBoxMenu.SelectedIndex] = txtMoney.Text;
            txtMoney.Text = "";
            MessageBox.Show("수정되었습니다");

        }
    }
}
