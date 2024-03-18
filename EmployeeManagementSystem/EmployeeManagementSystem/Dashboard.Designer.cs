namespace EmployeeManagementSystem
{
    partial class Dashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label7 = new Label();
            panel5 = new Panel();
            label6 = new Label();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            label5 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(875, 565);
            panel1.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F);
            label7.Location = new Point(14, 16);
            label7.Name = "label7";
            label7.Size = new Size(104, 25);
            label7.TabIndex = 3;
            label7.Text = "Dashboard";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(75, 8, 138);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(pictureBox3);
            panel5.Location = new Point(588, 63);
            panel5.Name = "panel5";
            panel5.Size = new Size(269, 120);
            panel5.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(86, 84);
            label6.Name = "label6";
            label6.Size = new Size(108, 15);
            label6.TabIndex = 7;
            label6.Text = "Inactive Employees";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(224, 13);
            label4.Name = "label4";
            label4.Size = new Size(32, 37);
            label4.TabIndex = 5;
            label4.Text = "0";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.dashboard_inactive_employee;
            pictureBox3.Location = new Point(16, 35);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(64, 64);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(75, 8, 138);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(14, 63);
            panel3.Name = "panel3";
            panel3.Size = new Size(297, 120);
            panel3.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(219, 13);
            label2.Name = "label2";
            label2.Size = new Size(32, 37);
            label2.TabIndex = 3;
            label2.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(83, 84);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 2;
            label1.Text = "Total Employees";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.dashboard_employees;
            pictureBox1.Location = new Point(13, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(75, 8, 138);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(pictureBox2);
            panel4.Location = new Point(317, 63);
            panel4.Name = "panel4";
            panel4.Size = new Size(265, 120);
            panel4.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(82, 84);
            label5.Name = "label5";
            label5.Size = new Size(100, 15);
            label5.TabIndex = 5;
            label5.Text = "Active Employees";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(199, 13);
            label3.Name = "label3";
            label3.Size = new Size(32, 37);
            label3.TabIndex = 4;
            label3.Text = "0";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.dashboard_active_employees;
            pictureBox2.Location = new Point(12, 35);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 64);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "Dashboard";
            Size = new Size(875, 565);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Panel panel5;
        private Label label6;
        private Label label4;
        private PictureBox pictureBox3;
        private Panel panel4;
        private Label label5;
        private Label label3;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Label label7;
    }
}
