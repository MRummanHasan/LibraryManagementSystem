namespace LMS
{
    partial class IssueBook
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
            this.issueStIDbox = new System.Windows.Forms.TextBox();
            this.issueStNameBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // issueStIDbox
            // 
            this.issueStIDbox.Location = new System.Drawing.Point(130, 70);
            this.issueStIDbox.Name = "issueStIDbox";
            this.issueStIDbox.Size = new System.Drawing.Size(100, 20);
            this.issueStIDbox.TabIndex = 0;
            // 
            // issueStNameBox
            // 
            this.issueStNameBox.Location = new System.Drawing.Point(130, 111);
            this.issueStNameBox.Name = "issueStNameBox";
            this.issueStNameBox.Size = new System.Drawing.Size(100, 20);
            this.issueStNameBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Issue Book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IssueBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.issueStNameBox);
            this.Controls.Add(this.issueStIDbox);
            this.Name = "IssueBook";
            this.Text = "IssueBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox issueStIDbox;
        private System.Windows.Forms.TextBox issueStNameBox;
        private System.Windows.Forms.Button button1;
    }
}