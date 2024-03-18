namespace EmployeeManagementSystem
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            signup_loginBtn = new Button();
            label5 = new Label();
            signup_showPass = new CheckBox();
            signup_btn = new Button();
            signup_password = new TextBox();
            label4 = new Label();
            signup_username = new TextBox();
            label3 = new Label();
            label2 = new Label();
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
            panel1.Controls.Add(signup_loginBtn);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 400);
            panel1.TabIndex = 9;
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
            // signup_loginBtn
            // 
            signup_loginBtn.BackColor = Color.FromArgb(33, 11, 97);
            signup_loginBtn.Cursor = Cursors.Hand;
            signup_loginBtn.FlatAppearance.BorderSize = 0;
            signup_loginBtn.FlatAppearance.MouseDownBackColor = Color.Purple;
            signup_loginBtn.FlatAppearance.MouseOverBackColor = Color.Purple;
            signup_loginBtn.FlatStyle = FlatStyle.Flat;
            signup_loginBtn.ForeColor = Color.White;
            signup_loginBtn.Location = new Point(16, 336);
            signup_loginBtn.Name = "signup_loginBtn";
            signup_loginBtn.Size = new Size(191, 40);
            signup_loginBtn.TabIndex = 1;
            signup_loginBtn.Text = "SIGNIN";
            signup_loginBtn.UseVisualStyleBackColor = false;
            signup_loginBtn.Click += signup_loginBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(54, 312);
            label5.Name = "label5";
            label5.Size = new Size(120, 17);
            label5.TabIndex = 0;
            label5.Text = "Login Your Account";
            // 
            // signup_showPass
            // 
            signup_showPass.AutoSize = true;
            signup_showPass.Location = new Point(428, 295);
            signup_showPass.Name = "signup_showPass";
            signup_showPass.Size = new Size(108, 19);
            signup_showPass.TabIndex = 17;
            signup_showPass.Text = "Show Password";
            signup_showPass.UseVisualStyleBackColor = true;
            signup_showPass.CheckedChanged += signup_showPass_CheckedChanged;
            // 
            // signup_btn
            // 
            signup_btn.BackColor = Color.FromArgb(33, 11, 97);
            signup_btn.Cursor = Cursors.Hand;
            signup_btn.FlatAppearance.BorderColor = Color.FromArgb(75, 8, 138);
            signup_btn.FlatAppearance.BorderSize = 0;
            signup_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            signup_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            signup_btn.FlatStyle = FlatStyle.Flat;
            signup_btn.ForeColor = Color.White;
            signup_btn.Location = new Point(275, 314);
            signup_btn.Name = "signup_btn";
            signup_btn.Size = new Size(86, 41);
            signup_btn.TabIndex = 16;
            signup_btn.Text = "SIGNUP";
            signup_btn.UseVisualStyleBackColor = false;
            signup_btn.Click += signup_btn_Click;
            // 
            // signup_password
            // 
            signup_password.Font = new Font("Segoe UI", 9.75F);
            signup_password.Location = new Point(275, 252);
            signup_password.Multiline = true;
            signup_password.Name = "signup_password";
            signup_password.PasswordChar = '*';
            signup_password.Size = new Size(261, 25);
            signup_password.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(275, 226);
            label4.Name = "label4";
            label4.Size = new Size(67, 17);
            label4.TabIndex = 14;
            label4.Text = "Password:";
            // 
            // signup_username
            // 
            signup_username.Font = new Font("Segoe UI", 9.75F);
            signup_username.Location = new Point(275, 187);
            signup_username.Multiline = true;
            signup_username.Name = "signup_username";
            signup_username.Size = new Size(261, 25);
            signup_username.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(275, 161);
            label3.Name = "label3";
            label3.Size = new Size(70, 17);
            label3.TabIndex = 12;
            label3.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(275, 96);
            label2.Name = "label2";
            label2.Size = new Size(153, 25);
            label2.TabIndex = 11;
            label2.Text = "Register Account";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(575, 400);
            Controls.Add(panel1);
            Controls.Add(signup_showPass);
            Controls.Add(signup_btn);
            Controls.Add(signup_password);
            Controls.Add(label4);
            Controls.Add(signup_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label6;
        private Button signup_loginBtn;
        private Label label5;
        private CheckBox signup_showPass;
        private Button signup_btn;
        private TextBox signup_password;
        private Label label4;
        private TextBox signup_username;
        private Label label3;
        private Label label2;
    }
}