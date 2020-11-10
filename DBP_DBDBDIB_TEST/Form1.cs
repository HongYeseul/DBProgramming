using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBP_DBDBDIB_TEST
{
    public partial class Form1 : Form
    {
        UserInfo UserManager = UserInfo.Getinstance();
        public Form1()
        {
            InitializeComponent();
            InitializeLogin();
        }

        private void InitializeLogin()
        {
            string id = Properties.Settings.Default.ID;
            string pw = Properties.Settings.Default.Password;
            
            if (id != "")
            {
                Properties.Settings.Default.ID = id;
                Properties.Settings.Default.Password = pw;
                Properties.Settings.Default.Save();
                checkBoxLogin.Checked = true;
                txtBoxID.Text = id;
                txtBoxPW.Text = pw;
                UserManager.Login(id, pw);
            }
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserManager.Login(txtBoxID.Text, txtBoxPW.Text);

        }

        private void checkBoxLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLogin.Checked)
            {
                Console.WriteLine("체크됨");
                Properties.Settings.Default.ID = txtBoxID.Text.ToString();
                Properties.Settings.Default.Password = txtBoxPW.Text.ToString();
                Properties.Settings.Default.Save();
            }
            /*
            else
            {
                Properties.Settings.Default.ID = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
            }
            */
        }
    }
}
