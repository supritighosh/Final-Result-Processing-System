namespace FinalResultProcessingSystem
{
    partial class LogInF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInF));
            this.panel2 = new System.Windows.Forms.Panel();
            this.adminRB = new System.Windows.Forms.RadioButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.teacherRB = new System.Windows.Forms.RadioButton();
            this.exit1B = new System.Windows.Forms.Button();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.logB = new System.Windows.Forms.Button();
            this.passwordLB = new System.Windows.Forms.Label();
            this.usernameLB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Snow;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.adminRB);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.teacherRB);
            this.panel2.Controls.Add(this.exit1B);
            this.panel2.Controls.Add(this.passwordTB);
            this.panel2.Controls.Add(this.usernameTB);
            this.panel2.Controls.Add(this.logB);
            this.panel2.Controls.Add(this.passwordLB);
            this.panel2.Controls.Add(this.usernameLB);
            this.panel2.Location = new System.Drawing.Point(406, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(512, 388);
            this.panel2.TabIndex = 7;
            // 
            // adminRB
            // 
            this.adminRB.AutoSize = true;
            this.adminRB.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminRB.Location = new System.Drawing.Point(272, 165);
            this.adminRB.Name = "adminRB";
            this.adminRB.Size = new System.Drawing.Size(87, 28);
            this.adminRB.TabIndex = 3;
            this.adminRB.Text = "Admin";
            this.adminRB.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(169, 209);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(158, 21);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Create new account";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // teacherRB
            // 
            this.teacherRB.AutoSize = true;
            this.teacherRB.Checked = true;
            this.teacherRB.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherRB.Location = new System.Drawing.Point(127, 165);
            this.teacherRB.Name = "teacherRB";
            this.teacherRB.Size = new System.Drawing.Size(99, 28);
            this.teacherRB.TabIndex = 2;
            this.teacherRB.TabStop = true;
            this.teacherRB.Text = "Teacher";
            this.teacherRB.UseVisualStyleBackColor = true;
            this.teacherRB.CheckedChanged += new System.EventHandler(this.teacherRB_CheckedChanged);
            // 
            // exit1B
            // 
            this.exit1B.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exit1B.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit1B.Location = new System.Drawing.Point(101, 265);
            this.exit1B.Name = "exit1B";
            this.exit1B.Size = new System.Drawing.Size(96, 42);
            this.exit1B.TabIndex = 5;
            this.exit1B.Text = "Exit";
            this.exit1B.UseVisualStyleBackColor = true;
            this.exit1B.Click += new System.EventHandler(this.exit1B_Click);
            // 
            // passwordTB
            // 
            this.passwordTB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTB.Location = new System.Drawing.Point(237, 97);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '*';
            this.passwordTB.Size = new System.Drawing.Size(166, 26);
            this.passwordTB.TabIndex = 1;
            // 
            // usernameTB
            // 
            this.usernameTB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTB.Location = new System.Drawing.Point(237, 46);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(166, 26);
            this.usernameTB.TabIndex = 0;
            this.usernameTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usernameTB_KeyPress);
            // 
            // logB
            // 
            this.logB.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logB.Location = new System.Drawing.Point(307, 265);
            this.logB.Name = "logB";
            this.logB.Size = new System.Drawing.Size(96, 42);
            this.logB.TabIndex = 4;
            this.logB.Text = "Log In";
            this.logB.UseVisualStyleBackColor = true;
            this.logB.Click += new System.EventHandler(this.logB_Click);
            // 
            // passwordLB
            // 
            this.passwordLB.AutoSize = true;
            this.passwordLB.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.passwordLB.Location = new System.Drawing.Point(78, 97);
            this.passwordLB.Name = "passwordLB";
            this.passwordLB.Size = new System.Drawing.Size(96, 24);
            this.passwordLB.TabIndex = 2;
            this.passwordLB.Text = "Password";
            // 
            // usernameLB
            // 
            this.usernameLB.AutoSize = true;
            this.usernameLB.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.usernameLB.Location = new System.Drawing.Point(78, 42);
            this.usernameLB.Name = "usernameLB";
            this.usernameLB.Size = new System.Drawing.Size(109, 24);
            this.usernameLB.TabIndex = 1;
            this.usernameLB.Text = "User Name";
            this.usernameLB.Click += new System.EventHandler(this.usernameLB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(710, 65);
            this.label1.TabIndex = 9;
            this.label1.Text = "Final Result Processing System";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(590, 633);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(299, 63);
            this.label8.TabIndex = 12;
            this.label8.Text = "Jahangirnagar University ,Savar, Dhaka\r\nPhone No. +8801766 142768\r\nE-mail : pi.so" +
    "ft.ltd@gmail.com";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(589, 584);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 28);
            this.label5.TabIndex = 13;
            this.label5.Text = "Pi Soft Ltd";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FinalResultProcessingSystem.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(431, 584);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 112);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // LogInF
            // 
            this.AcceptButton = this.logB;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.CancelButton = this.exit1B;
            this.ClientSize = new System.Drawing.Size(1362, 705);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogInF";
            this.Text = "Final Result Processing System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.Button logB;
        private System.Windows.Forms.Label passwordLB;
        private System.Windows.Forms.Label usernameLB;
        private System.Windows.Forms.Button exit1B;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton teacherRB;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton adminRB;
    }
}

