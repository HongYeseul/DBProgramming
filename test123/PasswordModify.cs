using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test123
{
    public partial class PasswordModify : Form
    {
        public PasswordModify()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (IsPwdValidation(txtPassword.Text))
            {
                // 비밀번호 ok
                try
                {
                    // 아이디가 맞지 않을 때 error 발생
                    string query = "SELECT * FROM ID ='" + txtId.Text + "'";
                    DBManager.GetInstance().Select(query);

                    // 
                    DBManager.GetInstance().Query(String.Format("UPDATE Users SET PW = (HEX(AES_ENCRYPT('{0}', 'asdf'))) WHERE ID = '{1}'",
                        txtPassword.Text, txtId.Text));

                    txtId.Text = "";
                    txtPassword.Text = "";
                }
                catch
                {
                    MessageBox.Show("아이디를 다시 확인 해 주세요.");
                }
            }
            else
            {
                MessageBox.Show("비밀번호 형식이 맞지 않습니다.");
            }
        }

        public static bool IsPwdValidation(string pwd)
        {
            //8자리 이상 패스워드입력 요청함.
            if (pwd.Length < 8) return false;

            Regex rxPassword = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[$@$!%*?&])[A-Za-z\d$@$!%*?&]{8,}$",
                        RegexOptions.IgnorePatternWhitespace);

            return rxPassword.IsMatch(pwd);
        }

    }
}
