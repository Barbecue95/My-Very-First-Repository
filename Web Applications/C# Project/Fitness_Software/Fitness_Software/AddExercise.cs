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
    public partial class AddExercise : Form
    {
        decimal MET;
        public AddExercise()
        {
            InitializeComponent();
        }

        private void AddExercise_Load(object sender, EventArgs e)
        {
            lblDay.Text = Convert.ToString(MainForm.day);
        }

        private void cboType_DropDownClosed(object sender, EventArgs e)
        {
            cboDesc.Items.Clear();
            string type = cboType.Text;
            List<tblExercise> exercises = new List<tblExercise>();
            exercises = tblExercise.getExerciseFromDatabase(type);
            foreach (tblExercise exercise in exercises)
            {
                cboDesc.Items.Add(exercise.Description);
            }
        }

        private void cboDesc_DropDownClosed(object sender, EventArgs e)
        {
            string desc = cboDesc.Text;
            MET = tblExercise.getMETFromDatabase(desc);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //input all data
            if (txtWeight.Text == string.Empty || txtTime.Text == string.Empty || cboType.SelectedIndex == -1 || cboDesc.SelectedIndex == -1)
            {
                MessageBox.Show("Input all textboxes");
            }
            else
            {
                decimal calories, weight, mins, hour;
                mins = Convert.ToDecimal(txtTime.Text);
                hour = mins / 60;
                weight = Convert.ToDecimal(txtWeight.Text);
                calories = hour * weight * MET; //calories formula

                lblTotal.Text = calories.ToString("0.00");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lblTotal.Text == "Empty") //checking total cal data
            {
                MessageBox.Show("You didn't calculate total calories yet!");
                return;
            }
            else
            {
                //inserting record
                decimal cal = Convert.ToDecimal(lblTotal.Text);
                tblRecord record = new tblRecord();
                record.createRecord(MainForm.day, cal);
                MessageBox.Show("Your data has been saved");
                this.Hide();
                MainForm app = new MainForm();
                app.Closed += (s, args) => Close();
                app.Show();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm app = new MainForm();
            app.Closed += (s, args) => Close();
            app.Show();
        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
