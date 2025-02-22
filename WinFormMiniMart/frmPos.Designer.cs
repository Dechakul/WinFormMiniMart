namespace WinFormMiniMart
{
    partial class frmPos
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
            txtEmployeeID = new TextBox();
            txtEmployeeName = new TextBox();
            txtProductID = new TextBox();
            label7 = new Label();
            label6 = new Label();
            lblNetPrice = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            lsvProduct = new ListView();
            txtTotal = new TextBox();
            txtQuantity = new TextBox();
            txtUnitPrice = new TextBox();
            txtProductName = new TextBox();
            btnAdd = new Button();
            btnClear = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Location = new Point(213, 61);
            txtEmployeeID.Margin = new Padding(3, 2, 3, 2);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new Size(110, 23);
            txtEmployeeID.TabIndex = 0;
            txtEmployeeID.KeyDown += txtEmployeeID_KeyDown;
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new Point(426, 63);
            txtEmployeeName.Margin = new Padding(3, 2, 3, 2);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.ReadOnly = true;
            txtEmployeeName.Size = new Size(110, 23);
            txtEmployeeName.TabIndex = 1;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(32, 99);
            txtProductID.Margin = new Padding(3, 2, 3, 2);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(110, 23);
            txtProductID.TabIndex = 2;
            txtProductID.KeyDown += txtProductID_KeyDown;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 300);
            label7.Name = "label7";
            label7.Size = new Size(24, 15);
            label7.TabIndex = 15;
            label7.Text = "รวม";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 246);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 14;
            label6.Text = "จำนวน";
            // 
            // lblNetPrice
            // 
            lblNetPrice.BackColor = Color.FromArgb(192, 255, 192);
            lblNetPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNetPrice.Location = new Point(545, 356);
            lblNetPrice.Name = "lblNetPrice";
            lblNetPrice.Size = new Size(306, 36);
            lblNetPrice.TabIndex = 8;
            lblNetPrice.Text = "0.00";
            lblNetPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 197);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 13;
            label5.Text = "ราคาขาย";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 140);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 12;
            label4.Text = "ชื่อสินค้า";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 81);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 11;
            label3.Text = "รหัสสินค้า";
            // 
            // lsvProduct
            // 
            lsvProduct.Location = new Point(160, 99);
            lsvProduct.Margin = new Padding(3, 2, 3, 2);
            lsvProduct.Name = "lsvProduct";
            lsvProduct.Size = new Size(717, 241);
            lsvProduct.TabIndex = 7;
            lsvProduct.UseCompatibleStateImageBehavior = false;
            lsvProduct.DoubleClick += lsvProduct_DoubleClick;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(32, 317);
            txtTotal.Margin = new Padding(3, 2, 3, 2);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(78, 23);
            txtTotal.TabIndex = 6;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(32, 263);
            txtQuantity.Margin = new Padding(3, 2, 3, 2);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(81, 23);
            txtQuantity.TabIndex = 5;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(32, 214);
            txtUnitPrice.Margin = new Padding(3, 2, 3, 2);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.ReadOnly = true;
            txtUnitPrice.Size = new Size(100, 23);
            txtUnitPrice.TabIndex = 4;
            txtUnitPrice.TextChanged += textBox3_TextChanged;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(32, 158);
            txtProductName.Margin = new Padding(3, 2, 3, 2);
            txtProductName.Name = "txtProductName";
            txtProductName.ReadOnly = true;
            txtProductName.Size = new Size(110, 23);
            txtProductName.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(32, 353);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(101, 39);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "เพิ่ม";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(160, 353);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(101, 39);
            btnClear.TabIndex = 5;
            btnClear.Text = "ล้าง";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.Location = new Point(292, 353);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(101, 39);
            btnSave.TabIndex = 6;
            btnSave.Text = "บันทึก";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(411, 353);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(101, 39);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "ยกเลิกรายการ";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(135, 63);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 9;
            label1.Text = "รหัสพนักงาน";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(349, 63);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 10;
            label2.Text = "ชื่อ-สกุล";
            // 
            // frmPos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 453);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(lblNetPrice);
            Controls.Add(btnCancel);
            Controls.Add(label5);
            Controls.Add(btnSave);
            Controls.Add(label4);
            Controls.Add(btnClear);
            Controls.Add(label3);
            Controls.Add(btnAdd);
            Controls.Add(lsvProduct);
            Controls.Add(txtTotal);
            Controls.Add(txtQuantity);
            Controls.Add(txtEmployeeName);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtEmployeeID);
            Controls.Add(txtProductName);
            Controls.Add(txtProductID);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmPos";
            Text = "frmPos";
            Load += frmPos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmployeeID;
        private TextBox txtEmployeeName;
        private TextBox txtProductID;
        private TextBox txtTotal;
        private TextBox txtQuantity;
        private TextBox txtUnitPrice;
        private TextBox txtProductName;
        private ListView lsvProduct;
        private Button btnAdd;
        private Button btnClear;
        private Button btnSave;
        private Button btnCancel;
        private Label lblNetPrice;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
    }
}