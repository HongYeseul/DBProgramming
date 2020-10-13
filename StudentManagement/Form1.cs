using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private bool loadCompleted_ = false;
        public Form1()
        {
            InitializeComponent();
            InitVariables();
        }

        private void InitVariables()
        {
            comboBoxStudent2Gender.Items.Clear();
            comboBoxStudent2Gender.Items.Add("남자");
            comboBoxStudent2Gender.Items.Add("여자");

            comboBoxStudent3Gender.Items.Clear();
            string[] genderData = { "남자", "여자" };
            comboBoxStudent3Gender.Items.AddRange(genderData);

            comboBoxStudent1Gender.SelectedIndex = 0;
            comboBoxStudent2Gender.SelectedIndex = 0;
            comboBoxStudent3Gender.SelectedIndex = 0;
            loadCompleted_ = true;


            BinaryWriter bw = new BinaryWriter(new FileStream("check.dat", FileMode.OpenOrCreate));
            bw.Close();

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

            Stream rs = new FileStream("student.stu", FileMode.Open);
            BinaryFormatter deserializer = new BinaryFormatter();

            StudentInfo studentInfo = (StudentInfo)deserializer.Deserialize(rs);

            rs.Close();

            textBoxStudent1Name.Text = studentInfo.name;
            textBoxStudent1ID.Text = studentInfo.sid;
            comboBoxStudent1Gender.Text = studentInfo.gender;

        }
        #region Save Button
        private void SaveStudent1()
        {
            if (loadCompleted_ == false)
                return;

            StudentInfo studentInfo = new StudentInfo();

            studentInfo.name = textBoxStudent1Name.Text;
            studentInfo.sid = textBoxStudent1ID.Text;
            studentInfo.gender = comboBoxStudent1Gender.Text;


            Stream ws = new FileStream("student.stu", FileMode.Create);
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(ws, studentInfo);
            ws.Close();

            /*
            BinaryWriter bw = new BinaryWriter(new FileStream("student1.dat", FileMode.Create));
            Console.WriteLine("HEELLO");
            bw.Write(textBoxStudent1Name.Text);
            Console.WriteLine("BYY");
            bw.Write(textBoxStudent1ID.Text);
            bw.Write(comboBoxStudent1Gender.Text);
            bw.Write(textBoxStudent1Memo.Text);
            
            Console.WriteLine("WRITE DATA DONE");
            bw.Close();*/
        }

        private void SaveStudent2()
        {
            if (loadCompleted_ == false)
                return;
            BinaryWriter bw = new BinaryWriter(new FileStream("student2.dat", FileMode.Create));
            Console.WriteLine("HEELLO");
            bw.Write(textBoxStudent2Name.Text);
            Console.WriteLine("BYY");
            bw.Write(textBoxStudent2ID.Text);
            bw.Write(comboBoxStudent2Gender.Text);
            bw.Write(textBoxStudent2Memo.Text);
            bw.Close();
        }

        private void SaveStudent3()
        {
            if (loadCompleted_ == false)
                return;
            BinaryWriter bw = new BinaryWriter(new FileStream("student3.dat", FileMode.Create));
            Console.WriteLine("HEELLO");
            bw.Write(textBoxStudent3Name.Text);
            Console.WriteLine("BYY");
            bw.Write(textBoxStudent3ID.Text);
            bw.Write(comboBoxStudent3Gender.Text);
            bw.Write(textBoxStudent2Memo.Text);
            bw.Close();
        }
        #endregion

        #region Student Delete Click Handler
        private void buttonStudent1Delete_Click(object sender, EventArgs e)
        {
            BinaryWriter bw = new BinaryWriter(new FileStream("student1.dat", FileMode.Create));
            Console.WriteLine("HEELLO");
           // bw.Write("");
            textBoxStudent1Name.Text = "학생정보 없음";
            textBoxStudent1ID.Clear();
            comboBoxStudent1Gender.SelectedIndex = 0;
            textBoxStudent1Memo.Clear();
            bw.Close();
            StudentNumber();
        }

        private void buttonStudent2Delete_Click(object sender, EventArgs e)
        {
            BinaryWriter bw = new BinaryWriter(new FileStream("student2.dat", FileMode.Create));
            Console.WriteLine("HEELLO");
            bw.Write("");
            textBoxStudent2Name.Text = "학생정보 없음";
            textBoxStudent2ID.Clear();
            comboBoxStudent2Gender.SelectedIndex = 0;
            textBoxStudent2Memo.Clear();
            bw.Close();
            StudentNumber();
        }

        private void buttonStudent3Delete_Click(object sender, EventArgs e)
        {
            BinaryWriter bw = new BinaryWriter(new FileStream("student3.dat", FileMode.Create));
            Console.WriteLine("HEELLO");
            bw.Write("");
            textBoxStudent3Name.Text = "학생정보 없음";
            textBoxStudent3ID.Clear();
            comboBoxStudent3Gender.SelectedIndex = 0;
            textBoxStudent3Memo.Clear();
            bw.Close();
            StudentNumber();
        }
        #endregion

        private void StudentNumber()
        {
            BinaryReader br1 = new BinaryReader(new FileStream("student1.dat", FileMode.Open));
            BinaryReader br2 = new BinaryReader(new FileStream("student2.dat", FileMode.Open));
            BinaryReader br3 = new BinaryReader(new FileStream("student3.dat", FileMode.Open));
            int cnt = 0;
            FileInfo info1 = new FileInfo("student1.dat");
            FileInfo info2 = new FileInfo("student2.dat");
            FileInfo info3 = new FileInfo("student3.dat");

            if (info1.Length > 1)
                cnt++;
            if (info2.Length > 1)
                cnt++;
            if (info3.Length > 1)
                cnt++;

            StudentNum.Text = cnt.ToString();

            br1.Close();
            br2.Close();
            br3.Close();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            BinaryWriter bw = new BinaryWriter(new FileStream("check.dat", FileMode.Create));

            if (checkBox1.Checked)
                bw.Write("Checked");
            else
                bw.Write("");

            bw.Close();
        }
    }
}
