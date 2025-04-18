﻿
namespace MaintainAuthors
{
    partial class MaintainAuthorsFrm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.dgAddAuthor = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.dgUpdateAuthor = new System.Windows.Forms.DataGridView();
            this.cbUpdateAuthor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAuthorID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtContactU = new System.Windows.Forms.TextBox();
            this.txtLNameU = new System.Windows.Forms.TextBox();
            this.txtFNameU = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExitU = new System.Windows.Forms.Button();
            this.btnClearU = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblDelete = new System.Windows.Forms.Label();
            this.dgDeleteAuthor = new System.Windows.Forms.DataGridView();
            this.cbDeleteAuthor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnExitD = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAddAuthor)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUpdateAuthor)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDeleteAuthor)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(666, 523);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::MaintainAuthors.Properties.Resources.author;
            this.tabPage1.Controls.Add(this.btnExit);
            this.tabPage1.Controls.Add(this.btnClear);
            this.tabPage1.Controls.Add(this.btnAddAuthor);
            this.tabPage1.Controls.Add(this.dgAddAuthor);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(658, 497);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add New Author";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(544, 438);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 41);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(397, 438);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 41);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.BackColor = System.Drawing.Color.White;
            this.btnAddAuthor.ForeColor = System.Drawing.Color.Black;
            this.btnAddAuthor.Location = new System.Drawing.Point(239, 438);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(96, 41);
            this.btnAddAuthor.TabIndex = 8;
            this.btnAddAuthor.Text = "Add Author";
            this.btnAddAuthor.UseVisualStyleBackColor = false;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // dgAddAuthor
            // 
            this.dgAddAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAddAuthor.Location = new System.Drawing.Point(30, 241);
            this.dgAddAuthor.Name = "dgAddAuthor";
            this.dgAddAuthor.Size = new System.Drawing.Size(611, 180);
            this.dgAddAuthor.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtContact);
            this.groupBox1.Controls.Add(this.txtLName);
            this.groupBox1.Controls.Add(this.txtFName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(30, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 200);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Author Details";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(143, 159);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(174, 20);
            this.txtContact.TabIndex = 5;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(143, 95);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(174, 20);
            this.txtLName.TabIndex = 4;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(143, 36);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(174, 20);
            this.txtFName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(27, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(27, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(27, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "First Name:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::MaintainAuthors.Properties.Resources.author;
            this.tabPage2.Controls.Add(this.lblUpdate);
            this.tabPage2.Controls.Add(this.dgUpdateAuthor);
            this.tabPage2.Controls.Add(this.cbUpdateAuthor);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.btnUpdate);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.btnExitU);
            this.tabPage2.Controls.Add(this.btnClearU);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(658, 497);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Update Author";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.BackColor = System.Drawing.Color.White;
            this.lblUpdate.ForeColor = System.Drawing.Color.Red;
            this.lblUpdate.Location = new System.Drawing.Point(27, 7);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(163, 13);
            this.lblUpdate.TabIndex = 22;
            this.lblUpdate.Text = "Click here to load the database...";
            this.lblUpdate.Click += new System.EventHandler(this.lblUpdate_Click);
            // 
            // dgUpdateAuthor
            // 
            this.dgUpdateAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUpdateAuthor.Location = new System.Drawing.Point(27, 67);
            this.dgUpdateAuthor.Name = "dgUpdateAuthor";
            this.dgUpdateAuthor.Size = new System.Drawing.Size(598, 150);
            this.dgUpdateAuthor.TabIndex = 21;
            // 
            // cbUpdateAuthor
            // 
            this.cbUpdateAuthor.FormattingEnabled = true;
            this.cbUpdateAuthor.Location = new System.Drawing.Point(212, 33);
            this.cbUpdateAuthor.Name = "cbUpdateAuthor";
            this.cbUpdateAuthor.Size = new System.Drawing.Size(121, 21);
            this.cbUpdateAuthor.TabIndex = 20;
            this.cbUpdateAuthor.SelectedIndexChanged += new System.EventHandler(this.cbUpdateAuthor_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(24, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Select Author to Update:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(212, 441);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 41);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.txtAuthorID);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtContactU);
            this.groupBox2.Controls.Add(this.txtLNameU);
            this.groupBox2.Controls.Add(this.txtFNameU);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(27, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 200);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Author Details";
            // 
            // txtAuthorID
            // 
            this.txtAuthorID.Enabled = false;
            this.txtAuthorID.ForeColor = System.Drawing.Color.Red;
            this.txtAuthorID.Location = new System.Drawing.Point(143, 36);
            this.txtAuthorID.Name = "txtAuthorID";
            this.txtAuthorID.Size = new System.Drawing.Size(174, 20);
            this.txtAuthorID.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Author ID:";
            // 
            // txtContactU
            // 
            this.txtContactU.Location = new System.Drawing.Point(143, 159);
            this.txtContactU.Name = "txtContactU";
            this.txtContactU.Size = new System.Drawing.Size(174, 20);
            this.txtContactU.TabIndex = 5;
            // 
            // txtLNameU
            // 
            this.txtLNameU.Location = new System.Drawing.Point(143, 117);
            this.txtLNameU.Name = "txtLNameU";
            this.txtLNameU.Size = new System.Drawing.Size(174, 20);
            this.txtLNameU.TabIndex = 4;
            // 
            // txtFNameU
            // 
            this.txtFNameU.Location = new System.Drawing.Point(143, 77);
            this.txtFNameU.Name = "txtFNameU";
            this.txtFNameU.Size = new System.Drawing.Size(174, 20);
            this.txtFNameU.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Contact Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Last Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "First Name:";
            // 
            // btnExitU
            // 
            this.btnExitU.BackColor = System.Drawing.Color.White;
            this.btnExitU.Location = new System.Drawing.Point(529, 441);
            this.btnExitU.Name = "btnExitU";
            this.btnExitU.Size = new System.Drawing.Size(96, 41);
            this.btnExitU.TabIndex = 15;
            this.btnExitU.Text = "Exit";
            this.btnExitU.UseVisualStyleBackColor = false;
            this.btnExitU.Click += new System.EventHandler(this.btnExitU_Click);
            // 
            // btnClearU
            // 
            this.btnClearU.BackColor = System.Drawing.Color.White;
            this.btnClearU.Location = new System.Drawing.Point(377, 441);
            this.btnClearU.Name = "btnClearU";
            this.btnClearU.Size = new System.Drawing.Size(96, 41);
            this.btnClearU.TabIndex = 14;
            this.btnClearU.Text = "Clear";
            this.btnClearU.UseVisualStyleBackColor = false;
            this.btnClearU.Click += new System.EventHandler(this.btnClearU_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::MaintainAuthors.Properties.Resources.author;
            this.tabPage3.Controls.Add(this.lblDelete);
            this.tabPage3.Controls.Add(this.dgDeleteAuthor);
            this.tabPage3.Controls.Add(this.cbDeleteAuthor);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.btnExitD);
            this.tabPage3.Controls.Add(this.btnDelete);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(658, 497);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Delete Author";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.BackColor = System.Drawing.Color.White;
            this.lblDelete.ForeColor = System.Drawing.Color.Red;
            this.lblDelete.Location = new System.Drawing.Point(35, 10);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(163, 13);
            this.lblDelete.TabIndex = 25;
            this.lblDelete.Text = "Click here to load the database...";
            this.lblDelete.Click += new System.EventHandler(this.lblDelete_Click);
            // 
            // dgDeleteAuthor
            // 
            this.dgDeleteAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDeleteAuthor.Location = new System.Drawing.Point(38, 75);
            this.dgDeleteAuthor.Name = "dgDeleteAuthor";
            this.dgDeleteAuthor.Size = new System.Drawing.Size(597, 359);
            this.dgDeleteAuthor.TabIndex = 24;
            // 
            // cbDeleteAuthor
            // 
            this.cbDeleteAuthor.FormattingEnabled = true;
            this.cbDeleteAuthor.Location = new System.Drawing.Point(223, 39);
            this.cbDeleteAuthor.Name = "cbDeleteAuthor";
            this.cbDeleteAuthor.Size = new System.Drawing.Size(121, 21);
            this.cbDeleteAuthor.TabIndex = 23;
            this.cbDeleteAuthor.SelectedIndexChanged += new System.EventHandler(this.cbDeleteAuthor_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(35, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Select Author to Delete:";
            // 
            // btnExitD
            // 
            this.btnExitD.BackColor = System.Drawing.Color.White;
            this.btnExitD.Location = new System.Drawing.Point(539, 440);
            this.btnExitD.Name = "btnExitD";
            this.btnExitD.Size = new System.Drawing.Size(96, 41);
            this.btnExitD.TabIndex = 15;
            this.btnExitD.Text = "Exit";
            this.btnExitD.UseVisualStyleBackColor = false;
            this.btnExitD.Click += new System.EventHandler(this.btnExitD_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(398, 440);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 41);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // MaintainAuthorsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 538);
            this.Controls.Add(this.tabControl1);
            this.Name = "MaintainAuthorsFrm";
            this.Text = "Maintain Authors Form";
            this.Load += new System.EventHandler(this.MaintainAuthorsFrm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAddAuthor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUpdateAuthor)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDeleteAuthor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.DataGridView dgAddAuthor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExitU;
        private System.Windows.Forms.Button btnClearU;
        private System.Windows.Forms.Button btnExitD;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtContactU;
        private System.Windows.Forms.TextBox txtLNameU;
        private System.Windows.Forms.TextBox txtFNameU;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAuthorID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgUpdateAuthor;
        private System.Windows.Forms.ComboBox cbUpdateAuthor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgDeleteAuthor;
        private System.Windows.Forms.ComboBox cbDeleteAuthor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.Label lblDelete;
    }
}

