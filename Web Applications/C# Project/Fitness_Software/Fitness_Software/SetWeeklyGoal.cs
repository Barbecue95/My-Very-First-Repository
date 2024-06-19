using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_Software
{
    public partial class SetWeeklyGoal : Form
    {
        public SetWeeklyGoal()
        {
            InitializeComponent();
        }
        tblUser user = new tblUser();
        private void SetWeeklyGoal_Load(object sender, EventArgs e)
        {
            lblCurrentGoal.Text = Convert.ToString(tblUser.getSetgoal()) + " cal";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNewGoal.Text == "")
            {
                MessageBox.Show("Input data");
            }
            else
            {
                //delete current goal 
                tblRecord.deleteGoal();

                decimal setGoal = Convert.ToDecimal(txtNewGoal.Text);
                user.updateSetgoal(setGoal);
                //updating user's set goal via user input

                MessageBox.Show("Set new goal complete", "Thank you", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNewGoal.Text = "";
                SetWeeklyGoal_Load(this, e); // Manually invoke frmMain_Load
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm app = new MainForm();
            app.Closed += (s, args) => Close();
            app.Show();
        }
    }
}
