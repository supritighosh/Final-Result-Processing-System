namespace FinalResultProcessingSystem
{
    partial class newuserF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newuserF));
            this.panel2 = new System.Windows.Forms.Panel();
            this.backB = new System.Windows.Forms.Button();
            this.exit1B = new System.Windows.Forms.Button();
            this.mpasswordTB = new System.Windows.Forms.TextBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.desigCB = new System.Windows.Forms.ComboBox();
            this.deptCB = new System.Windows.Forms.ComboBox();
            this.tnameTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clearB = new System.Windows.Forms.Button();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.submitB = new System.Windows.Forms.Button();
            this.passwordLB = new System.Windows.Forms.Label();
            this.usernameLB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Ivory;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.backB);
            this.panel2.Controls.Add(this.exit1B);
            this.panel2.Controls.Add(this.mpasswordTB);
            this.panel2.Controls.Add(this.errorLabel);
            this.panel2.Controls.Add(this.desigCB);
            this.panel2.Controls.Add(this.deptCB);
            this.panel2.Controls.Add(this.tnameTB);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.clearB);
            this.panel2.Controls.Add(this.passwordTB);
            this.panel2.Controls.Add(this.usernameTB);
            this.panel2.Controls.Add(this.submitB);
            this.panel2.Controls.Add(this.passwordLB);
            this.panel2.Controls.Add(this.usernameLB);
            this.panel2.Location = new System.Drawing.Point(388, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(505, 522);
            this.panel2.TabIndex = 8;
            // 
            // backB
            // 
            this.backB.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backB.Location = new System.Drawing.Point(104, 456);
            this.backB.Name = "backB";
            this.backB.Size = new System.Drawing.Size(96, 32);
            this.backB.TabIndex = 10;
            this.backB.Text = "Back";
            this.backB.UseVisualStyleBackColor = true;
            this.backB.Click += new System.EventHandler(this.button1_Click);
            // 
            // exit1B
            // 
            this.exit1B.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit1B.Location = new System.Drawing.Point(264, 456);
            this.exit1B.Name = "exit1B";
            this.exit1B.Size = new System.Drawing.Size(96, 32);
            this.exit1B.TabIndex = 8;
            this.exit1B.Text = "Exit";
            this.exit1B.UseVisualStyleBackColor = true;
            this.exit1B.Click += new System.EventHandler(this.exit1B_Click);
            // 
            // mpasswordTB
            // 
            this.mpasswordTB.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mpasswordTB.Location = new System.Drawing.Point(245, 268);
            this.mpasswordTB.Name = "mpasswordTB";
            this.mpasswordTB.PasswordChar = '*';
            this.mpasswordTB.Size = new System.Drawing.Size(173, 24);
            this.mpasswordTB.TabIndex = 24;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(46, 319);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(404, 19);
            this.errorLabel.TabIndex = 23;
            this.errorLabel.Text = "You have entered wrong master password. Please enter correctly.\r\n";
            this.errorLabel.Visible = false;
            // 
            // desigCB
            // 
            this.desigCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.desigCB.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desigCB.FormattingEnabled = true;
            this.desigCB.Items.AddRange(new object[] {
            "Lecturer",
            "Assistant Professor",
            "Associate Professor",
            "Professor",
            "Director"});
            this.desigCB.Location = new System.Drawing.Point(245, 127);
            this.desigCB.Name = "desigCB";
            this.desigCB.Size = new System.Drawing.Size(173, 25);
            this.desigCB.TabIndex = 17;
            // 
            // deptCB
            // 
            this.deptCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deptCB.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptCB.FormattingEnabled = true;
            this.deptCB.Items.AddRange(new object[] {
            "IIT",
            "CSE",
            "Physics",
            "Chemistry",
            "Environmental Science",
            "Mathematics",
            "Statistics",
            "Geology",
            "URP",
            "Pharmacy",
            "Biochemestry",
            "Microbiology",
            "Bangla",
            "English",
            "Dramatics"});
            this.deptCB.Location = new System.Drawing.Point(245, 80);
            this.deptCB.Name = "deptCB";
            this.deptCB.Size = new System.Drawing.Size(173, 25);
            this.deptCB.TabIndex = 16;
            // 
            // tnameTB
            // 
            this.tnameTB.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tnameTB.Location = new System.Drawing.Point(245, 42);
            this.tnameTB.Name = "tnameTB";
            this.tnameTB.Size = new System.Drawing.Size(173, 24);
            this.tnameTB.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(63, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Master Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(63, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(63, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(63, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Designation";
            // 
            // clearB
            // 
            this.clearB.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearB.Location = new System.Drawing.Point(264, 382);
            this.clearB.Name = "clearB";
            this.clearB.Size = new System.Drawing.Size(96, 42);
            this.clearB.TabIndex = 9;
            this.clearB.Text = "Clear";
            this.clearB.UseVisualStyleBackColor = true;
            this.clearB.Click += new System.EventHandler(this.clearB_Click);
            // 
            // passwordTB
            // 
            this.passwordTB.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTB.Location = new System.Drawing.Point(245, 221);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '*';
            this.passwordTB.Size = new System.Drawing.Size(173, 24);
            this.passwordTB.TabIndex = 7;
            // 
            // usernameTB
            // 
            this.usernameTB.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTB.Location = new System.Drawing.Point(245, 172);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(173, 24);
            this.usernameTB.TabIndex = 6;
            this.usernameTB.TextChanged += new System.EventHandler(this.usernameTB_TextChanged);
            this.usernameTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.usernameTB_KeyDown);
            this.usernameTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usernameTB_KeyPress);
            this.usernameTB.Leave += new System.EventHandler(this.usernameTB_Leave);
            // 
            // submitB
            // 
            this.submitB.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitB.Location = new System.Drawing.Point(104, 382);
            this.submitB.Name = "submitB";
            this.submitB.Size = new System.Drawing.Size(96, 42);
            this.submitB.TabIndex = 3;
            this.submitB.Text = "Submit";
            this.submitB.UseVisualStyleBackColor = true;
            this.submitB.Click += new System.EventHandler(this.submitB_Click);
            // 
            // passwordLB
            // 
            this.passwordLB.AutoSize = true;
            this.passwordLB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.passwordLB.Location = new System.Drawing.Point(63, 42);
            this.passwordLB.Name = "passwordLB";
            this.passwordLB.Size = new System.Drawing.Size(142, 22);
            this.passwordLB.TabIndex = 2;
            this.passwordLB.Text = "Teacher\'s Name";
            // 
            // usernameLB
            // 
            this.usernameLB.AutoSize = true;
            this.usernameLB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.usernameLB.Location = new System.Drawing.Point(63, 172);
            this.usernameLB.Name = "usernameLB";
            this.usernameLB.Size = new System.Drawing.Size(101, 22);
            this.usernameLB.TabIndex = 1;
            this.usernameLB.Text = "User Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(490, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 44);
            this.label1.TabIndex = 9;
            this.label1.Text = "Create New Account";
            // 
            // newuserF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1362, 705);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "newuserF";
            this.Text = "Create New Account";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button exit1B;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.Button submitB;
        private System.Windows.Forms.Label passwordLB;
        private System.Windows.Forms.Label usernameLB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearB;
        private System.Windows.Forms.Button backB;
        private System.Windows.Forms.ComboBox desigCB;
        private System.Windows.Forms.ComboBox deptCB;
        private System.Windows.Forms.TextBox tnameTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.TextBox mpasswordTB;
    }
}