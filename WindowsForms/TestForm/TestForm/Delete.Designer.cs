
namespace TestForm
{
    partial class Delete
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbGroupDelete = new System.Windows.Forms.ComboBox();
            this.cmbStuDelete = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Group";
            // 
            // cmbGroupDelete
            // 
            this.cmbGroupDelete.FormattingEnabled = true;
            this.cmbGroupDelete.Location = new System.Drawing.Point(103, 79);
            this.cmbGroupDelete.Name = "cmbGroupDelete";
            this.cmbGroupDelete.Size = new System.Drawing.Size(121, 21);
            this.cmbGroupDelete.TabIndex = 1;
            this.cmbGroupDelete.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbStuDelete
            // 
            this.cmbStuDelete.FormattingEnabled = true;
            this.cmbStuDelete.Location = new System.Drawing.Point(103, 205);
            this.cmbStuDelete.Name = "cmbStuDelete";
            this.cmbStuDelete.Size = new System.Drawing.Size(121, 21);
            this.cmbStuDelete.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Student";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 63);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 412);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbStuDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbGroupDelete);
            this.Controls.Add(this.label1);
            this.Name = "Delete";
            this.Text = "Delete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGroupDelete;
        private System.Windows.Forms.ComboBox cmbStuDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}