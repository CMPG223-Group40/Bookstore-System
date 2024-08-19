
namespace OrderForBooks
{
    partial class frmPlaceOrderForm
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
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblShip = new System.Windows.Forms.Label();
            this.lblFilterValue = new System.Windows.Forms.Label();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.cmbFilterBy = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.gbxShippingAddress = new System.Windows.Forms.GroupBox();
            this.lstAddress = new System.Windows.Forms.ListBox();
            this.lstSummary = new System.Windows.Forms.ListBox();
            this.btnVerify = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dtgvBooksAvailable = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.gbxShippingAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBooksAvailable)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(9, 9);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(71, 13);
            this.lblCustomerID.TabIndex = 0;
            this.lblCustomerID.Text = "Customer ID :";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(22, 76);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(183, 20);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "BOOKS AVAILABLE :";
            // 
            // lblShip
            // 
            this.lblShip.AutoSize = true;
            this.lblShip.Location = new System.Drawing.Point(9, 29);
            this.lblShip.Name = "lblShip";
            this.lblShip.Size = new System.Drawing.Size(70, 13);
            this.lblShip.TabIndex = 2;
            this.lblShip.Text = "Ship order to:";
            // 
            // lblFilterValue
            // 
            this.lblFilterValue.AutoSize = true;
            this.lblFilterValue.Location = new System.Drawing.Point(492, 38);
            this.lblFilterValue.Name = "lblFilterValue";
            this.lblFilterValue.Size = new System.Drawing.Size(65, 13);
            this.lblFilterValue.TabIndex = 3;
            this.lblFilterValue.Text = "Filter Value :";
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Location = new System.Drawing.Point(492, 8);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(50, 13);
            this.lblFilterBy.TabIndex = 4;
            this.lblFilterBy.Text = "Filter By :";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(87, 19);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 5;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(87, 60);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(100, 20);
            this.txtTotalPrice.TabIndex = 6;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(114, 2);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(242, 20);
            this.txtCustomerID.TabIndex = 7;
            this.txtCustomerID.TextChanged += new System.EventHandler(this.txtCustomerID_TextChanged);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Location = new System.Drawing.Point(572, 33);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(174, 20);
            this.txtFilterValue.TabIndex = 8;
            // 
            // cmbFilterBy
            // 
            this.cmbFilterBy.FormattingEnabled = true;
            this.cmbFilterBy.Items.AddRange(new object[] {
            "Author",
            "Year Published",
            "Title"});
            this.cmbFilterBy.Location = new System.Drawing.Point(572, 6);
            this.cmbFilterBy.Name = "cmbFilterBy";
            this.cmbFilterBy.Size = new System.Drawing.Size(121, 21);
            this.cmbFilterBy.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblQuantity);
            this.groupBox1.Controls.Add(this.lblTotalPrice);
            this.groupBox1.Controls.Add(this.txtTotalPrice);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Location = new System.Drawing.Point(528, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(9, 26);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(52, 13);
            this.lblQuantity.TabIndex = 12;
            this.lblQuantity.Text = "Quantity :";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(9, 63);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(64, 13);
            this.lblTotalPrice.TabIndex = 13;
            this.lblTotalPrice.Text = "Total Price :";
            // 
            // gbxShippingAddress
            // 
            this.gbxShippingAddress.Controls.Add(this.lstAddress);
            this.gbxShippingAddress.Controls.Add(this.lblShip);
            this.gbxShippingAddress.Location = new System.Drawing.Point(528, 182);
            this.gbxShippingAddress.Name = "gbxShippingAddress";
            this.gbxShippingAddress.Size = new System.Drawing.Size(325, 176);
            this.gbxShippingAddress.TabIndex = 0;
            this.gbxShippingAddress.TabStop = false;
            this.gbxShippingAddress.Text = "groupBox2";
            // 
            // lstAddress
            // 
            this.lstAddress.FormattingEnabled = true;
            this.lstAddress.Location = new System.Drawing.Point(12, 57);
            this.lstAddress.Name = "lstAddress";
            this.lstAddress.Size = new System.Drawing.Size(301, 108);
            this.lstAddress.TabIndex = 0;
            // 
            // lstSummary
            // 
            this.lstSummary.FormattingEnabled = true;
            this.lstSummary.Location = new System.Drawing.Point(12, 402);
            this.lstSummary.Name = "lstSummary";
            this.lstSummary.Size = new System.Drawing.Size(830, 95);
            this.lstSummary.TabIndex = 1;
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(12, 33);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(75, 23);
            this.btnVerify.TabIndex = 2;
            this.btnVerify.Text = "Verify ID";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(615, 355);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(195, 41);
            this.btnPlaceOrder.TabIndex = 3;
            this.btnPlaceOrder.Text = "PLACE ORDER";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(752, 31);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // dtgvBooksAvailable
            // 
            this.dtgvBooksAvailable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBooksAvailable.Location = new System.Drawing.Point(12, 96);
            this.dtgvBooksAvailable.Name = "dtgvBooksAvailable";
            this.dtgvBooksAvailable.Size = new System.Drawing.Size(498, 300);
            this.dtgvBooksAvailable.TabIndex = 11;
            this.dtgvBooksAvailable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvBooksAvailable_CellContentClick);
            // 
            // frmPlaceOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 500);
            this.Controls.Add(this.dtgvBooksAvailable);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.gbxShippingAddress);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbFilterBy);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.lstSummary);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.lblFilterBy);
            this.Controls.Add(this.lblFilterValue);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblCustomerID);
            this.Name = "frmPlaceOrderForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxShippingAddress.ResumeLayout(false);
            this.gbxShippingAddress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBooksAvailable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblShip;
        private System.Windows.Forms.Label lblFilterValue;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.ComboBox cmbFilterBy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.GroupBox gbxShippingAddress;
        private System.Windows.Forms.ListBox lstAddress;
        private System.Windows.Forms.ListBox lstSummary;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DataGridView dtgvBooksAvailable;
    }
}

