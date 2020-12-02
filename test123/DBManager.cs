using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace test123
{
    class DBManager
    {
        private static DBManager instance = new DBManager();
        private string connection_string = "Server=49.50.174.201;Database=s5533142;Uid=s5533142;Pwd=s5533142;Charset=utf8";

        public static DBManager GetInstance() { return instance; }

        public void Query(string query)
        {
            using (MySqlConnection conn = new MySqlConnection(connection_string))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);


                cmd.ExecuteNonQuery();
            }
        }

        public MySqlDataReader Select(string query)
        {
            MySqlConnection conn = new MySqlConnection(connection_string);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            return rdr;
        }


        public string Login(string ID, string PW)
        {
            using (MySqlConnection conn = new MySqlConnection(connection_string))
            {
                conn.Open();
                string sql = String.Format("SELECT * from Users where ID = '{0}' and '{1}' = (SELECT cast(AES_DECRYPT(UNHEX(PW), 'asdf') as char(100)) " +
                    "FROM Users where id = '{0}')",ID,PW);
                
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                try
                {
                    if (PW == rdr["PW"].ToString())
                    {
                        MessageBox.Show("로그인 되었습니다.");
                        return ID;
                    }
                }
                catch
                {
                    MessageBox.Show("로그인 정보가 잘못되었습니다.");
                    return "";
                }
                rdr.Close();
            }
            return "";
        }

        public DataTable GridSelect(string Query)
        {
            DataTable dt = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(connection_string))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(Query, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    dt.Load(rdr);
                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return null;
                }
            }
        }

    }
}
