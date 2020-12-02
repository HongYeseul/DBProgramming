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
    public partial class AddNewMenu : Form
    {
        DBManager manager = DBManager.GetInstance();
        MainForm Frm1;
        public AddNewMenu()
        {
            InitializeComponent();
        }
        public AddNewMenu(MainForm F1)
        {
            InitializeComponent();
            Frm1 = F1;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(txtBoxCost.Text != "" || txtBoxMenuName.Text != "")
            {
                string q = "INSERT INTO CoffeeMenu(CoffeeMenu, CoffeeCost)";
                manager.Query(String.Format("INSERT INTO CoffeeMenu(CoffeeMenu, CoffeeCost) VALUES ('{0}','{1}')", txtBoxMenuName.Text, txtBoxCost.Text));
                MessageBox.Show("추가 되었습니다.");
                Frm1.InitMenu();

            }
            txtBoxMenuName.Text = "";
            txtBoxCost.Text = "";
        }
    }
}
