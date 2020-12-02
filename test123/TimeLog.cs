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
    public partial class TimeLog : Form
    {
        DBManager manager = DBManager.GetInstance();
        public TimeLog()
        {
            InitializeComponent();
        }

        private void TimeLog_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = manager.GridSelect("SELECT * FROM UserTimeLog");
        }
    }
}
