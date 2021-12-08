
namespace BookForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_Filter = new System.Windows.Forms.ComboBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.lb_Book = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_Genre = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book name";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(35, 71);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(117, 20);
            this.txt_name.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(469, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_number
            // 
            this.txt_number.Location = new System.Drawing.Point(211, 71);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(130, 20);
            this.txt_number.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ISBN number";
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(398, 71);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(133, 20);
            this.txt_price.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Filter by genre";
            // 
            // cmb_Filter
            // 
            this.cmb_Filter.FormattingEnabled = true;
            this.cmb_Filter.Location = new System.Drawing.Point(66, 262);
            this.cmb_Filter.Name = "cmb_Filter";
            this.cmb_Filter.Size = new System.Drawing.Size(416, 21);
            this.cmb_Filter.TabIndex = 10;
            this.cmb_Filter.SelectedIndexChanged += new System.EventHandler(this.cmb_Filter_SelectedIndexChanged);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // lb_Book
            // 
            this.lb_Book.FormattingEnabled = true;
            this.lb_Book.Location = new System.Drawing.Point(66, 297);
            this.lb_Book.Name = "lb_Book";
            this.lb_Book.Size = new System.Drawing.Size(521, 121);
            this.lb_Book.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(573, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Genre";
            // 
            // cmb_Genre
            // 
            this.cmb_Genre.FormattingEnabled = true;
            this.cmb_Genre.Location = new System.Drawing.Point(576, 70);
            this.cmb_Genre.Name = "cmb_Genre";
            this.cmb_Genre.Size = new System.Drawing.Size(133, 21);
            this.cmb_Genre.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmb_Genre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_Book);
            this.Controls.Add(this.cmb_Filter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_number);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_Filter;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ListBox lb_Book;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_Genre;
    }
}

