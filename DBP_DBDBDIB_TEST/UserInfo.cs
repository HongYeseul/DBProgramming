using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBP_DBDBDIB_TEST
{
    class UserInfo
    {
        private static UserInfo instance = new UserInfo();
        private string strConn = "Server=49.50.174.201;Database=erp_school;Uid=dbdbdib;Pwd=123123;Charset=utf8";
        public bool loginON = false;  //로그인 유무

        public String Id { get; set; }
        public String Name { get; set; }
        public String PhoneNum { get; set; }
        public String Position { get; set; }
        public String Department { get; set; }
        public String BirthDay { get; set; }
        public String Gender { get; set; }
        public String Email { get; set; }

        public static UserInfo Getinstance() { return instance; }

        public void Login(string id, string pw)
        {
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();

                string query = "SELECT * FROM Employee WHERE identification = '"+id+"'";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader rdr = cmd.ExecuteReader();

                rdr.Read();
                Id = rdr["identification"].ToString();
                Name = rdr["name"].ToString();
                PhoneNum = rdr["phoneNum"].ToString();
                Position = rdr["position"].ToString();
                Department = rdr["department"].ToString();
                BirthDay = rdr["birthDay"].ToString();
                Gender = rdr["gender"].ToString();
                Email = rdr["email"].ToString();
                rdr.Close();

                MessageBox.Show(Name + "님 로그인 되셨습니다.");
                cmd.ExecuteNonQuery();
            }
        }
        private UserInfo() { }

    }
}
