namespace FinalResultProcessingSystem.Admin
{
    partial class courseinfoF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(courseinfoF));
            this.courseDGV = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.courseinfoGB = new System.Windows.Forms.GroupBox();
            this.backB = new System.Windows.Forms.Button();
            this.cancelB = new System.Windows.Forms.Button();
            this.updateB = new System.Windows.Forms.Button();
            this.ctitleTB = new System.Windows.Forms.TextBox();
            this.ccodeTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchB = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.searchcourseGB = new System.Windows.Forms.GroupBox();
            this.session2CB = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.searchccodeTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.editcourseGB = new System.Windows.Forms.GroupBox();
            this.deleteB = new System.Windows.Forms.Button();
            this.addB = new System.Windows.Forms.Button();
            this.ccreditCB = new System.Windows.Forms.ComboBox();
            this.sessionCB = new System.Windows.Forms.ComboBox();
            this.yearCB = new System.Windows.Forms.ComboBox();
            this.cTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.semCB = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.courseDGV)).BeginInit();
            this.courseinfoGB.SuspendLayout();
            this.searchcourseGB.SuspendLayout();
            this.editcourseGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // courseDGV
            // 
            this.courseDGV.BackgroundColor = System.Drawing.Color.Ivory;
            this.courseDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseDGV.Location = new System.Drawing.Point(0, 18);
            this.courseDGV.Name = "courseDGV";
            this.courseDGV.ReadOnly = true;
            this.courseDGV.Size = new System.Drawing.Size(726, 496);
            this.courseDGV.TabIndex = 3;
            this.courseDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.courseDGV_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(225, -4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(361, 44);
            this.label6.TabIndex = 45;
            this.label6.Text = "All Course Information";
            // 
            // courseinfoGB
            // 
            this.courseinfoGB.BackColor = System.Drawing.Color.Ivory;
            this.courseinfoGB.Controls.Add(this.courseDGV);
            this.courseinfoGB.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseinfoGB.Location = new System.Drawing.Point(38, 54);
            this.courseinfoGB.Name = "courseinfoGB";
            this.courseinfoGB.Size = new System.Drawing.Size(727, 608);
            this.courseinfoGB.TabIndex = 44;
            this.courseinfoGB.TabStop = false;
            this.courseinfoGB.Text = "All Course Information";
            // 
            // backB
            // 
            this.backB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backB.Location = new System.Drawing.Point(319, 393);
            this.backB.Name = "backB";
            this.backB.Size = new System.Drawing.Size(91, 38);
            this.backB.TabIndex = 43;
            this.backB.Text = "Back";
            this.backB.UseVisualStyleBackColor = true;
            this.backB.Click += new System.EventHandler(this.backB_Click);
            // 
            // cancelB
            // 
            this.cancelB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelB.Location = new System.Drawing.Point(416, 393);
            this.cancelB.Name = "cancelB";
            this.cancelB.Size = new System.Drawing.Size(91, 38);
            this.cancelB.TabIndex = 11;
            this.cancelB.Text = "Clear";
            this.cancelB.UseVisualStyleBackColor = true;
            this.cancelB.Click += new System.EventHandler(this.cancelB_Click);
            // 
            // updateB
            // 
            this.updateB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateB.Location = new System.Drawing.Point(123, 393);
            this.updateB.Name = "updateB";
            this.updateB.Size = new System.Drawing.Size(90, 38);
            this.updateB.TabIndex = 40;
            this.updateB.Text = "Update";
            this.updateB.UseVisualStyleBackColor = true;
            this.updateB.Click += new System.EventHandler(this.updateB_Click);
            // 
            // ctitleTB
            // 
            this.ctitleTB.Location = new System.Drawing.Point(213, 103);
            this.ctitleTB.Name = "ctitleTB";
            this.ctitleTB.Size = new System.Drawing.Size(270, 25);
            this.ctitleTB.TabIndex = 6;
            // 
            // ccodeTB
            // 
            this.ccodeTB.Location = new System.Drawing.Point(213, 50);
            this.ccodeTB.Name = "ccodeTB";
            this.ccodeTB.Size = new System.Drawing.Size(270, 25);
            this.ccodeTB.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Course Title";
            // 
            // searchB
            // 
            this.searchB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchB.Location = new System.Drawing.Point(393, 108);
            this.searchB.Name = "searchB";
            this.searchB.Size = new System.Drawing.Size(90, 38);
            this.searchB.TabIndex = 40;
            this.searchB.Text = "Search";
            this.searchB.UseVisualStyleBackColor = true;
            this.searchB.Click += new System.EventHandler(this.searchB_Click);
            this.searchB.Enter += new System.EventHandler(this.searchB_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Course Credit";
            // 
            // searchcourseGB
            // 
            this.searchcourseGB.BackColor = System.Drawing.Color.Ivory;
            this.searchcourseGB.Controls.Add(this.session2CB);
            this.searchcourseGB.Controls.Add(this.label8);
            this.searchcourseGB.Controls.Add(this.button2);
            this.searchcourseGB.Controls.Add(this.searchB);
            this.searchcourseGB.Controls.Add(this.searchccodeTB);
            this.searchcourseGB.Controls.Add(this.label10);
            this.searchcourseGB.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchcourseGB.Location = new System.Drawing.Point(796, 54);
            this.searchcourseGB.Name = "searchcourseGB";
            this.searchcourseGB.Size = new System.Drawing.Size(533, 152);
            this.searchcourseGB.TabIndex = 47;
            this.searchcourseGB.TabStop = false;
            this.searchcourseGB.Text = "Search Course";
            // 
            // session2CB
            // 
            this.session2CB.FormattingEnabled = true;
            this.session2CB.Location = new System.Drawing.Point(213, 36);
            this.session2CB.Name = "session2CB";
            this.session2CB.Size = new System.Drawing.Size(270, 26);
            this.session2CB.TabIndex = 102;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 18);
            this.label8.TabIndex = 101;
            this.label8.Text = "Session";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(432, 432);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 38);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // searchccodeTB
            // 
            this.searchccodeTB.Location = new System.Drawing.Point(213, 73);
            this.searchccodeTB.Name = "searchccodeTB";
            this.searchccodeTB.Size = new System.Drawing.Size(270, 25);
            this.searchccodeTB.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "Course Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Course Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Session";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course Code";
            // 
            // editcourseGB
            // 
            this.editcourseGB.BackColor = System.Drawing.Color.Ivory;
            this.editcourseGB.Controls.Add(this.semCB);
            this.editcourseGB.Controls.Add(this.label9);
            this.editcourseGB.Controls.Add(this.deleteB);
            this.editcourseGB.Controls.Add(this.addB);
            this.editcourseGB.Controls.Add(this.backB);
            this.editcourseGB.Controls.Add(this.ccreditCB);
            this.editcourseGB.Controls.Add(this.sessionCB);
            this.editcourseGB.Controls.Add(this.yearCB);
            this.editcourseGB.Controls.Add(this.cTB);
            this.editcourseGB.Controls.Add(this.label7);
            this.editcourseGB.Controls.Add(this.cancelB);
            this.editcourseGB.Controls.Add(this.updateB);
            this.editcourseGB.Controls.Add(this.ctitleTB);
            this.editcourseGB.Controls.Add(this.ccodeTB);
            this.editcourseGB.Controls.Add(this.label5);
            this.editcourseGB.Controls.Add(this.label4);
            this.editcourseGB.Controls.Add(this.label3);
            this.editcourseGB.Controls.Add(this.label2);
            this.editcourseGB.Controls.Add(this.label1);
            this.editcourseGB.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editcourseGB.Location = new System.Drawing.Point(796, 212);
            this.editcourseGB.Name = "editcourseGB";
            this.editcourseGB.Size = new System.Drawing.Size(533, 450);
            this.editcourseGB.TabIndex = 46;
            this.editcourseGB.TabStop = false;
            this.editcourseGB.Text = "Course Information";
            // 
            // deleteB
            // 
            this.deleteB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteB.Location = new System.Drawing.Point(223, 393);
            this.deleteB.Name = "deleteB";
            this.deleteB.Size = new System.Drawing.Size(90, 38);
            this.deleteB.TabIndex = 103;
            this.deleteB.Text = "Delete";
            this.deleteB.UseVisualStyleBackColor = true;
            this.deleteB.Click += new System.EventHandler(this.deleteB_Click);
            // 
            // addB
            // 
            this.addB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addB.Location = new System.Drawing.Point(27, 393);
            this.addB.Name = "addB";
            this.addB.Size = new System.Drawing.Size(90, 38);
            this.addB.TabIndex = 102;
            this.addB.Text = "Add";
            this.addB.UseVisualStyleBackColor = true;
            this.addB.Click += new System.EventHandler(this.addB_Click);
            // 
            // ccreditCB
            // 
            this.ccreditCB.FormattingEnabled = true;
            this.ccreditCB.Items.AddRange(new object[] {
            "4",
            "3.5",
            "3",
            "2.5",
            "2",
            "1.5",
            "1",
            "0.5"});
            this.ccreditCB.Location = new System.Drawing.Point(213, 153);
            this.ccreditCB.Name = "ccreditCB";
            this.ccreditCB.Size = new System.Drawing.Size(270, 26);
            this.ccreditCB.TabIndex = 101;
            // 
            // sessionCB
            // 
            this.sessionCB.FormattingEnabled = true;
            this.sessionCB.Location = new System.Drawing.Point(213, 246);
            this.sessionCB.Name = "sessionCB";
            this.sessionCB.Size = new System.Drawing.Size(270, 26);
            this.sessionCB.TabIndex = 100;
            // 
            // yearCB
            // 
            this.yearCB.FormattingEnabled = true;
            this.yearCB.Items.AddRange(new object[] {
            "1st Year",
            "2nd Year",
            "3rd Year",
            "4th Year"});
            this.yearCB.Location = new System.Drawing.Point(213, 296);
            this.yearCB.Name = "yearCB";
            this.yearCB.Size = new System.Drawing.Size(270, 26);
            this.yearCB.TabIndex = 99;
            // 
            // cTB
            // 
            this.cTB.Location = new System.Drawing.Point(213, 200);
            this.cTB.Name = "cTB";
            this.cTB.Size = new System.Drawing.Size(270, 25);
            this.cTB.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 18);
            this.label7.TabIndex = 41;
            this.label7.Text = "Year";
            // 
            // semCB
            // 
            this.semCB.FormattingEnabled = true;
            this.semCB.Items.AddRange(new object[] {
            "1st Semester",
            "2nd Semester"});
            this.semCB.Location = new System.Drawing.Point(213, 342);
            this.semCB.Name = "semCB";
            this.semCB.Size = new System.Drawing.Size(270, 26);
            this.semCB.TabIndex = 105;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 350);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 18);
            this.label9.TabIndex = 104;
            this.label9.Text = "Semester";
            // 
            // courseinfoF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1362, 705);
            this.Controls.Add(this.searchcourseGB);
            this.Controls.Add(this.editcourseGB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.courseinfoGB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "courseinfoF";
            this.Text = "Course Information";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.courseinfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseDGV)).EndInit();
            this.courseinfoGB.ResumeLayout(false);
            this.searchcourseGB.ResumeLayout(false);
            this.searchcourseGB.PerformLayout();
            this.editcourseGB.ResumeLayout(false);
            this.editcourseGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView courseDGV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox courseinfoGB;
        private System.Windows.Forms.Button backB;
        private System.Windows.Forms.Button cancelB;
        private System.Windows.Forms.Button updateB;
        private System.Windows.Forms.TextBox ctitleTB;
        private System.Windows.Forms.TextBox ccodeTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox searchcourseGB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox searchccodeTB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox editcourseGB;
        private System.Windows.Forms.TextBox cTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox yearCB;
        private System.Windows.Forms.ComboBox sessionCB;
        private System.Windows.Forms.ComboBox ccreditCB;
        private System.Windows.Forms.Button deleteB;
        private System.Windows.Forms.Button addB;
        private System.Windows.Forms.ComboBox session2CB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox semCB;
        private System.Windows.Forms.Label label9;
    }
}