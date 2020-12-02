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
    public partial class NewUserStatus : Form
    {
        DBManager manager = DBManager.GetInstance();
        public NewUserStatus()
        {
            InitializeComponent();
        }

        private void NewUserStatus_Load(object sender, EventArgs e)
        {
            string query = "SELECT ID AS 아이디, State AS 상태 FROM Users";
            MySqlDataReader rdr = manager.Select(query);

            DataTable dt = new DataTable();
            dt.Load(rdr);
            dataGridView1.DataSource = dt;
            rdr.Close();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dtChanges = new DataTable();
            DataTable originalDt = (DataTable)dataGridView1.DataSource;
            dtChanges = originalDt.GetChanges(DataRowState.Modified);

            string updateQuery = string.Empty;
            if (dtChanges != null)
            {
                for (int i = 0; i < dtChanges.Rows.Count; i++)
                {
                    updateQuery = "UPDATE Users SET State = '#USERSTATE' WHERE ID = '#USERID'";
                    updateQuery = updateQuery.Replace("#USERSTATE", dtChanges.Rows[i]["상태"].ToString());
                    updateQuery = updateQuery.Replace("#USERID", dtChanges.Rows[i]["아이디"].ToString());

                    Console.WriteLine(updateQuery);
                    manager.Query(updateQuery);
                }
            }

            NewUserStatus_Load(null, null);
        }
    }
}
