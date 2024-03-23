namespace WinFormsProject
{
    partial class fAdmin
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
            tbAdmin = new TabControl();
            tpBill = new TabPage();
            txtPageBill = new TextBox();
            btnLastBillPage = new Button();
            btnPreviousBillPage = new Button();
            btnNextBillPage = new Button();
            btnFirstBillPage = new Button();
            panel2 = new Panel();
            btnViewBill = new Button();
            dtpkToDate = new DateTimePicker();
            dtpkFromDate = new DateTimePicker();
            panel1 = new Panel();
            dtgvBill = new DataGridView();
            tpFood = new TabPage();
            panel6 = new Panel();
            panel10 = new Panel();
            nmFoodPrice = new NumericUpDown();
            label4 = new Label();
            panel9 = new Panel();
            cbFoodCategory = new ComboBox();
            label3 = new Label();
            panel8 = new Panel();
            txtFoodName = new TextBox();
            label2 = new Label();
            panel7 = new Panel();
            txtFoodID = new TextBox();
            label1 = new Label();
            panel5 = new Panel();
            txtSearchFoodName = new TextBox();
            btnSearchFood = new Button();
            panel4 = new Panel();
            btnDeleteFood = new Button();
            btnEditFood = new Button();
            btnAddFood = new Button();
            btnShowFood = new Button();
            panel3 = new Panel();
            dtgvFood = new DataGridView();
            tpFoodCategory = new TabPage();
            panel14 = new Panel();
            panel17 = new Panel();
            txtCategoryName = new TextBox();
            label7 = new Label();
            panel18 = new Panel();
            txtCategoryID = new TextBox();
            label8 = new Label();
            panel12 = new Panel();
            dtgvCategory = new DataGridView();
            panel11 = new Panel();
            btnDeleteCategory = new Button();
            btnEditCategory = new Button();
            btnAddCategory = new Button();
            btnShowCategory = new Button();
            tpTable = new TabPage();
            panel16 = new Panel();
            panel21 = new Panel();
            cbTableStatus = new ComboBox();
            label9 = new Label();
            panel19 = new Panel();
            txtTableName = new TextBox();
            label5 = new Label();
            panel20 = new Panel();
            txtTableID = new TextBox();
            label6 = new Label();
            panel15 = new Panel();
            dtgvTable = new DataGridView();
            panel13 = new Panel();
            btnDeleteTable = new Button();
            btnEditTable = new Button();
            btnAddTable = new Button();
            btnShowTable = new Button();
            tpAccount = new TabPage();
            panel24 = new Panel();
            btnResetPassword = new Button();
            panel25 = new Panel();
            nmAccountRole = new NumericUpDown();
            label10 = new Label();
            panel26 = new Panel();
            txtDisplayName = new TextBox();
            label11 = new Label();
            panel27 = new Panel();
            txtUsername = new TextBox();
            label12 = new Label();
            panel23 = new Panel();
            dtgvAccount = new DataGridView();
            panel22 = new Panel();
            btnDeleteAccount = new Button();
            btnEditAccount = new Button();
            btnAddAccount = new Button();
            btnShowAccount = new Button();
            tbAdmin.SuspendLayout();
            tpBill.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvBill).BeginInit();
            tpFood.SuspendLayout();
            panel6.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodPrice).BeginInit();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvFood).BeginInit();
            tpFoodCategory.SuspendLayout();
            panel14.SuspendLayout();
            panel17.SuspendLayout();
            panel18.SuspendLayout();
            panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvCategory).BeginInit();
            panel11.SuspendLayout();
            tpTable.SuspendLayout();
            panel16.SuspendLayout();
            panel21.SuspendLayout();
            panel19.SuspendLayout();
            panel20.SuspendLayout();
            panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvTable).BeginInit();
            panel13.SuspendLayout();
            tpAccount.SuspendLayout();
            panel24.SuspendLayout();
            panel25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmAccountRole).BeginInit();
            panel26.SuspendLayout();
            panel27.SuspendLayout();
            panel23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).BeginInit();
            panel22.SuspendLayout();
            SuspendLayout();
            // 
            // tbAdmin
            // 
            tbAdmin.Controls.Add(tpBill);
            tbAdmin.Controls.Add(tpFood);
            tbAdmin.Controls.Add(tpFoodCategory);
            tbAdmin.Controls.Add(tpTable);
            tbAdmin.Controls.Add(tpAccount);
            tbAdmin.Location = new Point(12, 12);
            tbAdmin.Name = "tbAdmin";
            tbAdmin.SelectedIndex = 0;
            tbAdmin.Size = new Size(851, 578);
            tbAdmin.TabIndex = 0;
            // 
            // tpBill
            // 
            tpBill.Controls.Add(txtPageBill);
            tpBill.Controls.Add(btnLastBillPage);
            tpBill.Controls.Add(btnPreviousBillPage);
            tpBill.Controls.Add(btnNextBillPage);
            tpBill.Controls.Add(btnFirstBillPage);
            tpBill.Controls.Add(panel2);
            tpBill.Controls.Add(panel1);
            tpBill.Location = new Point(4, 34);
            tpBill.Name = "tpBill";
            tpBill.Padding = new Padding(3);
            tpBill.Size = new Size(843, 540);
            tpBill.TabIndex = 4;
            tpBill.Text = "Doanh thu";
            tpBill.UseVisualStyleBackColor = true;
            // 
            // txtPageBill
            // 
            txtPageBill.Location = new Point(370, 502);
            txtPageBill.Name = "txtPageBill";
            txtPageBill.ReadOnly = true;
            txtPageBill.Size = new Size(113, 31);
            txtPageBill.TabIndex = 6;
            txtPageBill.Text = "1";
            txtPageBill.TextAlign = HorizontalAlignment.Center;
            txtPageBill.TextChanged += txtPageBill_TextChanged;
            // 
            // btnLastBillPage
            // 
            btnLastBillPage.Location = new Point(722, 500);
            btnLastBillPage.Name = "btnLastBillPage";
            btnLastBillPage.Size = new Size(112, 34);
            btnLastBillPage.TabIndex = 5;
            btnLastBillPage.Text = "Last";
            btnLastBillPage.UseVisualStyleBackColor = true;
            btnLastBillPage.Click += btnLastBillPage_Click;
            // 
            // btnPreviousBillPage
            // 
            btnPreviousBillPage.Location = new Point(124, 500);
            btnPreviousBillPage.Name = "btnPreviousBillPage";
            btnPreviousBillPage.Size = new Size(112, 34);
            btnPreviousBillPage.TabIndex = 4;
            btnPreviousBillPage.Text = "Previous";
            btnPreviousBillPage.UseVisualStyleBackColor = true;
            btnPreviousBillPage.Click += btnPreviousBillPage_Click;
            // 
            // btnNextBillPage
            // 
            btnNextBillPage.Location = new Point(604, 500);
            btnNextBillPage.Name = "btnNextBillPage";
            btnNextBillPage.Size = new Size(112, 34);
            btnNextBillPage.TabIndex = 3;
            btnNextBillPage.Text = "Next";
            btnNextBillPage.UseVisualStyleBackColor = true;
            btnNextBillPage.Click += btnNextBillPage_Click;
            // 
            // btnFirstBillPage
            // 
            btnFirstBillPage.Location = new Point(6, 500);
            btnFirstBillPage.Name = "btnFirstBillPage";
            btnFirstBillPage.Size = new Size(112, 34);
            btnFirstBillPage.TabIndex = 2;
            btnFirstBillPage.Text = "First";
            btnFirstBillPage.UseVisualStyleBackColor = true;
            btnFirstBillPage.Click += btnFirstBillPage_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnViewBill);
            panel2.Controls.Add(dtpkToDate);
            panel2.Controls.Add(dtpkFromDate);
            panel2.Location = new Point(6, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(831, 36);
            panel2.TabIndex = 1;
            // 
            // btnViewBill
            // 
            btnViewBill.Location = new Point(364, 2);
            btnViewBill.Name = "btnViewBill";
            btnViewBill.Size = new Size(112, 34);
            btnViewBill.TabIndex = 2;
            btnViewBill.Text = "Thống kê";
            btnViewBill.UseVisualStyleBackColor = true;
            btnViewBill.Click += btnViewBill_Click;
            // 
            // dtpkToDate
            // 
            dtpkToDate.Location = new Point(528, 3);
            dtpkToDate.Name = "dtpkToDate";
            dtpkToDate.Size = new Size(300, 31);
            dtpkToDate.TabIndex = 1;
            // 
            // dtpkFromDate
            // 
            dtpkFromDate.Location = new Point(3, 3);
            dtpkFromDate.Name = "dtpkFromDate";
            dtpkFromDate.Size = new Size(300, 31);
            dtpkFromDate.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(dtgvBill);
            panel1.Location = new Point(6, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(831, 448);
            panel1.TabIndex = 0;
            // 
            // dtgvBill
            // 
            dtgvBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvBill.Location = new Point(3, 3);
            dtgvBill.Name = "dtgvBill";
            dtgvBill.RowHeadersWidth = 62;
            dtgvBill.RowTemplate.Height = 33;
            dtgvBill.Size = new Size(825, 442);
            dtgvBill.TabIndex = 0;
            // 
            // tpFood
            // 
            tpFood.Controls.Add(panel6);
            tpFood.Controls.Add(panel5);
            tpFood.Controls.Add(panel4);
            tpFood.Controls.Add(panel3);
            tpFood.Location = new Point(4, 34);
            tpFood.Name = "tpFood";
            tpFood.Padding = new Padding(3);
            tpFood.Size = new Size(843, 540);
            tpFood.TabIndex = 1;
            tpFood.Text = "Thức ăn";
            tpFood.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(panel10);
            panel6.Controls.Add(panel9);
            panel6.Controls.Add(panel8);
            panel6.Controls.Add(panel7);
            panel6.Location = new Point(515, 68);
            panel6.Name = "panel6";
            panel6.Size = new Size(322, 410);
            panel6.TabIndex = 3;
            // 
            // panel10
            // 
            panel10.Controls.Add(nmFoodPrice);
            panel10.Controls.Add(label4);
            panel10.Location = new Point(3, 186);
            panel10.Name = "panel10";
            panel10.Size = new Size(316, 55);
            panel10.TabIndex = 4;
            // 
            // nmFoodPrice
            // 
            nmFoodPrice.Location = new Point(131, 12);
            nmFoodPrice.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            nmFoodPrice.Name = "nmFoodPrice";
            nmFoodPrice.Size = new Size(180, 31);
            nmFoodPrice.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 11);
            label4.Name = "label4";
            label4.Size = new Size(59, 29);
            label4.TabIndex = 0;
            label4.Text = "Giá:";
            // 
            // panel9
            // 
            panel9.Controls.Add(cbFoodCategory);
            panel9.Controls.Add(label3);
            panel9.Location = new Point(3, 125);
            panel9.Name = "panel9";
            panel9.Size = new Size(316, 55);
            panel9.TabIndex = 3;
            // 
            // cbFoodCategory
            // 
            cbFoodCategory.FormattingEnabled = true;
            cbFoodCategory.Location = new Point(131, 11);
            cbFoodCategory.Name = "cbFoodCategory";
            cbFoodCategory.Size = new Size(182, 33);
            cbFoodCategory.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 11);
            label3.Name = "label3";
            label3.Size = new Size(136, 29);
            label3.TabIndex = 0;
            label3.Text = "Danh mục:";
            // 
            // panel8
            // 
            panel8.Controls.Add(txtFoodName);
            panel8.Controls.Add(label2);
            panel8.Location = new Point(3, 64);
            panel8.Name = "panel8";
            panel8.Size = new Size(316, 55);
            panel8.TabIndex = 2;
            // 
            // txtFoodName
            // 
            txtFoodName.Location = new Point(130, 10);
            txtFoodName.Name = "txtFoodName";
            txtFoodName.Size = new Size(183, 31);
            txtFoodName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 10);
            label2.Name = "label2";
            label2.Size = new Size(121, 29);
            label2.TabIndex = 0;
            label2.Text = "Tên món:";
            // 
            // panel7
            // 
            panel7.Controls.Add(txtFoodID);
            panel7.Controls.Add(label1);
            panel7.Location = new Point(3, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(316, 55);
            panel7.TabIndex = 1;
            // 
            // txtFoodID
            // 
            txtFoodID.Location = new Point(130, 10);
            txtFoodID.Name = "txtFoodID";
            txtFoodID.ReadOnly = true;
            txtFoodID.Size = new Size(183, 31);
            txtFoodID.TabIndex = 1;
            txtFoodID.TextChanged += txtFoodID_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(44, 29);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // panel5
            // 
            panel5.Controls.Add(txtSearchFoodName);
            panel5.Controls.Add(btnSearchFood);
            panel5.Location = new Point(515, 6);
            panel5.Name = "panel5";
            panel5.Size = new Size(322, 53);
            panel5.TabIndex = 2;
            // 
            // txtSearchFoodName
            // 
            txtSearchFoodName.Location = new Point(3, 11);
            txtSearchFoodName.Name = "txtSearchFoodName";
            txtSearchFoodName.Size = new Size(198, 31);
            txtSearchFoodName.TabIndex = 5;
            // 
            // btnSearchFood
            // 
            btnSearchFood.Location = new Point(207, 3);
            btnSearchFood.Name = "btnSearchFood";
            btnSearchFood.Size = new Size(112, 47);
            btnSearchFood.TabIndex = 4;
            btnSearchFood.Text = "Tìm kiếm";
            btnSearchFood.UseVisualStyleBackColor = true;
            btnSearchFood.Click += btnSearchFood_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnDeleteFood);
            panel4.Controls.Add(btnEditFood);
            panel4.Controls.Add(btnAddFood);
            panel4.Controls.Add(btnShowFood);
            panel4.Location = new Point(6, 6);
            panel4.Name = "panel4";
            panel4.Size = new Size(503, 53);
            panel4.TabIndex = 1;
            // 
            // btnDeleteFood
            // 
            btnDeleteFood.Location = new Point(388, 3);
            btnDeleteFood.Name = "btnDeleteFood";
            btnDeleteFood.Size = new Size(112, 47);
            btnDeleteFood.TabIndex = 3;
            btnDeleteFood.Text = "Xóa";
            btnDeleteFood.UseVisualStyleBackColor = true;
            btnDeleteFood.Click += btnDeleteFood_Click;
            // 
            // btnEditFood
            // 
            btnEditFood.Location = new Point(257, 3);
            btnEditFood.Name = "btnEditFood";
            btnEditFood.Size = new Size(112, 47);
            btnEditFood.TabIndex = 2;
            btnEditFood.Text = "Sửa";
            btnEditFood.UseVisualStyleBackColor = true;
            btnEditFood.Click += btnEditFood_Click;
            // 
            // btnAddFood
            // 
            btnAddFood.Location = new Point(130, 3);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(112, 47);
            btnAddFood.TabIndex = 1;
            btnAddFood.Text = "Thêm";
            btnAddFood.UseVisualStyleBackColor = true;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // btnShowFood
            // 
            btnShowFood.Location = new Point(3, 3);
            btnShowFood.Name = "btnShowFood";
            btnShowFood.Size = new Size(112, 47);
            btnShowFood.TabIndex = 0;
            btnShowFood.Text = "Xem";
            btnShowFood.UseVisualStyleBackColor = true;
            btnShowFood.Click += btnShowFood_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(dtgvFood);
            panel3.Location = new Point(6, 68);
            panel3.Name = "panel3";
            panel3.Size = new Size(504, 410);
            panel3.TabIndex = 0;
            // 
            // dtgvFood
            // 
            dtgvFood.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvFood.Location = new Point(3, 3);
            dtgvFood.Name = "dtgvFood";
            dtgvFood.RowHeadersWidth = 62;
            dtgvFood.RowTemplate.Height = 33;
            dtgvFood.Size = new Size(497, 404);
            dtgvFood.TabIndex = 0;
            // 
            // tpFoodCategory
            // 
            tpFoodCategory.Controls.Add(panel14);
            tpFoodCategory.Controls.Add(panel12);
            tpFoodCategory.Controls.Add(panel11);
            tpFoodCategory.Location = new Point(4, 34);
            tpFoodCategory.Name = "tpFoodCategory";
            tpFoodCategory.Padding = new Padding(3);
            tpFoodCategory.Size = new Size(843, 540);
            tpFoodCategory.TabIndex = 2;
            tpFoodCategory.Text = "Danh mục";
            tpFoodCategory.UseVisualStyleBackColor = true;
            // 
            // panel14
            // 
            panel14.Controls.Add(panel17);
            panel14.Controls.Add(panel18);
            panel14.Location = new Point(516, 65);
            panel14.Name = "panel14";
            panel14.Size = new Size(322, 410);
            panel14.TabIndex = 5;
            // 
            // panel17
            // 
            panel17.Controls.Add(txtCategoryName);
            panel17.Controls.Add(label7);
            panel17.Location = new Point(3, 64);
            panel17.Name = "panel17";
            panel17.Size = new Size(316, 55);
            panel17.TabIndex = 2;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(182, 10);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(131, 31);
            txtCategoryName.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(3, 10);
            label7.Name = "label7";
            label7.Size = new Size(184, 29);
            label7.TabIndex = 0;
            label7.Text = "Tên danh mục:";
            // 
            // panel18
            // 
            panel18.Controls.Add(txtCategoryID);
            panel18.Controls.Add(label8);
            panel18.Location = new Point(3, 3);
            panel18.Name = "panel18";
            panel18.Size = new Size(316, 55);
            panel18.TabIndex = 1;
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new Point(182, 10);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.ReadOnly = true;
            txtCategoryID.Size = new Size(131, 31);
            txtCategoryID.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(3, 10);
            label8.Name = "label8";
            label8.Size = new Size(44, 29);
            label8.TabIndex = 0;
            label8.Text = "ID:";
            // 
            // panel12
            // 
            panel12.Controls.Add(dtgvCategory);
            panel12.Location = new Point(9, 65);
            panel12.Name = "panel12";
            panel12.Size = new Size(504, 410);
            panel12.TabIndex = 3;
            // 
            // dtgvCategory
            // 
            dtgvCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCategory.Location = new Point(3, 3);
            dtgvCategory.Name = "dtgvCategory";
            dtgvCategory.RowHeadersWidth = 62;
            dtgvCategory.RowTemplate.Height = 33;
            dtgvCategory.Size = new Size(498, 407);
            dtgvCategory.TabIndex = 0;
            // 
            // panel11
            // 
            panel11.Controls.Add(btnDeleteCategory);
            panel11.Controls.Add(btnEditCategory);
            panel11.Controls.Add(btnAddCategory);
            panel11.Controls.Add(btnShowCategory);
            panel11.Location = new Point(6, 6);
            panel11.Name = "panel11";
            panel11.Size = new Size(503, 53);
            panel11.TabIndex = 2;
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.Location = new Point(388, 3);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(112, 47);
            btnDeleteCategory.TabIndex = 3;
            btnDeleteCategory.Text = "Xóa";
            btnDeleteCategory.UseVisualStyleBackColor = true;
            btnDeleteCategory.Click += btnDeleteCategory_Click;
            // 
            // btnEditCategory
            // 
            btnEditCategory.Location = new Point(257, 3);
            btnEditCategory.Name = "btnEditCategory";
            btnEditCategory.Size = new Size(112, 47);
            btnEditCategory.TabIndex = 2;
            btnEditCategory.Text = "Sửa";
            btnEditCategory.UseVisualStyleBackColor = true;
            btnEditCategory.Click += btnEditCategory_Click;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(130, 3);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(112, 47);
            btnAddCategory.TabIndex = 1;
            btnAddCategory.Text = "Thêm";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // btnShowCategory
            // 
            btnShowCategory.Location = new Point(3, 3);
            btnShowCategory.Name = "btnShowCategory";
            btnShowCategory.Size = new Size(112, 47);
            btnShowCategory.TabIndex = 0;
            btnShowCategory.Text = "Xem";
            btnShowCategory.UseVisualStyleBackColor = true;
            btnShowCategory.Click += btnShowCategory_Click;
            // 
            // tpTable
            // 
            tpTable.Controls.Add(panel16);
            tpTable.Controls.Add(panel15);
            tpTable.Controls.Add(panel13);
            tpTable.Location = new Point(4, 34);
            tpTable.Name = "tpTable";
            tpTable.Padding = new Padding(3);
            tpTable.Size = new Size(843, 540);
            tpTable.TabIndex = 3;
            tpTable.Text = "Bàn ăn";
            tpTable.UseVisualStyleBackColor = true;
            // 
            // panel16
            // 
            panel16.Controls.Add(panel21);
            panel16.Controls.Add(panel19);
            panel16.Controls.Add(panel20);
            panel16.Location = new Point(516, 68);
            panel16.Name = "panel16";
            panel16.Size = new Size(322, 410);
            panel16.TabIndex = 6;
            // 
            // panel21
            // 
            panel21.Controls.Add(cbTableStatus);
            panel21.Controls.Add(label9);
            panel21.Location = new Point(3, 125);
            panel21.Name = "panel21";
            panel21.Size = new Size(316, 55);
            panel21.TabIndex = 3;
            // 
            // cbTableStatus
            // 
            cbTableStatus.FormattingEnabled = true;
            cbTableStatus.Location = new Point(182, 10);
            cbTableStatus.Name = "cbTableStatus";
            cbTableStatus.Size = new Size(131, 33);
            cbTableStatus.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(3, 10);
            label9.Name = "label9";
            label9.Size = new Size(136, 29);
            label9.TabIndex = 0;
            label9.Text = "Trạng thái:";
            // 
            // panel19
            // 
            panel19.Controls.Add(txtTableName);
            panel19.Controls.Add(label5);
            panel19.Location = new Point(3, 64);
            panel19.Name = "panel19";
            panel19.Size = new Size(316, 55);
            panel19.TabIndex = 2;
            // 
            // txtTableName
            // 
            txtTableName.Location = new Point(182, 10);
            txtTableName.Name = "txtTableName";
            txtTableName.Size = new Size(131, 31);
            txtTableName.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(3, 10);
            label5.Name = "label5";
            label5.Size = new Size(113, 29);
            label5.TabIndex = 0;
            label5.Text = "Tên bàn:";
            // 
            // panel20
            // 
            panel20.Controls.Add(txtTableID);
            panel20.Controls.Add(label6);
            panel20.Location = new Point(3, 3);
            panel20.Name = "panel20";
            panel20.Size = new Size(316, 55);
            panel20.TabIndex = 1;
            // 
            // txtTableID
            // 
            txtTableID.Location = new Point(182, 10);
            txtTableID.Name = "txtTableID";
            txtTableID.ReadOnly = true;
            txtTableID.Size = new Size(131, 31);
            txtTableID.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(3, 10);
            label6.Name = "label6";
            label6.Size = new Size(44, 29);
            label6.TabIndex = 0;
            label6.Text = "ID:";
            // 
            // panel15
            // 
            panel15.Controls.Add(dtgvTable);
            panel15.Location = new Point(6, 68);
            panel15.Name = "panel15";
            panel15.Size = new Size(504, 410);
            panel15.TabIndex = 4;
            // 
            // dtgvTable
            // 
            dtgvTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvTable.Location = new Point(3, 3);
            dtgvTable.Name = "dtgvTable";
            dtgvTable.RowHeadersWidth = 62;
            dtgvTable.RowTemplate.Height = 33;
            dtgvTable.Size = new Size(498, 407);
            dtgvTable.TabIndex = 0;
            // 
            // panel13
            // 
            panel13.Controls.Add(btnDeleteTable);
            panel13.Controls.Add(btnEditTable);
            panel13.Controls.Add(btnAddTable);
            panel13.Controls.Add(btnShowTable);
            panel13.Location = new Point(6, 6);
            panel13.Name = "panel13";
            panel13.Size = new Size(503, 53);
            panel13.TabIndex = 3;
            // 
            // btnDeleteTable
            // 
            btnDeleteTable.Location = new Point(388, 3);
            btnDeleteTable.Name = "btnDeleteTable";
            btnDeleteTable.Size = new Size(112, 47);
            btnDeleteTable.TabIndex = 3;
            btnDeleteTable.Text = "Xóa";
            btnDeleteTable.UseVisualStyleBackColor = true;
            btnDeleteTable.Click += btnDeleteTable_Click;
            // 
            // btnEditTable
            // 
            btnEditTable.Location = new Point(257, 3);
            btnEditTable.Name = "btnEditTable";
            btnEditTable.Size = new Size(112, 47);
            btnEditTable.TabIndex = 2;
            btnEditTable.Text = "Sửa";
            btnEditTable.UseVisualStyleBackColor = true;
            btnEditTable.Click += btnEditTable_Click;
            // 
            // btnAddTable
            // 
            btnAddTable.Location = new Point(130, 3);
            btnAddTable.Name = "btnAddTable";
            btnAddTable.Size = new Size(112, 47);
            btnAddTable.TabIndex = 1;
            btnAddTable.Text = "Thêm";
            btnAddTable.UseVisualStyleBackColor = true;
            btnAddTable.Click += btnAddTable_Click;
            // 
            // btnShowTable
            // 
            btnShowTable.Location = new Point(3, 3);
            btnShowTable.Name = "btnShowTable";
            btnShowTable.Size = new Size(112, 47);
            btnShowTable.TabIndex = 0;
            btnShowTable.Text = "Xem";
            btnShowTable.UseVisualStyleBackColor = true;
            btnShowTable.Click += btnShowTable_Click;
            // 
            // tpAccount
            // 
            tpAccount.Controls.Add(panel24);
            tpAccount.Controls.Add(panel23);
            tpAccount.Controls.Add(panel22);
            tpAccount.Location = new Point(4, 34);
            tpAccount.Name = "tpAccount";
            tpAccount.Padding = new Padding(3);
            tpAccount.Size = new Size(843, 540);
            tpAccount.TabIndex = 0;
            tpAccount.Text = "Tài khoản";
            tpAccount.UseVisualStyleBackColor = true;
            // 
            // panel24
            // 
            panel24.Controls.Add(btnResetPassword);
            panel24.Controls.Add(panel25);
            panel24.Controls.Add(panel26);
            panel24.Controls.Add(panel27);
            panel24.Location = new Point(516, 65);
            panel24.Name = "panel24";
            panel24.Size = new Size(322, 410);
            panel24.TabIndex = 7;
            // 
            // btnResetPassword
            // 
            btnResetPassword.Location = new Point(204, 196);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(112, 60);
            btnResetPassword.TabIndex = 4;
            btnResetPassword.Text = "Đổi mật khẩu";
            btnResetPassword.UseVisualStyleBackColor = true;
            btnResetPassword.Click += btnResetPassword_Click;
            // 
            // panel25
            // 
            panel25.Controls.Add(nmAccountRole);
            panel25.Controls.Add(label10);
            panel25.Location = new Point(3, 125);
            panel25.Name = "panel25";
            panel25.Size = new Size(316, 55);
            panel25.TabIndex = 3;
            // 
            // nmAccountRole
            // 
            nmAccountRole.Location = new Point(182, 11);
            nmAccountRole.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            nmAccountRole.Name = "nmAccountRole";
            nmAccountRole.Size = new Size(131, 31);
            nmAccountRole.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(3, 10);
            label10.Name = "label10";
            label10.Size = new Size(94, 29);
            label10.TabIndex = 0;
            label10.Text = "Vai trò:";
            // 
            // panel26
            // 
            panel26.Controls.Add(txtDisplayName);
            panel26.Controls.Add(label11);
            panel26.Location = new Point(3, 64);
            panel26.Name = "panel26";
            panel26.Size = new Size(316, 55);
            panel26.TabIndex = 2;
            // 
            // txtDisplayName
            // 
            txtDisplayName.Location = new Point(182, 10);
            txtDisplayName.Name = "txtDisplayName";
            txtDisplayName.Size = new Size(131, 31);
            txtDisplayName.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(3, 10);
            label11.Name = "label11";
            label11.Size = new Size(157, 29);
            label11.TabIndex = 0;
            label11.Text = "Tên hiển thị:";
            // 
            // panel27
            // 
            panel27.Controls.Add(txtUsername);
            panel27.Controls.Add(label12);
            panel27.Location = new Point(3, 3);
            panel27.Name = "panel27";
            panel27.Size = new Size(316, 55);
            panel27.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(182, 10);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(131, 31);
            txtUsername.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(3, 10);
            label12.Name = "label12";
            label12.Size = new Size(176, 29);
            label12.TabIndex = 0;
            label12.Text = "Tên tài khoản:";
            // 
            // panel23
            // 
            panel23.Controls.Add(dtgvAccount);
            panel23.Location = new Point(6, 62);
            panel23.Name = "panel23";
            panel23.Size = new Size(504, 416);
            panel23.TabIndex = 5;
            // 
            // dtgvAccount
            // 
            dtgvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAccount.Location = new Point(3, 3);
            dtgvAccount.Name = "dtgvAccount";
            dtgvAccount.RowHeadersWidth = 62;
            dtgvAccount.RowTemplate.Height = 33;
            dtgvAccount.Size = new Size(497, 410);
            dtgvAccount.TabIndex = 0;
            // 
            // panel22
            // 
            panel22.Controls.Add(btnDeleteAccount);
            panel22.Controls.Add(btnEditAccount);
            panel22.Controls.Add(btnAddAccount);
            panel22.Controls.Add(btnShowAccount);
            panel22.Location = new Point(3, 3);
            panel22.Name = "panel22";
            panel22.Size = new Size(503, 53);
            panel22.TabIndex = 4;
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.Location = new Point(388, 3);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(112, 47);
            btnDeleteAccount.TabIndex = 3;
            btnDeleteAccount.Text = "Xóa";
            btnDeleteAccount.UseVisualStyleBackColor = true;
            btnDeleteAccount.Click += btnDeleteAccount_Click;
            // 
            // btnEditAccount
            // 
            btnEditAccount.Location = new Point(257, 3);
            btnEditAccount.Name = "btnEditAccount";
            btnEditAccount.Size = new Size(112, 47);
            btnEditAccount.TabIndex = 2;
            btnEditAccount.Text = "Sửa";
            btnEditAccount.UseVisualStyleBackColor = true;
            btnEditAccount.Click += btnEditAccount_Click;
            // 
            // btnAddAccount
            // 
            btnAddAccount.Location = new Point(130, 3);
            btnAddAccount.Name = "btnAddAccount";
            btnAddAccount.Size = new Size(112, 47);
            btnAddAccount.TabIndex = 1;
            btnAddAccount.Text = "Thêm";
            btnAddAccount.UseVisualStyleBackColor = true;
            btnAddAccount.Click += btnAddAccount_Click;
            // 
            // btnShowAccount
            // 
            btnShowAccount.Location = new Point(3, 3);
            btnShowAccount.Name = "btnShowAccount";
            btnShowAccount.Size = new Size(112, 47);
            btnShowAccount.TabIndex = 0;
            btnShowAccount.Text = "Xem";
            btnShowAccount.UseVisualStyleBackColor = true;
            btnShowAccount.Click += btnShowAccount_Click;
            // 
            // fAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 594);
            Controls.Add(tbAdmin);
            Name = "fAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fAdmin";
            tbAdmin.ResumeLayout(false);
            tpBill.ResumeLayout(false);
            tpBill.PerformLayout();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvBill).EndInit();
            tpFood.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodPrice).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvFood).EndInit();
            tpFoodCategory.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel17.ResumeLayout(false);
            panel17.PerformLayout();
            panel18.ResumeLayout(false);
            panel18.PerformLayout();
            panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvCategory).EndInit();
            panel11.ResumeLayout(false);
            tpTable.ResumeLayout(false);
            panel16.ResumeLayout(false);
            panel21.ResumeLayout(false);
            panel21.PerformLayout();
            panel19.ResumeLayout(false);
            panel19.PerformLayout();
            panel20.ResumeLayout(false);
            panel20.PerformLayout();
            panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvTable).EndInit();
            panel13.ResumeLayout(false);
            tpAccount.ResumeLayout(false);
            panel24.ResumeLayout(false);
            panel25.ResumeLayout(false);
            panel25.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmAccountRole).EndInit();
            panel26.ResumeLayout(false);
            panel26.PerformLayout();
            panel27.ResumeLayout(false);
            panel27.PerformLayout();
            panel23.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).EndInit();
            panel22.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbAdmin;
        private TabPage tpAccount;
        private TabPage tpFood;
        private TabPage tpFoodCategory;
        private TabPage tpTable;
        private TabPage tpBill;
        private Panel panel1;
        private Panel panel2;
        private Button btnViewBill;
        private DateTimePicker dtpkToDate;
        private DateTimePicker dtpkFromDate;
        private DataGridView dtgvBill;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Button btnSearchFood;
        private Button btnDeleteFood;
        private Button btnEditFood;
        private Button btnAddFood;
        private Button btnShowFood;
        private DataGridView dtgvFood;
        private TextBox txtSearchFoodName;
        private Panel panel7;
        private TextBox txtFoodID;
        private Label label1;
        private Panel panel8;
        private TextBox txtFoodName;
        private Label label2;
        private Panel panel9;
        private Label label3;
        private Panel panel10;
        private NumericUpDown nmFoodPrice;
        private Label label4;
        private ComboBox cbFoodCategory;
        private Panel panel11;
        private Button btnDeleteCategory;
        private Button btnEditCategory;
        private Button btnAddCategory;
        private Button btnShowCategory;
        private Panel panel14;
        private Panel panel17;
        private TextBox txtCategoryName;
        private Label label7;
        private Panel panel18;
        private TextBox txtCategoryID;
        private Label label8;
        private Panel panel12;
        private DataGridView dtgvCategory;
        private Panel panel15;
        private DataGridView dtgvTable;
        private Panel panel13;
        private Button btnDeleteTable;
        private Button btnEditTable;
        private Button btnAddTable;
        private Button btnShowTable;
        private Panel panel16;
        private Panel panel21;
        private ComboBox cbTableStatus;
        private Label label9;
        private Panel panel19;
        private TextBox txtTableName;
        private Label label5;
        private Panel panel20;
        private TextBox txtTableID;
        private Label label6;
        private Panel panel23;
        private DataGridView dtgvAccount;
        private Panel panel22;
        private Button btnDeleteAccount;
        private Button btnEditAccount;
        private Button btnAddAccount;
        private Button btnShowAccount;
        private Panel panel24;
        private Panel panel25;
        private Label label10;
        private Panel panel26;
        private TextBox txtDisplayName;
        private Label label11;
        private Panel panel27;
        private TextBox txtUsername;
        private Label label12;
        private Button btnResetPassword;
        private NumericUpDown nmAccountRole;
        private TextBox txtPageBill;
        private Button btnLastBillPage;
        private Button btnPreviousBillPage;
        private Button btnNextBillPage;
        private Button btnFirstBillPage;
    }
}