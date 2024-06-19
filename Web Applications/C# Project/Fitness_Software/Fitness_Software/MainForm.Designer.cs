namespace Fitness_Software
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblRemainCal = new System.Windows.Forms.Label();
            this.lblTotalCal = new System.Windows.Forms.Label();
            this.lblGoalCal = new System.Windows.Forms.Label();
            this.btnAddExercise = new System.Windows.Forms.Button();
            this.lnkWeeklyGoal = new System.Windows.Forms.LinkLabel();
            this.lnkLogout = new System.Windows.Forms.LinkLabel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblDayZero = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(688, 548);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightBlue;
            this.tabPage1.Controls.Add(this.lblRemainCal);
            this.tabPage1.Controls.Add(this.lblTotalCal);
            this.tabPage1.Controls.Add(this.lblGoalCal);
            this.tabPage1.Controls.Add(this.btnAddExercise);
            this.tabPage1.Controls.Add(this.lnkWeeklyGoal);
            this.tabPage1.Controls.Add(this.lnkLogout);
            this.tabPage1.Controls.Add(this.lblUsername);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(680, 506);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            // 
            // lblRemainCal
            // 
            this.lblRemainCal.AutoSize = true;
            this.lblRemainCal.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainCal.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblRemainCal.Location = new System.Drawing.Point(357, 238);
            this.lblRemainCal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemainCal.Name = "lblRemainCal";
            this.lblRemainCal.Size = new System.Drawing.Size(105, 34);
            this.lblRemainCal.TabIndex = 31;
            this.lblRemainCal.Text = "Empty";
            // 
            // lblTotalCal
            // 
            this.lblTotalCal.AutoSize = true;
            this.lblTotalCal.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCal.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTotalCal.Location = new System.Drawing.Point(357, 175);
            this.lblTotalCal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalCal.Name = "lblTotalCal";
            this.lblTotalCal.Size = new System.Drawing.Size(105, 34);
            this.lblTotalCal.TabIndex = 30;
            this.lblTotalCal.Text = "Empty";
            // 
            // lblGoalCal
            // 
            this.lblGoalCal.AutoSize = true;
            this.lblGoalCal.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalCal.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblGoalCal.Location = new System.Drawing.Point(357, 112);
            this.lblGoalCal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGoalCal.Name = "lblGoalCal";
            this.lblGoalCal.Size = new System.Drawing.Size(105, 34);
            this.lblGoalCal.TabIndex = 29;
            this.lblGoalCal.Text = "Empty";
            // 
            // btnAddExercise
            // 
            this.btnAddExercise.BackColor = System.Drawing.Color.Coral;
            this.btnAddExercise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddExercise.ForeColor = System.Drawing.Color.Navy;
            this.btnAddExercise.Location = new System.Drawing.Point(201, 364);
            this.btnAddExercise.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddExercise.Name = "btnAddExercise";
            this.btnAddExercise.Size = new System.Drawing.Size(242, 69);
            this.btnAddExercise.TabIndex = 28;
            this.btnAddExercise.Text = "Add Exercise";
            this.btnAddExercise.UseVisualStyleBackColor = false;
            this.btnAddExercise.Click += new System.EventHandler(this.btnAddExercise_Click);
            // 
            // lnkWeeklyGoal
            // 
            this.lnkWeeklyGoal.AutoSize = true;
            this.lnkWeeklyGoal.Location = new System.Drawing.Point(394, 312);
            this.lnkWeeklyGoal.Name = "lnkWeeklyGoal";
            this.lnkWeeklyGoal.Size = new System.Drawing.Size(262, 29);
            this.lnkWeeklyGoal.TabIndex = 21;
            this.lnkWeeklyGoal.TabStop = true;
            this.lnkWeeklyGoal.Text = "Set your weekly goal";
            this.lnkWeeklyGoal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkWeeklyGoal_LinkClicked);
            // 
            // lnkLogout
            // 
            this.lnkLogout.AutoSize = true;
            this.lnkLogout.Location = new System.Drawing.Point(561, 18);
            this.lnkLogout.Name = "lnkLogout";
            this.lnkLogout.Size = new System.Drawing.Size(95, 29);
            this.lnkLogout.TabIndex = 20;
            this.lnkLogout.TabStop = true;
            this.lnkLogout.Text = "Logout";
            this.lnkLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLogout_LinkClicked);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblUsername.Location = new System.Drawing.Point(14, 18);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(105, 34);
            this.lblUsername.TabIndex = 19;
            this.lblUsername.Text = "Empty";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(43, 238);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 34);
            this.label2.TabIndex = 18;
            this.label2.Text = "Remaining Calories :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(14, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 34);
            this.label1.TabIndex = 17;
            this.label1.Text = "Total Calories Burned :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(120, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 34);
            this.label4.TabIndex = 16;
            this.label4.Text = "Calories Goal :";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightBlue;
            this.tabPage2.Controls.Add(this.lblDayZero);
            this.tabPage2.Controls.Add(this.chart);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(680, 506);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Status";
            // 
            // lblDayZero
            // 
            this.lblDayZero.AutoSize = true;
            this.lblDayZero.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayZero.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblDayZero.Location = new System.Drawing.Point(32, 207);
            this.lblDayZero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDayZero.Name = "lblDayZero";
            this.lblDayZero.Size = new System.Drawing.Size(610, 34);
            this.lblDayZero.TabIndex = 31;
            this.lblDayZero.Text = "You didn\'t add exercise. Come back after!";
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.LightBlue;
            chartArea9.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chart.Legends.Add(legend9);
            this.chart.Location = new System.Drawing.Point(3, 0);
            this.chart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chart.Name = "chart";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Status";
            this.chart.Series.Add(series9);
            this.chart.Size = new System.Drawing.Size(673, 496);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            this.chart.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(691, 562);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.LinkLabel lnkLogout;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lnkWeeklyGoal;
        private System.Windows.Forms.Label lblRemainCal;
        private System.Windows.Forms.Label lblTotalCal;
        private System.Windows.Forms.Label lblGoalCal;
        private System.Windows.Forms.Button btnAddExercise;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label lblDayZero;
    }
}