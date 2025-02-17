namespace WinFormMiniMart
{
    partial class Form4
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
            label4 = new Label();
            label3 = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            cmbCategoryID = new ComboBox();
            txtProductName = new TextBox();
            txtProductID = new TextBox();
            numUD_UnitPrice = new NumericUpDown();
            cmbDiscontinued = new ComboBox();
            numUD_UnitsInStock = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numUD_UnitPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUD_UnitsInStock).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 144);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 13;
            label4.Text = "ราคา";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 80);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 14;
            label3.Text = "ชื่อสินค้า";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 202);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 16;
            label6.Text = "สถานะจำหน่าย";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(264, 144);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 17;
            label5.Text = "จำนวน";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(264, 18);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 18;
            label2.Text = "ประเภทสินค้า";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 18);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 19;
            label1.Text = "รหัสสินค้า";
            // 
            // button2
            // 
            button2.Location = new Point(53, 286);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(156, 46);
            button2.TabIndex = 11;
            button2.Text = "บันทึก";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(303, 286);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(156, 46);
            button1.TabIndex = 12;
            button1.Text = "ยกเลิก";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cmbCategoryID
            // 
            cmbCategoryID.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategoryID.FormattingEnabled = true;
            cmbCategoryID.Location = new Point(264, 42);
            cmbCategoryID.Margin = new Padding(3, 2, 3, 2);
            cmbCategoryID.Name = "cmbCategoryID";
            cmbCategoryID.Size = new Size(219, 38);
            cmbCategoryID.TabIndex = 10;
            cmbCategoryID.SelectedIndexChanged += cmbCategoryID_SelectedIndexChanged;
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProductName.Location = new Point(24, 97);
            txtProductName.Margin = new Padding(3, 2, 3, 2);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(459, 36);
            txtProductName.TabIndex = 8;
            // 
            // txtProductID
            // 
            txtProductID.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProductID.Location = new Point(24, 42);
            txtProductID.Margin = new Padding(3, 2, 3, 2);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(218, 36);
            txtProductID.TabIndex = 9;
            // 
            // numUD_UnitPrice
            // 
            numUD_UnitPrice.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numUD_UnitPrice.Location = new Point(24, 161);
            numUD_UnitPrice.Margin = new Padding(3, 2, 3, 2);
            numUD_UnitPrice.Name = "numUD_UnitPrice";
            numUD_UnitPrice.Size = new Size(218, 36);
            numUD_UnitPrice.TabIndex = 20;
            // 
            // cmbDiscontinued
            // 
            cmbDiscontinued.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbDiscontinued.FormattingEnabled = true;
            cmbDiscontinued.Items.AddRange(new object[] { "พร้อมจำหน่าย", "เลิกจำหน่าย" });
            cmbDiscontinued.Location = new Point(24, 219);
            cmbDiscontinued.Margin = new Padding(3, 2, 3, 2);
            cmbDiscontinued.Name = "cmbDiscontinued";
            cmbDiscontinued.Size = new Size(218, 38);
            cmbDiscontinued.TabIndex = 10;
            // 
            // numUD_UnitsInStock
            // 
            numUD_UnitsInStock.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numUD_UnitsInStock.Location = new Point(264, 161);
            numUD_UnitsInStock.Margin = new Padding(3, 2, 3, 2);
            numUD_UnitsInStock.Name = "numUD_UnitsInStock";
            numUD_UnitsInStock.Size = new Size(219, 36);
            numUD_UnitsInStock.TabIndex = 20;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 343);
            Controls.Add(numUD_UnitsInStock);
            Controls.Add(numUD_UnitPrice);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cmbDiscontinued);
            Controls.Add(cmbCategoryID);
            Controls.Add(txtProductName);
            Controls.Add(txtProductID);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form4";
            Text = "เพิ่ม/แก้ไขสินค้า";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)numUD_UnitPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUD_UnitsInStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button1;
        private ComboBox cmbCategoryID;
        private TextBox txtProductName;
        private TextBox txtProductID;
        private NumericUpDown numUD_UnitPrice;
        private ComboBox cmbDiscontinued;
        private NumericUpDown numUD_UnitsInStock;
    }
}