using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class Form1 : Form
    {
        //private bool loadCompleted_ = false;
        private bool Load;
        string strConn = "Server=49.50.174.201;Database=s5533142;Uid=s5533142;Pwd=s5533142;Charset=utf8";

        public Form1()
        {

            InitializeComponent();
            InitVariables();
        }

        private void InitVariables()
        {
            StudentNumber();
            Load = Properties.Settings.Default.load;
            Console.WriteLine(Load);
            
            comboBoxStudent2Gender.Items.Clear();
            comboBoxStudent2Gender.Items.Add("남자");
            comboBoxStudent2Gender.Items.Add("여자");

            comboBoxStudent3Gender.Items.Clear();
            string[] genderData = { "남자", "여자" };
            comboBoxStudent3Gender.Items.AddRange(genderData);

            comboBoxStudent1Gender.SelectedIndex = 0;
            comboBoxStudent2Gender.SelectedIndex = 0;
            comboBoxStudent3Gender.SelectedIndex = 0;
            //loadCompleted_ = true;

            if (Load)
            {
                checkBox1.Checked = true;
                LoadStudent();
            }

        }



        private void buttonLoadStudentInfo_Click(object sender, EventArgs e)
        {
            LoadStudent();
            StudentNumber();
        }


        private void buttonStudent2Save_Click(object sender, EventArgs e)
        {
            SaveStudent2();
            StudentNumber();
        }

        private void buttonStudent3Save_Click(object sender, EventArgs e)
        {
            SaveStudent3();
            StudentNumber();
        }

        #region Student 1 Event Handlers
        private void buttonStudent1Save_Click(object sender, EventArgs e)
        {
            SaveStudent1();
            StudentNumber();
        }
        private void comboBoxStudent1Gender_SelectedIndexChanged(object sender, EventArgs e)
        {
           // SaveStudent();
        }

        private void textBoxStudent1ID_TextChanged(object sender, EventArgs e)
        {
           // SaveStudent();
        }

        private void textBoxStudent1Name_TextChanged(object sender, EventArgs e)
        {
           // SaveStudent();
        }
        #endregion

        private void LoadStudent()
        {
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                string sql = "SELECT * FROM student";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                int cnt = 0;

                while (rdr.Read())
                {
                    Console.WriteLine(cnt++);

                    TextBox txtIDTarget = (Controls.Find("textBoxStudent" + cnt.ToString() +"ID", true)[0] as TextBox);
                    TextBox txtNameTarget = (Controls.Find("textBoxStudent" + cnt.ToString() + "Name", true)[0] as TextBox);
                    ComboBox cmbGenderTarget = (Controls.Find("comboBoxStudent" + cnt.ToString() + "Gender", true)[0] as ComboBox);
                    TextBox txtMemoTarget = (Controls.Find("textBoxStudent" + cnt.ToString() + "Memo", true)[0] as TextBox);
                    txtIDTarget.Text = (string)rdr["sid"];
                    txtNameTarget.Text = (string)rdr["name"];
                    cmbGenderTarget.Text = (string)rdr["gender"];
                    txtMemoTarget.Text = (string)rdr["memo"].ToString();
                }
                rdr.Close();
            }
        }
        #region Save Button
        private void SaveStudent1()
        {

            StudentInfo studentInfo = new StudentInfo();

            studentInfo.name = textBoxStudent1Name.Text;
            studentInfo.sid = textBoxStudent1ID.Text;
            studentInfo.gender = comboBoxStudent1Gender.Text;


            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                string q = "UPDATE student SET name = '" + studentInfo.name + "', sid = '" + studentInfo.sid + "', gender = '" + studentInfo.gender + "' WHERE id = 1";
                Console.WriteLine(q);
                MySqlCommand cmd = new MySqlCommand(q, conn);
                cmd.ExecuteNonQuery();
            }

        }

        private void SaveStudent2()
        {
            StudentInfo studentInfo = new StudentInfo();

            studentInfo.name = textBoxStudent2Name.Text;
            studentInfo.sid = textBoxStudent2ID.Text;
            studentInfo.gender = comboBoxStudent2Gender.Text;


            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                string q = "UPDATE student SET name = '" + studentInfo.name + "', sid = '" + studentInfo.sid + "', gender = '" + studentInfo.gender + "' WHERE id = 2";
                Console.WriteLine(q);
                MySqlCommand cmd = new MySqlCommand(q, conn);
                cmd.ExecuteNonQuery();
            }
        }

        private void SaveStudent3()
        {
            StudentInfo studentInfo = new StudentInfo();

            studentInfo.name = textBoxStudent3Name.Text;
            studentInfo.sid = textBoxStudent3ID.Text;
            studentInfo.gender = comboBoxStudent3Gender.Text;


            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                string q = "UPDATE student SET name = '" + studentInfo.name + "', sid = '" + studentInfo.sid + "', gender = '" + studentInfo.gender + "' WHERE id = 3";
                Console.WriteLine(q);
                MySqlCommand cmd = new MySqlCommand(q, conn);
                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        #region Student Delete Click Handler
        private void buttonStudent1Delete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                string q = "UPDATE student SET name = '"+"학생정보 없음"+"', sid = '', gender = '"+"남자"+"' WHERE id = 1";
                Console.WriteLine(q);
                MySqlCommand cmd = new MySqlCommand(q, conn);
                cmd.ExecuteNonQuery();
            }
            StudentNumber();
        }

        private void buttonStudent2Delete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                string q = "UPDATE student SET name = '" + "학생정보 없음" + "', sid = '', gender = '" + "남자" + "' WHERE id = 2";
                Console.WriteLine(q);
                MySqlCommand cmd = new MySqlCommand(q, conn);
                cmd.ExecuteNonQuery();
            }
            StudentNumber();
        }

        private void buttonStudent3Delete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                string q = "UPDATE student SET name = '" + "학생정보 없음" + "', sid = '', gender = '" + "남자" + "' WHERE id = 3";
                Console.WriteLine(q);
                MySqlCommand cmd = new MySqlCommand(q, conn);
                cmd.ExecuteNonQuery();
            }
            StudentNumber();
        }
        #endregion

        private void StudentNumber()
        {
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                string sql = "SELECT * FROM student";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                int cnt = 0;

                while (rdr.Read())
                {
                    if (rdr["sid"].ToString().Length > 0) // 학생 존재함
                        cnt++;
                }
                StudentNum.Text = cnt.ToString();
                rdr.Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Console.WriteLine("Checked");
                Properties.Settings.Default.load = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.load = false;
                Properties.Settings.Default.Save();
            }
            Console.WriteLine("Save");
        }
    }
}
