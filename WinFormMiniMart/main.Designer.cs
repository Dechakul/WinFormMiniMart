namespace WinFormMiniMart
{
    partial class main
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
            menuStrip1 = new MenuStrip();
            mnu_Products = new ToolStripMenuItem();
            mnu_Categories = new ToolStripMenuItem();
            mnu_Employees = new ToolStripMenuItem();
            mnu_logout2 = new ToolStripMenuItem();
            menuStrip2 = new MenuStrip();
            mnu_Login = new ToolStripMenuItem();
            mnu_off = new ToolStripMenuItem();
            menuStrip3 = new MenuStrip();
            mnu_sell = new ToolStripMenuItem();
            ขายสนคาToolStripMenuItem = new ToolStripMenuItem();
            mnu_logout1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            menuStrip2.SuspendLayout();
            menuStrip3.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnu_Products, mnu_Categories, mnu_Employees, mnu_logout2 });
            menuStrip1.Location = new Point(0, 48);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(700, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnu_Products
            // 
            mnu_Products.Name = "mnu_Products";
            mnu_Products.Size = new Size(74, 20);
            mnu_Products.Text = "จัดการสินค้า";
            mnu_Products.Click += mnu_Products_Click;
            // 
            // mnu_Categories
            // 
            mnu_Categories.Name = "mnu_Categories";
            mnu_Categories.Size = new Size(107, 20);
            mnu_Categories.Text = "จัดการประเภทสินค้า";
            mnu_Categories.Click += mnu_Categories_Click;
            // 
            // mnu_Employees
            // 
            mnu_Employees.Name = "mnu_Employees";
            mnu_Employees.Size = new Size(88, 20);
            mnu_Employees.Text = "จัดการพนักงาน";
            mnu_Employees.Click += mnu_Employees_Click;
            // 
            // mnu_logout2
            // 
            mnu_logout2.Name = "mnu_logout2";
            mnu_logout2.Size = new Size(79, 20);
            mnu_logout2.Text = "ออกจากระบบ";
            mnu_logout2.Click += mnu_logout2_Click;
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { mnu_Login, mnu_off });
            menuStrip2.Location = new Point(0, 24);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Padding = new Padding(5, 2, 0, 2);
            menuStrip2.Size = new Size(700, 24);
            menuStrip2.TabIndex = 4;
            menuStrip2.Text = "menuStrip2";
            menuStrip2.ItemClicked += menuStrip2_ItemClicked;
            // 
            // mnu_Login
            // 
            mnu_Login.Name = "mnu_Login";
            mnu_Login.Size = new Size(63, 20);
            mnu_Login.Text = "เข้าสู่ระบบ";
            mnu_Login.Click += mnu_Login_Click;
            // 
            // mnu_off
            // 
            mnu_off.Name = "mnu_off";
            mnu_off.Size = new Size(73, 20);
            mnu_off.Text = "ปิดโปรแกรม";
            mnu_off.Click += mnu_off_Click;
            // 
            // menuStrip3
            // 
            menuStrip3.ImageScalingSize = new Size(20, 20);
            menuStrip3.Items.AddRange(new ToolStripItem[] { mnu_sell, mnu_logout1 });
            menuStrip3.Location = new Point(0, 0);
            menuStrip3.Name = "menuStrip3";
            menuStrip3.Padding = new Padding(5, 2, 0, 2);
            menuStrip3.Size = new Size(700, 24);
            menuStrip3.TabIndex = 5;
            menuStrip3.Text = "menuStrip3";
            // 
            // mnu_sell
            // 
            mnu_sell.DropDownItems.AddRange(new ToolStripItem[] { ขายสนคาToolStripMenuItem });
            mnu_sell.Name = "mnu_sell";
            mnu_sell.Size = new Size(62, 20);
            mnu_sell.Text = "ขายสินค้า";
            mnu_sell.Click += mnu_sell_Click;
            // 
            // ขายสนคาToolStripMenuItem
            // 
            ขายสนคาToolStripMenuItem.Name = "ขายสนคาToolStripMenuItem";
            ขายสนคาToolStripMenuItem.Size = new Size(117, 22);
            ขายสนคาToolStripMenuItem.Text = "ขายสินค้า";
            // 
            // mnu_logout1
            // 
            mnu_logout1.Name = "mnu_logout1";
            mnu_logout1.Size = new Size(79, 20);
            mnu_logout1.Text = "ออกจากระบบ";
            mnu_logout1.Click += mnu_logout1_Click;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            Controls.Add(menuStrip3);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "main";
            Text = "main";
            FormClosing += main_FormClosing;
            Load += main_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            menuStrip3.ResumeLayout(false);
            menuStrip3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private MenuStrip menuStrip3;
        private ToolStripMenuItem mnu_Login;
        private ToolStripMenuItem mnu_off;
        private ToolStripMenuItem mnu_sell;
        private ToolStripMenuItem mnu_logout2;
        private ToolStripMenuItem mnu_logout1;
        private ToolStripMenuItem ขายสนคาToolStripMenuItem;
        private ToolStripMenuItem mnu_Employees;
        private ToolStripMenuItem mnu_Products;
        private ToolStripMenuItem mnu_Categories;
    }
}