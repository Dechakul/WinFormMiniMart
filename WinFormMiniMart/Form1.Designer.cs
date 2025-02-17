namespace WinFormMiniMart
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
            dgvEmployees = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            txtSearch = new TextBox();
            button3 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            SuspendLayout();
            // 
            // dgvEmployees
            // 
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Location = new Point(12, 89);
            dgvEmployees.Margin = new Padding(3, 2, 3, 2);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.RowHeadersWidth = 51;
            dgvEmployees.Size = new Size(680, 235);
            dgvEmployees.TabIndex = 0;
            dgvEmployees.CellDoubleClick += dgvEmployees_CellDoubleClick;
            dgvEmployees.CellMouseUp += dgvEmployees_CellMouseUp;
            // 
            // button1
            // 
            button1.Location = new Point(619, 30);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(73, 41);
            button1.TabIndex = 1;
            button1.Text = "ล้าง";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(421, 30);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(76, 41);
            button2.TabIndex = 1;
            button2.Text = "เพิ่มข้อมูล";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(12, 30);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(391, 42);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += textBox1_TextChanged;
            // 
            // button3
            // 
            button3.Location = new Point(520, 30);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(77, 41);
            button3.TabIndex = 1;
            button3.Text = "ลบข้อมูล";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(51, 17);
            label1.TabIndex = 3;
            label1.Text = "พนักงาน";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 335);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgvEmployees);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "จัดการพนักงาน";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEmployees;
        private Button button1;
        private Button button2;
        private TextBox txtSearch;
        private Button button3;
        private Label label1;
    }
}