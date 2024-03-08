namespace EmployeeManagementSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label6 = new Label();
            login_signupBtn = new Button();
            label5 = new Label();
            exit = new Label();
            label2 = new Label();
            label3 = new Label();
            login_username = new TextBox();
            login_password = new TextBox();
            label4 = new Label();
            login_btn = new Button();
            login_showPass = new CheckBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(75, 8, 138);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(login_signupBtn);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 400);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(17, 199);
            label6.Name = "label6";
            label6.Size = new Size(191, 17);
            label6.TabIndex = 2;
            label6.Text = "Employee Management System";
            // 
            // login_signupBtn
            // 
            login_signupBtn.BackColor = Color.FromArgb(33, 11, 97);
            login_signupBtn.Cursor = Cursors.Hand;
            login_signupBtn.FlatAppearance.BorderSize = 0;
            login_signupBtn.FlatAppearance.MouseDownBackColor = Color.Purple;
            login_signupBtn.FlatAppearance.MouseOverBackColor = Color.Purple;
            login_signupBtn.FlatStyle = FlatStyle.Flat;
            login_signupBtn.ForeColor = Color.White;
            login_signupBtn.Location = new Point(16, 336);
            login_signupBtn.Name = "login_signupBtn";
            login_signupBtn.Size = new Size(191, 40);
            login_signupBtn.TabIndex = 1;
            login_signupBtn.Text = "SIGNUP";
            login_signupBtn.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(44, 312);
            label5.Name = "label5";
            label5.Size = new Size(136, 17);
            label5.TabIndex = 0;
            label5.Text = "Register Your Account";
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Cursor = Cursors.Hand;
            exit.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exit.Location = new Point(550, 9);
            exit.Name = "exit";
            exit.Size = new Size(16, 17);
            exit.TabIndex = 1;
            exit.Text = "X";
            exit.Click += exit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(275, 96);
            label2.Name = "label2";
            label2.Size = new Size(133, 25);
            label2.TabIndex = 2;
            label2.Text = "Login Account";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(275, 161);
            label3.Name = "label3";
            label3.Size = new Size(70, 17);
            label3.TabIndex = 3;
            label3.Text = "Username:";
            // 
            // login_username
            // 
            login_username.Font = new Font("Segoe UI", 9.75F);
            login_username.Location = new Point(275, 187);
            login_username.Multiline = true;
            login_username.Name = "login_username";
            login_username.Size = new Size(261, 25);
            login_username.TabIndex = 4;
            // 
            // login_password
            // 
            login_password.Font = new Font("Segoe UI", 9.75F);
            login_password.Location = new Point(275, 252);
            login_password.Multiline = true;
            login_password.Name = "login_password";
            login_password.Size = new Size(261, 25);
            login_password.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(275, 226);
            label4.Name = "label4";
            label4.Size = new Size(67, 17);
            label4.TabIndex = 5;
            label4.Text = "Password:";
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.FromArgb(33, 11, 97);
            login_btn.Cursor = Cursors.Hand;
            login_btn.FlatAppearance.BorderColor = Color.FromArgb(75, 8, 138);
            login_btn.FlatAppearance.BorderSize = 0;
            login_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            login_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            login_btn.FlatStyle = FlatStyle.Flat;
            login_btn.ForeColor = Color.White;
            login_btn.Location = new Point(275, 314);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(86, 41);
            login_btn.TabIndex = 7;
            login_btn.Text = "LOGIN";
            login_btn.UseVisualStyleBackColor = false;
            // 
            // login_showPass
            // 
            login_showPass.AutoSize = true;
            login_showPass.Location = new Point(428, 295);
            login_showPass.Name = "login_showPass";
            login_showPass.Size = new Size(108, 19);
            login_showPass.TabIndex = 8;
            login_showPass.Text = "Show Password";
            login_showPass.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(47, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 128);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(575, 400);
            Controls.Add(login_showPass);
            Controls.Add(login_btn);
            Controls.Add(login_password);
            Controls.Add(label4);
            Controls.Add(login_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(exit);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label exit;
        private Label label2;
        private Label label3;
        private TextBox login_username;
        private TextBox login_password;
        private Label label4;
        private Button login_btn;
        private CheckBox login_showPass;
        private Label label5;
        private Button login_signupBtn;
        private Label label6;
        private PictureBox pictureBox1;
    }
}
