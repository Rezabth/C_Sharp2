namespace StoryTellerWindowsApp
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
            this.NameOfChild = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbScary = new System.Windows.Forms.CheckBox();
            this.tbNameOfChild = new System.Windows.Forms.TextBox();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.btnTellStory = new System.Windows.Forms.Button();
            this.tbstory = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            this.SuspendLayout();
            // 
            // NameOfChild
            // 
            this.NameOfChild.AutoSize = true;
            this.NameOfChild.Location = new System.Drawing.Point(12, 27);
            this.NameOfChild.Name = "NameOfChild";
            this.NameOfChild.Size = new System.Drawing.Size(76, 13);
            this.NameOfChild.TabIndex = 0;
            this.NameOfChild.Text = "Name  of Child";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age of Child";
            // 
            // cbScary
            // 
            this.cbScary.AutoSize = true;
            this.cbScary.Location = new System.Drawing.Point(18, 114);
            this.cbScary.Name = "cbScary";
            this.cbScary.Size = new System.Drawing.Size(102, 17);
            this.cbScary.TabIndex = 2;
            this.cbScary.Text = "Should be scary";
            this.cbScary.UseVisualStyleBackColor = true;
            // 
            // tbNameOfChild
            // 
            this.tbNameOfChild.Location = new System.Drawing.Point(93, 25);
            this.tbNameOfChild.Name = "tbNameOfChild";
            this.tbNameOfChild.Size = new System.Drawing.Size(127, 20);
            this.tbNameOfChild.TabIndex = 3;
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(93, 78);
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(120, 20);
            this.numAge.TabIndex = 4;
            // 
            // btnTellStory
            // 
            this.btnTellStory.AccessibleName = "";
            this.btnTellStory.Location = new System.Drawing.Point(24, 159);
            this.btnTellStory.Name = "btnTellStory";
            this.btnTellStory.Size = new System.Drawing.Size(113, 23);
            this.btnTellStory.TabIndex = 5;
            this.btnTellStory.Text = "Tell Story";
            this.btnTellStory.UseVisualStyleBackColor = true;
            this.btnTellStory.Click += new System.EventHandler(this.buttonTellStory_Click);
            // 
            // tbstory
            // 
            this.tbstory.Location = new System.Drawing.Point(24, 188);
            this.tbstory.Name = "tbstory";
            this.tbstory.Size = new System.Drawing.Size(275, 68);
            this.tbstory.TabIndex = 6;
            this.tbstory.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 261);
            this.Controls.Add(this.tbstory);
            this.Controls.Add(this.btnTellStory);
            this.Controls.Add(this.numAge);
            this.Controls.Add(this.tbNameOfChild);
            this.Controls.Add(this.cbScary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameOfChild);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameOfChild;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbScary;
        private System.Windows.Forms.TextBox tbNameOfChild;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.Button btnTellStory;
        private System.Windows.Forms.RichTextBox tbstory;
    }
}

