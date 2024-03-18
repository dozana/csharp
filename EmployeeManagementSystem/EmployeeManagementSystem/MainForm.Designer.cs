namespace EmployeeManagementSystem
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
            panel2 = new Panel();
            label4 = new Label();
            logout_btn = new Button();
            salary_btn = new Button();
            dashboard_btn = new Button();
            addEmployee_btn = new Button();
            greet_user = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            dashboard1 = new Dashboard();
            addEmployee1 = new AddEmployee();
            salary1 = new Salary();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(75, 8, 138);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(logout_btn);
            panel2.Controls.Add(salary_btn);
            panel2.Controls.Add(dashboard_btn);
            panel2.Controls.Add(addEmployee_btn);
            panel2.Controls.Add(greet_user);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 600);
            panel2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(65, 565);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 6;
            label4.Text = "Sign Out";
            // 
            // logout_btn
            // 
            logout_btn.Cursor = Cursors.Hand;
            logout_btn.FlatAppearance.BorderSize = 0;
            logout_btn.FlatAppearance.CheckedBackColor = Color.FromArgb(75, 8, 138);
            logout_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            logout_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            logout_btn.FlatStyle = FlatStyle.Flat;
            logout_btn.ForeColor = Color.White;
            logout_btn.Image = Properties.Resources.exit;
            logout_btn.Location = new Point(11, 541);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(48, 48);
            logout_btn.TabIndex = 5;
            logout_btn.UseVisualStyleBackColor = true;
            logout_btn.Click += logout_btn_Click;
            // 
            // salary_btn
            // 
            salary_btn.BackColor = Color.FromArgb(33, 11, 97);
            salary_btn.Cursor = Cursors.Hand;
            salary_btn.FlatAppearance.CheckedBackColor = Color.FromArgb(75, 8, 138);
            salary_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            salary_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            salary_btn.FlatStyle = FlatStyle.Flat;
            salary_btn.ForeColor = Color.White;
            salary_btn.Image = Properties.Resources.salary;
            salary_btn.ImageAlign = ContentAlignment.MiddleLeft;
            salary_btn.Location = new Point(12, 319);
            salary_btn.Name = "salary_btn";
            salary_btn.Size = new Size(200, 31);
            salary_btn.TabIndex = 4;
            salary_btn.Text = "SALARY";
            salary_btn.TextAlign = ContentAlignment.MiddleRight;
            salary_btn.UseVisualStyleBackColor = false;
            salary_btn.Click += salary_btn_Click;
            // 
            // dashboard_btn
            // 
            dashboard_btn.BackColor = Color.FromArgb(33, 11, 97);
            dashboard_btn.Cursor = Cursors.Hand;
            dashboard_btn.FlatAppearance.CheckedBackColor = Color.FromArgb(75, 8, 138);
            dashboard_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            dashboard_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            dashboard_btn.FlatStyle = FlatStyle.Flat;
            dashboard_btn.ForeColor = Color.White;
            dashboard_btn.Image = Properties.Resources.dashboard;
            dashboard_btn.ImageAlign = ContentAlignment.MiddleLeft;
            dashboard_btn.Location = new Point(12, 245);
            dashboard_btn.Name = "dashboard_btn";
            dashboard_btn.Size = new Size(200, 31);
            dashboard_btn.TabIndex = 2;
            dashboard_btn.Text = "DASHBOARD";
            dashboard_btn.TextAlign = ContentAlignment.MiddleRight;
            dashboard_btn.UseVisualStyleBackColor = false;
            dashboard_btn.Click += dashboard_btn_Click;
            // 
            // addEmployee_btn
            // 
            addEmployee_btn.BackColor = Color.FromArgb(33, 11, 97);
            addEmployee_btn.Cursor = Cursors.Hand;
            addEmployee_btn.FlatAppearance.CheckedBackColor = Color.FromArgb(75, 8, 138);
            addEmployee_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            addEmployee_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            addEmployee_btn.FlatStyle = FlatStyle.Flat;
            addEmployee_btn.ForeColor = Color.White;
            addEmployee_btn.Image = Properties.Resources.add_employee;
            addEmployee_btn.ImageAlign = ContentAlignment.MiddleLeft;
            addEmployee_btn.Location = new Point(12, 282);
            addEmployee_btn.Name = "addEmployee_btn";
            addEmployee_btn.Size = new Size(200, 31);
            addEmployee_btn.TabIndex = 3;
            addEmployee_btn.Text = "ADD EMPLOYEE";
            addEmployee_btn.TextAlign = ContentAlignment.MiddleRight;
            addEmployee_btn.UseVisualStyleBackColor = false;
            addEmployee_btn.Click += addEmployee_btn_Click;
            // 
            // greet_user
            // 
            greet_user.AutoSize = true;
            greet_user.ForeColor = Color.White;
            greet_user.Location = new Point(66, 193);
            greet_user.Name = "greet_user";
            greet_user.Size = new Size(86, 15);
            greet_user.TabIndex = 1;
            greet_user.Text = "Welcome, User";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.employees;
            pictureBox1.Location = new Point(48, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 128);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(dashboard1);
            panel3.Controls.Add(addEmployee1);
            panel3.Controls.Add(salary1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(225, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(875, 600);
            panel3.TabIndex = 2;
            // 
            // dashboard1
            // 
            dashboard1.Dock = DockStyle.Fill;
            dashboard1.Location = new Point(0, 0);
            dashboard1.Name = "dashboard1";
            dashboard1.Size = new Size(875, 600);
            dashboard1.TabIndex = 2;
            // 
            // addEmployee1
            // 
            addEmployee1.Location = new Point(1, 1);
            addEmployee1.Name = "addEmployee1";
            addEmployee1.Size = new Size(875, 565);
            addEmployee1.TabIndex = 1;
            // 
            // salary1
            // 
            salary1.Location = new Point(0, 0);
            salary1.Name = "salary1";
            salary1.Size = new Size(875, 565);
            salary1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1100, 600);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee Management System";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label greet_user;
        private Button dashboard_btn;
        private Button salary_btn;
        private Button addEmployee_btn;
        private Button logout_btn;
        private Label label4;
        private Panel panel3;
        private AddEmployee addEmployee1;
        private Salary salary1;
        private Dashboard dashboard1;
    }
}