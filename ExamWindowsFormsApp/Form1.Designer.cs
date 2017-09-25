namespace ExamWindowsFormsApp
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAssign = new System.Windows.Forms.Button();
            this.textBoxStudent = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGrade = new System.Windows.Forms.Button();
            this.comboBoxGrade = new System.Windows.Forms.ComboBox();
            this.comboBoxStudent = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAssign);
            this.groupBox1.Controls.Add(this.textBoxStudent);
            this.groupBox1.Location = new System.Drawing.Point(0, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Information";
            // 
            // buttonAssign
            // 
            this.buttonAssign.Location = new System.Drawing.Point(193, 23);
            this.buttonAssign.Name = "buttonAssign";
            this.buttonAssign.Size = new System.Drawing.Size(78, 28);
            this.buttonAssign.TabIndex = 1;
            this.buttonAssign.Text = "Assign";
            this.buttonAssign.UseVisualStyleBackColor = true;
            // 
            // textBoxStudent
            // 
            this.textBoxStudent.Location = new System.Drawing.Point(6, 28);
            this.textBoxStudent.Name = "textBoxStudent";
            this.textBoxStudent.Size = new System.Drawing.Size(164, 20);
            this.textBoxStudent.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGrade);
            this.groupBox2.Controls.Add(this.comboBoxGrade);
            this.groupBox2.Controls.Add(this.comboBoxStudent);
            this.groupBox2.Location = new System.Drawing.Point(6, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 80);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grade";
            // 
            // btnGrade
            // 
            this.btnGrade.Location = new System.Drawing.Point(155, 59);
            this.btnGrade.Name = "btnGrade";
            this.btnGrade.Size = new System.Drawing.Size(84, 20);
            this.btnGrade.TabIndex = 2;
            this.btnGrade.Text = "Grade";
            this.btnGrade.UseVisualStyleBackColor = true;
            // 
            // comboBoxGrade
            // 
            this.comboBoxGrade.FormattingEnabled = true;
            this.comboBoxGrade.Location = new System.Drawing.Point(6, 54);
            this.comboBoxGrade.Name = "comboBoxGrade";
            this.comboBoxGrade.Size = new System.Drawing.Size(117, 21);
            this.comboBoxGrade.TabIndex = 1;
            // 
            // comboBoxStudent
            // 
            this.comboBoxStudent.FormattingEnabled = true;
            this.comboBoxStudent.Items.AddRange(new object[] {
            "IG",
            "G",
            "VG"});
            this.comboBoxStudent.Location = new System.Drawing.Point(7, 21);
            this.comboBoxStudent.Name = "comboBoxStudent";
            this.comboBoxStudent.Size = new System.Drawing.Size(268, 21);
            this.comboBoxStudent.TabIndex = 0;
            this.comboBoxStudent.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGenerate);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(13, 223);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(379, 130);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Statistics";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(270, 60);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(96, 43);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "VG:0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "G:0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "IG:0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 370);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAssign;
        private System.Windows.Forms.TextBox textBoxStudent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGrade;
        private System.Windows.Forms.ComboBox comboBoxGrade;
        private System.Windows.Forms.ComboBox comboBoxStudent;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerate;
    }
}

