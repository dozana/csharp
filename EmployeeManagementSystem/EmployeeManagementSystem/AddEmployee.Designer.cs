namespace EmployeeManagementSystem
{
    partial class AddEmployee
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel2 = new Panel();
            addEmployee_salary = new TextBox();
            label8 = new Label();
            addEmployee_status = new ComboBox();
            label7 = new Label();
            addEmployee_clearBtn = new Button();
            addEmployee_deleteBtn = new Button();
            addEmployee_updateBtn = new Button();
            addEmployee_addBtn = new Button();
            addEmployee_importBtn = new Button();
            addEmployee_picture = new PictureBox();
            addEmployee_position = new ComboBox();
            label6 = new Label();
            addEmployee_phoneNumber = new TextBox();
            label5 = new Label();
            addEmployee_gender = new ComboBox();
            label4 = new Label();
            addEmployee_fullName = new TextBox();
            label3 = new Label();
            addEmployee_id = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addEmployee_picture).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(875, 261);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(33, 11, 97);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(837, 184);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(11, 12);
            label1.Name = "label1";
            label1.Size = new Size(150, 25);
            label1.TabIndex = 0;
            label1.Text = "Employee's Data";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(addEmployee_salary);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(addEmployee_status);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(addEmployee_clearBtn);
            panel2.Controls.Add(addEmployee_deleteBtn);
            panel2.Controls.Add(addEmployee_updateBtn);
            panel2.Controls.Add(addEmployee_addBtn);
            panel2.Controls.Add(addEmployee_importBtn);
            panel2.Controls.Add(addEmployee_picture);
            panel2.Controls.Add(addEmployee_position);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(addEmployee_phoneNumber);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(addEmployee_gender);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(addEmployee_fullName);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(addEmployee_id);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 261);
            panel2.Name = "panel2";
            panel2.Size = new Size(875, 304);
            panel2.TabIndex = 1;
            // 
            // addEmployee_salary
            // 
            addEmployee_salary.Location = new Point(130, 210);
            addEmployee_salary.Name = "addEmployee_salary";
            addEmployee_salary.Size = new Size(161, 23);
            addEmployee_salary.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(79, 213);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 18;
            label8.Text = "Salary";
            // 
            // addEmployee_status
            // 
            addEmployee_status.FormattingEnabled = true;
            addEmployee_status.Items.AddRange(new object[] { "Active", "Inactive" });
            addEmployee_status.Location = new Point(130, 181);
            addEmployee_status.Name = "addEmployee_status";
            addEmployee_status.Size = new Size(161, 23);
            addEmployee_status.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(79, 184);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 16;
            label7.Text = "Status";
            // 
            // addEmployee_clearBtn
            // 
            addEmployee_clearBtn.BackColor = Color.FromArgb(33, 11, 97);
            addEmployee_clearBtn.Cursor = Cursors.Hand;
            addEmployee_clearBtn.FlatAppearance.BorderColor = Color.DarkGray;
            addEmployee_clearBtn.FlatAppearance.BorderSize = 0;
            addEmployee_clearBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(75, 8, 138);
            addEmployee_clearBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            addEmployee_clearBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            addEmployee_clearBtn.FlatStyle = FlatStyle.Flat;
            addEmployee_clearBtn.ForeColor = Color.White;
            addEmployee_clearBtn.Location = new Point(766, 68);
            addEmployee_clearBtn.Name = "addEmployee_clearBtn";
            addEmployee_clearBtn.Size = new Size(89, 32);
            addEmployee_clearBtn.TabIndex = 15;
            addEmployee_clearBtn.Text = "Clear";
            addEmployee_clearBtn.UseVisualStyleBackColor = false;
            // 
            // addEmployee_deleteBtn
            // 
            addEmployee_deleteBtn.BackColor = Color.FromArgb(33, 11, 97);
            addEmployee_deleteBtn.Cursor = Cursors.Hand;
            addEmployee_deleteBtn.FlatAppearance.BorderColor = Color.DarkGray;
            addEmployee_deleteBtn.FlatAppearance.BorderSize = 0;
            addEmployee_deleteBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(75, 8, 138);
            addEmployee_deleteBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            addEmployee_deleteBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            addEmployee_deleteBtn.FlatStyle = FlatStyle.Flat;
            addEmployee_deleteBtn.ForeColor = Color.White;
            addEmployee_deleteBtn.Location = new Point(671, 68);
            addEmployee_deleteBtn.Name = "addEmployee_deleteBtn";
            addEmployee_deleteBtn.Size = new Size(89, 32);
            addEmployee_deleteBtn.TabIndex = 14;
            addEmployee_deleteBtn.Text = "Delete";
            addEmployee_deleteBtn.UseVisualStyleBackColor = false;
            // 
            // addEmployee_updateBtn
            // 
            addEmployee_updateBtn.BackColor = Color.FromArgb(33, 11, 97);
            addEmployee_updateBtn.Cursor = Cursors.Hand;
            addEmployee_updateBtn.FlatAppearance.BorderColor = Color.DarkGray;
            addEmployee_updateBtn.FlatAppearance.BorderSize = 0;
            addEmployee_updateBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(75, 8, 138);
            addEmployee_updateBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            addEmployee_updateBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            addEmployee_updateBtn.FlatStyle = FlatStyle.Flat;
            addEmployee_updateBtn.ForeColor = Color.White;
            addEmployee_updateBtn.Location = new Point(766, 30);
            addEmployee_updateBtn.Name = "addEmployee_updateBtn";
            addEmployee_updateBtn.Size = new Size(89, 32);
            addEmployee_updateBtn.TabIndex = 13;
            addEmployee_updateBtn.Text = "Update";
            addEmployee_updateBtn.UseVisualStyleBackColor = false;
            addEmployee_updateBtn.Click += addEmployee_updateBtn_Click;
            // 
            // addEmployee_addBtn
            // 
            addEmployee_addBtn.BackColor = Color.FromArgb(33, 11, 97);
            addEmployee_addBtn.Cursor = Cursors.Hand;
            addEmployee_addBtn.FlatAppearance.BorderColor = Color.DarkGray;
            addEmployee_addBtn.FlatAppearance.BorderSize = 0;
            addEmployee_addBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(75, 8, 138);
            addEmployee_addBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            addEmployee_addBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            addEmployee_addBtn.FlatStyle = FlatStyle.Flat;
            addEmployee_addBtn.ForeColor = Color.White;
            addEmployee_addBtn.Location = new Point(671, 30);
            addEmployee_addBtn.Name = "addEmployee_addBtn";
            addEmployee_addBtn.Size = new Size(89, 32);
            addEmployee_addBtn.TabIndex = 12;
            addEmployee_addBtn.Text = "Add";
            addEmployee_addBtn.UseVisualStyleBackColor = false;
            addEmployee_addBtn.Click += addEmployee_addBtn_Click;
            // 
            // addEmployee_importBtn
            // 
            addEmployee_importBtn.BackColor = Color.FromArgb(33, 11, 97);
            addEmployee_importBtn.Cursor = Cursors.Hand;
            addEmployee_importBtn.FlatAppearance.BorderSize = 0;
            addEmployee_importBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(78, 8, 138);
            addEmployee_importBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(78, 8, 138);
            addEmployee_importBtn.FlatStyle = FlatStyle.Flat;
            addEmployee_importBtn.ForeColor = Color.White;
            addEmployee_importBtn.Location = new Point(306, 137);
            addEmployee_importBtn.Name = "addEmployee_importBtn";
            addEmployee_importBtn.Size = new Size(100, 26);
            addEmployee_importBtn.TabIndex = 11;
            addEmployee_importBtn.Text = "Import";
            addEmployee_importBtn.UseVisualStyleBackColor = false;
            addEmployee_importBtn.Click += addEmployee_importBtn_Click;
            // 
            // addEmployee_picture
            // 
            addEmployee_picture.BackColor = Color.Silver;
            addEmployee_picture.BorderStyle = BorderStyle.FixedSingle;
            addEmployee_picture.Location = new Point(306, 30);
            addEmployee_picture.Name = "addEmployee_picture";
            addEmployee_picture.Size = new Size(100, 107);
            addEmployee_picture.SizeMode = PictureBoxSizeMode.StretchImage;
            addEmployee_picture.TabIndex = 10;
            addEmployee_picture.TabStop = false;
            // 
            // addEmployee_position
            // 
            addEmployee_position.FormattingEnabled = true;
            addEmployee_position.Items.AddRange(new object[] { "Principal", "Vice Principal", "Administrative Assistant", "School Counselor", "Registrar", "Teacher", "Librarian", "Janitor/Custodian", "Nurse/Health Coordinator", "IT Support Specialist", "Cafeteria Staff/Cook", "Security Guard", "Maintenance Worker", "Bus Driver" });
            addEmployee_position.Location = new Point(130, 152);
            addEmployee_position.Name = "addEmployee_position";
            addEmployee_position.Size = new Size(161, 23);
            addEmployee_position.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(68, 155);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 8;
            label6.Text = "Position";
            // 
            // addEmployee_phoneNumber
            // 
            addEmployee_phoneNumber.Location = new Point(130, 120);
            addEmployee_phoneNumber.Name = "addEmployee_phoneNumber";
            addEmployee_phoneNumber.Size = new Size(161, 23);
            addEmployee_phoneNumber.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 123);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 6;
            label5.Text = "Phone Number";
            // 
            // addEmployee_gender
            // 
            addEmployee_gender.FormattingEnabled = true;
            addEmployee_gender.Items.AddRange(new object[] { "Male", "Female" });
            addEmployee_gender.Location = new Point(130, 91);
            addEmployee_gender.Name = "addEmployee_gender";
            addEmployee_gender.Size = new Size(161, 23);
            addEmployee_gender.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 94);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 4;
            label4.Text = "Gender";
            // 
            // addEmployee_fullName
            // 
            addEmployee_fullName.Location = new Point(130, 59);
            addEmployee_fullName.Name = "addEmployee_fullName";
            addEmployee_fullName.Size = new Size(161, 23);
            addEmployee_fullName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 62);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 2;
            label3.Text = "Full Name";
            // 
            // addEmployee_id
            // 
            addEmployee_id.Location = new Point(130, 30);
            addEmployee_id.Name = "addEmployee_id";
            addEmployee_id.Size = new Size(161, 23);
            addEmployee_id.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 33);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 0;
            label2.Text = "Employee ID";
            // 
            // AddEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AddEmployee";
            Size = new Size(875, 565);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)addEmployee_picture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label4;
        private TextBox addEmployee_fullName;
        private Label label3;
        private TextBox addEmployee_id;
        private Label label2;
        private PictureBox addEmployee_picture;
        private ComboBox addEmployee_position;
        private Label label6;
        private TextBox addEmployee_phoneNumber;
        private Label label5;
        private ComboBox addEmployee_gender;
        private Button addEmployee_importBtn;
        private Button addEmployee_addBtn;
        private Button addEmployee_clearBtn;
        private Button addEmployee_deleteBtn;
        private Button addEmployee_updateBtn;
        private ComboBox addEmployee_status;
        private Label label7;
        private TextBox addEmployee_salary;
        private Label label8;
    }
}
