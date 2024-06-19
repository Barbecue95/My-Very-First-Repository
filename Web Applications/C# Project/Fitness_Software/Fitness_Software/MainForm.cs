using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_Software
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public static decimal totalCal;
        public static int day;
        private void MainForm_Load(object sender, EventArgs e)
        {
            lblUsername.Text = "Username : " + tblUser.uName;

            decimal setgoal = tblUser.getSetgoal();
            lblGoalCal.Text = setgoal.ToString() + " cal";

            totalCal = tblRecord.getTotalCal();
            lblTotalCal.Text = totalCal.ToString() + " cal";

            decimal remainCal = setgoal - totalCal;
            lblRemainCal.Text = remainCal.ToString() + " cal";

            List<tblRecord> recordList = new List<tblRecord>();
            recordList = tblRecord.getRecordFromDatabase();
            foreach (tblRecord record in recordList)
            {
                chart.Series["Status"].Points.AddXY(record.Date, record.CalBurn);
            }
            if (chart.Series["Status"].Points.Count == 0)
            {
                lblDayZero.Visible = true;
                chart.Visible = false;
            }
            else
            {
                lblDayZero.Visible = false;
                chart.Visible = true;
            }
        }

        private void btnAddExercise_Click(object sender, EventArgs e)
        {
            day= tblRecord.getDate();
            day += 1;
            if (day > 7)
            {
                MessageBox.Show("You have complete weekly goal. Reset your goal.");
            }
            else
            {
                this.Hide();
                AddExercise app = new AddExercise();
                app.Closed += (s, args) => Close();
                app.Show();
            }
        }

        private void lnkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignInAndSignUp app = new SignInAndSignUp();
            app.Closed += (s, args) => Close();
            app.Show();
        }

        private void lnkWeeklyGoal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SetWeeklyGoal app = new SetWeeklyGoal();
            app.Closed += (s, args) => Close();
            app.Show();
        }
    }
}
