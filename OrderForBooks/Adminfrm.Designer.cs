
namespace OrderForBooks
{
    partial class Adminfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adminfrm));
            this.btnMainCustomers = new System.Windows.Forms.Button();
            this.btnMainBooks = new System.Windows.Forms.Button();
            this.btnMainAuthors = new System.Windows.Forms.Button();
            this.btnReqReports = new System.Windows.Forms.Button();
            this.lblTitle3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMainCustomers
            // 
            this.btnMainCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainCustomers.Location = new System.Drawing.Point(25, 83);
            this.btnMainCustomers.Name = "btnMainCustomers";
            this.btnMainCustomers.Size = new System.Drawing.Size(168, 57);
            this.btnMainCustomers.TabIndex = 0;
            this.btnMainCustomers.Text = "Customers";
            this.btnMainCustomers.UseVisualStyleBackColor = true;
            this.btnMainCustomers.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMainBooks
            // 
            this.btnMainBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainBooks.Location = new System.Drawing.Point(25, 169);
            this.btnMainBooks.Name = "btnMainBooks";
            this.btnMainBooks.Size = new System.Drawing.Size(168, 48);
            this.btnMainBooks.TabIndex = 1;
            this.btnMainBooks.Text = "Books";
            this.btnMainBooks.UseVisualStyleBackColor = true;
            this.btnMainBooks.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMainAuthors
            // 
            this.btnMainAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainAuthors.Location = new System.Drawing.Point(25, 243);
            this.btnMainAuthors.Name = "btnMainAuthors";
            this.btnMainAuthors.Size = new System.Drawing.Size(168, 47);
            this.btnMainAuthors.TabIndex = 2;
            this.btnMainAuthors.Text = "Authors";
            this.btnMainAuthors.UseVisualStyleBackColor = true;
            this.btnMainAuthors.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnReqReports
            // 
            this.btnReqReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReqReports.Location = new System.Drawing.Point(25, 315);
            this.btnReqReports.Name = "btnReqReports";
            this.btnReqReports.Size = new System.Drawing.Size(168, 47);
            this.btnReqReports.TabIndex = 3;
            this.btnReqReports.Text = "Reports";
            this.btnReqReports.UseVisualStyleBackColor = true;
            this.btnReqReports.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblTitle3
            // 
            this.lblTitle3.AutoSize = true;
            this.lblTitle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle3.Location = new System.Drawing.Point(97, 9);
            this.lblTitle3.Name = "lblTitle3";
            this.lblTitle3.Size = new System.Drawing.Size(587, 31);
            this.lblTitle3.TabIndex = 4;
            this.lblTitle3.Text = "MAINTENANCE AND REQUEST REPORTS";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(624, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(253, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(535, 326);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(525, 415);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 23);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Adminfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTitle3);
            this.Controls.Add(this.btnReqReports);
            this.Controls.Add(this.btnMainAuthors);
            this.Controls.Add(this.btnMainBooks);
            this.Controls.Add(this.btnMainCustomers);
            this.Name = "Adminfrm";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMainCustomers;
        private System.Windows.Forms.Button btnMainBooks;
        private System.Windows.Forms.Button btnMainAuthors;
        private System.Windows.Forms.Button btnReqReports;
        private System.Windows.Forms.Label lblTitle3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBack;
    }
}