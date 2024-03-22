namespace WinFormsProject
{
    partial class fTableManager
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            adminToolStripMenuItem = new ToolStripMenuItem();
            thôngTinTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            thôngTinCáNhânToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            lsvBill = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            panel3 = new Panel();
            txtTotalPrice = new TextBox();
            cbSwitchTable = new ComboBox();
            btnSwitchTable = new Button();
            nmDisCount = new NumericUpDown();
            button1 = new Button();
            btnCheck = new Button();
            panel4 = new Panel();
            cbFood = new ComboBox();
            cbCategory = new ComboBox();
            nmFoodCount = new NumericUpDown();
            btnAddFood = new Button();
            flpTable = new FlowLayoutPanel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmDisCount).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodCount).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, thôngTinTàiKhoảnToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1212, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(81, 29);
            adminToolStripMenuItem.Text = "Admin";
            adminToolStripMenuItem.Click += adminToolStripMenuItem_Click;
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinCáNhânToolStripMenuItem, đăngXuấtToolStripMenuItem });
            thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            thôngTinTàiKhoảnToolStripMenuItem.Size = new Size(182, 29);
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            thôngTinCáNhânToolStripMenuItem.Size = new Size(256, 34);
            thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            thôngTinCáNhânToolStripMenuItem.Click += thôngTinCáNhânToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(256, 34);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lsvBill);
            panel2.Location = new Point(685, 115);
            panel2.Name = "panel2";
            panel2.Size = new Size(515, 378);
            panel2.TabIndex = 2;
            // 
            // lsvBill
            // 
            lsvBill.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lsvBill.GridLines = true;
            lsvBill.Location = new Point(3, 3);
            lsvBill.Name = "lsvBill";
            lsvBill.Size = new Size(509, 375);
            lsvBill.TabIndex = 0;
            lsvBill.UseCompatibleStateImageBehavior = false;
            lsvBill.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên món";
            columnHeader1.Width = 190;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Số lượng";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Đơn giá";
            columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Thành tiền";
            columnHeader4.Width = 120;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtTotalPrice);
            panel3.Controls.Add(cbSwitchTable);
            panel3.Controls.Add(btnSwitchTable);
            panel3.Controls.Add(nmDisCount);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(btnCheck);
            panel3.Location = new Point(685, 499);
            panel3.Name = "panel3";
            panel3.Size = new Size(515, 73);
            panel3.TabIndex = 3;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtTotalPrice.ForeColor = Color.Red;
            txtTotalPrice.Location = new Point(242, 21);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.ReadOnly = true;
            txtTotalPrice.Size = new Size(150, 35);
            txtTotalPrice.TabIndex = 12;
            txtTotalPrice.Text = "0";
            txtTotalPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // cbSwitchTable
            // 
            cbSwitchTable.FormattingEnabled = true;
            cbSwitchTable.Location = new Point(0, 41);
            cbSwitchTable.Name = "cbSwitchTable";
            cbSwitchTable.Size = new Size(119, 33);
            cbSwitchTable.TabIndex = 9;
            // 
            // btnSwitchTable
            // 
            btnSwitchTable.Location = new Point(0, 1);
            btnSwitchTable.Name = "btnSwitchTable";
            btnSwitchTable.Size = new Size(119, 38);
            btnSwitchTable.TabIndex = 11;
            btnSwitchTable.Text = "Chuyển bàn";
            btnSwitchTable.UseVisualStyleBackColor = true;
            btnSwitchTable.Click += btnSwitchTable_Click;
            // 
            // nmDisCount
            // 
            nmDisCount.Location = new Point(125, 42);
            nmDisCount.Name = "nmDisCount";
            nmDisCount.Size = new Size(111, 31);
            nmDisCount.TabIndex = 9;
            nmDisCount.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.Location = new Point(125, 1);
            button1.Name = "button1";
            button1.Size = new Size(111, 38);
            button1.TabIndex = 10;
            button1.Text = "Giảm giá";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(401, 3);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(111, 67);
            btnCheck.TabIndex = 9;
            btnCheck.Text = "Thanh toán";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(cbFood);
            panel4.Controls.Add(cbCategory);
            panel4.Controls.Add(nmFoodCount);
            panel4.Controls.Add(btnAddFood);
            panel4.Location = new Point(685, 36);
            panel4.Name = "panel4";
            panel4.Size = new Size(515, 73);
            panel4.TabIndex = 4;
            // 
            // cbFood
            // 
            cbFood.FormattingEnabled = true;
            cbFood.Location = new Point(3, 37);
            cbFood.Name = "cbFood";
            cbFood.Size = new Size(329, 33);
            cbFood.TabIndex = 10;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(3, 3);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(329, 33);
            cbCategory.TabIndex = 9;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            // 
            // nmFoodCount
            // 
            nmFoodCount.Location = new Point(460, 22);
            nmFoodCount.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nmFoodCount.Name = "nmFoodCount";
            nmFoodCount.Size = new Size(52, 31);
            nmFoodCount.TabIndex = 8;
            nmFoodCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddFood
            // 
            btnAddFood.Location = new Point(338, 3);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(107, 67);
            btnAddFood.TabIndex = 7;
            btnAddFood.Text = "Thêm món";
            btnAddFood.UseVisualStyleBackColor = true;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // flpTable
            // 
            flpTable.AutoScroll = true;
            flpTable.Location = new Point(12, 39);
            flpTable.Name = "flpTable";
            flpTable.Size = new Size(667, 533);
            flpTable.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // fTableManager
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1212, 584);
            Controls.Add(flpTable);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "fTableManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phần mềm quản lý nhà hàng";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmDisCount).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nmFoodCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private NumericUpDown nmFoodCount;
        private Button btnAddFood;
        private FlowLayoutPanel flpTable;
        private ComboBox cbSwitchTable;
        private Button btnSwitchTable;
        private NumericUpDown nmDisCount;
        private Button button1;
        private Button btnCheck;
        private ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private TextBox txtTotalPrice;
        private ContextMenuStrip contextMenuStrip1;
        public ListView lsvBill;
        private ComboBox cbFood;
        private ComboBox cbCategory;
    }
}