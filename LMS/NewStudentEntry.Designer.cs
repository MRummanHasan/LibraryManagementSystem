namespace LMS
{
    partial class NewStudentEntry
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addSt = new System.Windows.Forms.Button();
            this.newStNameBox = new System.Windows.Forms.TextBox();
            this.newStIDBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Student Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Student ID";
            // 
            // addSt
            // 
            this.addSt.Location = new System.Drawing.Point(91, 184);
            this.addSt.Name = "addSt";
            this.addSt.Size = new System.Drawing.Size(94, 31);
            this.addSt.TabIndex = 10;
            this.addSt.Text = "Add Student";
            this.addSt.UseVisualStyleBackColor = true;
            this.addSt.Click += new System.EventHandler(this.addSt_Click);
            // 
            // newStNameBox
            // 
            this.newStNameBox.Location = new System.Drawing.Point(132, 103);
            this.newStNameBox.Name = "newStNameBox";
            this.newStNameBox.Size = new System.Drawing.Size(100, 20);
            this.newStNameBox.TabIndex = 8;
            // 
            // newStIDBox
            // 
            this.newStIDBox.Location = new System.Drawing.Point(132, 56);
            this.newStIDBox.Name = "newStIDBox";
            this.newStIDBox.Size = new System.Drawing.Size(100, 20);
            this.newStIDBox.TabIndex = 7;
            // 
            // NewStudentEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addSt);
            this.Controls.Add(this.newStNameBox);
            this.Controls.Add(this.newStIDBox);
            this.Name = "NewStudentEntry";
            this.Text = "NewStudentEntry";
            this.Load += new System.EventHandler(this.NewStudentEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addSt;
        private System.Windows.Forms.TextBox newStNameBox;
        private System.Windows.Forms.TextBox newStIDBox;
    }
}