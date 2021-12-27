
namespace photoTEST
{
    partial class SelectList
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.cmbSurname = new System.Windows.Forms.ComboBox();
            this.cmbName = new System.Windows.Forms.ComboBox();
            this.cmbEmail = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Surname";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(42, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 113);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(432, 122);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(221, 199);
            this.listBox.TabIndex = 16;
            // 
            // cmbSearch
            // 
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Location = new System.Drawing.Point(432, 53);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(121, 21);
            this.cmbSearch.TabIndex = 17;
            this.cmbSearch.SelectedIndexChanged += new System.EventHandler(this.cmbSearch_SelectedIndexChanged_1);
            // 
            // cmbSurname
            // 
            this.cmbSurname.FormattingEnabled = true;
            this.cmbSurname.Location = new System.Drawing.Point(247, 202);
            this.cmbSurname.Name = "cmbSurname";
            this.cmbSurname.Size = new System.Drawing.Size(121, 21);
            this.cmbSurname.TabIndex = 18;
            // 
            // cmbName
            // 
            this.cmbName.FormattingEnabled = true;
            this.cmbName.Location = new System.Drawing.Point(247, 91);
            this.cmbName.Name = "cmbName";
            this.cmbName.Size = new System.Drawing.Size(121, 21);
            this.cmbName.TabIndex = 19;
            // 
            // cmbEmail
            // 
            this.cmbEmail.FormattingEnabled = true;
            this.cmbEmail.Location = new System.Drawing.Point(247, 300);
            this.cmbEmail.Name = "cmbEmail";
            this.cmbEmail.Size = new System.Drawing.Size(121, 21);
            this.cmbEmail.TabIndex = 20;
            // 
            // SelectList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 450);
            this.Controls.Add(this.cmbEmail);
            this.Controls.Add(this.cmbName);
            this.Controls.Add(this.cmbSurname);
            this.Controls.Add(this.cmbSearch);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "SelectList";
            this.Text = "SelectList";
            this.Load += new System.EventHandler(this.SelectList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.ComboBox cmbSurname;
        private System.Windows.Forms.ComboBox cmbName;
        private System.Windows.Forms.ComboBox cmbEmail;
    }
}