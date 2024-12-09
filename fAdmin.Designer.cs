namespace Qlyquancafe
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
            this.tabAccount = new System.Windows.Forms.TabPage();
            this.panel20 = new System.Windows.Forms.Panel();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.btnShowAccount = new System.Windows.Forms.Button();
            this.dtgvAccount = new System.Windows.Forms.DataGridView();
            this.panel21 = new System.Windows.Forms.Panel();
            this.panel25 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.panel24 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txbDisplayName = new System.Windows.Forms.TextBox();
            this.panel23 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnReset = new System.Windows.Forms.Button();
            this.tabFood = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvFood = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtnamelogin = new System.Windows.Forms.Label();
            this.txbFoodId = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txbFoodName = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFoodCategory = new System.Windows.Forms.ComboBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.Gia = new System.Windows.Forms.Label();
            this.nmFood = new System.Windows.Forms.NumericUpDown();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnaddFood = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnshowfood = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txbsearchFoodName = new System.Windows.Forms.TextBox();
            this.tabBill = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvBill = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickertoday = new System.Windows.Forms.DateTimePicker();
            this.btnViewbill = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAccount.SuspendLayout();
            this.panel20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).BeginInit();
            this.panel21.SuspendLayout();
            this.panel25.SuspendLayout();
            this.panel24.SuspendLayout();
            this.panel23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabFood.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFood)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tabBill.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAccount
            // 
            this.tabAccount.Controls.Add(this.panel21);
            this.tabAccount.Controls.Add(this.dtgvAccount);
            this.tabAccount.Controls.Add(this.panel20);
            this.tabAccount.Location = new System.Drawing.Point(4, 25);
            this.tabAccount.Name = "tabAccount";
            this.tabAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccount.Size = new System.Drawing.Size(781, 402);
            this.tabAccount.TabIndex = 4;
            this.tabAccount.Text = "Tài khoản";
            this.tabAccount.UseVisualStyleBackColor = true;
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.btnShowAccount);
            this.panel20.Controls.Add(this.btnEditAccount);
            this.panel20.Controls.Add(this.btnDeleteAccount);
            this.panel20.Controls.Add(this.btnAddAccount);
            this.panel20.Location = new System.Drawing.Point(6, 6);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(376, 58);
            this.panel20.TabIndex = 4;
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.ForeColor = System.Drawing.Color.Tomato;
            this.btnAddAccount.Location = new System.Drawing.Point(3, 0);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(86, 58);
            this.btnAddAccount.TabIndex = 0;
            this.btnAddAccount.Text = "Thêm";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.ForeColor = System.Drawing.Color.Tomato;
            this.btnDeleteAccount.Location = new System.Drawing.Point(95, 0);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(89, 58);
            this.btnDeleteAccount.TabIndex = 1;
            this.btnDeleteAccount.Text = "Xóa";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.ForeColor = System.Drawing.Color.Tomato;
            this.btnEditAccount.Location = new System.Drawing.Point(190, 0);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(83, 58);
            this.btnEditAccount.TabIndex = 2;
            this.btnEditAccount.Text = "Sửa";
            this.btnEditAccount.UseVisualStyleBackColor = true;
            this.btnEditAccount.Click += new System.EventHandler(this.btnEditAccount_Click);
            // 
            // btnShowAccount
            // 
            this.btnShowAccount.ForeColor = System.Drawing.Color.Tomato;
            this.btnShowAccount.Location = new System.Drawing.Point(279, 0);
            this.btnShowAccount.Name = "btnShowAccount";
            this.btnShowAccount.Size = new System.Drawing.Size(97, 58);
            this.btnShowAccount.TabIndex = 3;
            this.btnShowAccount.Text = "Xem";
            this.btnShowAccount.UseVisualStyleBackColor = true;
            this.btnShowAccount.Click += new System.EventHandler(this.btnShowAccount_Click);
            // 
            // dtgvAccount
            // 
            this.dtgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAccount.Location = new System.Drawing.Point(6, 67);
            this.dtgvAccount.Name = "dtgvAccount";
            this.dtgvAccount.RowHeadersWidth = 51;
            this.dtgvAccount.RowTemplate.Height = 24;
            this.dtgvAccount.Size = new System.Drawing.Size(376, 332);
            this.dtgvAccount.TabIndex = 6;
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.btnReset);
            this.panel21.Controls.Add(this.panel23);
            this.panel21.Controls.Add(this.panel24);
            this.panel21.Controls.Add(this.panel25);
            this.panel21.Location = new System.Drawing.Point(385, 67);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(393, 332);
            this.panel21.TabIndex = 7;
            // 
            // panel25
            // 
            this.panel25.Controls.Add(this.txbUsername);
            this.panel25.Controls.Add(this.label11);
            this.panel25.Location = new System.Drawing.Point(15, 4);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(363, 55);
            this.panel25.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Tomato;
            this.label11.Location = new System.Drawing.Point(14, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Tên tài khoản:";
            // 
            // txbUsername
            // 
            this.txbUsername.BackColor = System.Drawing.SystemColors.Window;
            this.txbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsername.Location = new System.Drawing.Point(122, 19);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(238, 27);
            this.txbUsername.TabIndex = 2;
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.txbDisplayName);
            this.panel24.Controls.Add(this.label10);
            this.panel24.Location = new System.Drawing.Point(15, 65);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(363, 55);
            this.panel24.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Tomato;
            this.label10.Location = new System.Drawing.Point(14, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Tên hiện thị:";
            // 
            // txbDisplayName
            // 
            this.txbDisplayName.BackColor = System.Drawing.SystemColors.Window;
            this.txbDisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDisplayName.Location = new System.Drawing.Point(122, 19);
            this.txbDisplayName.Name = "txbDisplayName";
            this.txbDisplayName.Size = new System.Drawing.Size(238, 27);
            this.txbDisplayName.TabIndex = 2;
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.numericUpDown1);
            this.panel23.Controls.Add(this.label9);
            this.panel23.Location = new System.Drawing.Point(15, 126);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(363, 55);
            this.panel23.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Tomato;
            this.label9.Location = new System.Drawing.Point(14, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Loại tài khoản:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(123, 15);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(52, 27);
            this.numericUpDown1.TabIndex = 2;
            // 
            // btnReset
            // 
            this.btnReset.ForeColor = System.Drawing.Color.Tomato;
            this.btnReset.Location = new System.Drawing.Point(250, 196);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(125, 52);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Đặt lại mật khẩu";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tabFood
            // 
            this.tabFood.Controls.Add(this.panel6);
            this.tabFood.Controls.Add(this.panel5);
            this.tabFood.Controls.Add(this.panel4);
            this.tabFood.Controls.Add(this.panel3);
            this.tabFood.Location = new System.Drawing.Point(4, 25);
            this.tabFood.Name = "tabFood";
            this.tabFood.Padding = new System.Windows.Forms.Padding(3);
            this.tabFood.Size = new System.Drawing.Size(781, 402);
            this.tabFood.TabIndex = 1;
            this.tabFood.Text = "Thức ăn";
            this.tabFood.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvFood);
            this.panel3.Location = new System.Drawing.Point(0, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(382, 332);
            this.panel3.TabIndex = 0;
            // 
            // dtgvFood
            // 
            this.dtgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFood.Location = new System.Drawing.Point(7, 4);
            this.dtgvFood.Name = "dtgvFood";
            this.dtgvFood.RowHeadersWidth = 51;
            this.dtgvFood.RowTemplate.Height = 24;
            this.dtgvFood.Size = new System.Drawing.Size(372, 322);
            this.dtgvFood.TabIndex = 0;
            this.dtgvFood.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvFood_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel10);
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Location = new System.Drawing.Point(388, 70);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(393, 332);
            this.panel4.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txbFoodId);
            this.panel7.Controls.Add(this.txtnamelogin);
            this.panel7.Location = new System.Drawing.Point(15, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(363, 55);
            this.panel7.TabIndex = 2;
            // 
            // txtnamelogin
            // 
            this.txtnamelogin.AutoSize = true;
            this.txtnamelogin.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnamelogin.ForeColor = System.Drawing.Color.Tomato;
            this.txtnamelogin.Location = new System.Drawing.Point(14, 22);
            this.txtnamelogin.Name = "txtnamelogin";
            this.txtnamelogin.Size = new System.Drawing.Size(24, 16);
            this.txtnamelogin.TabIndex = 1;
            this.txtnamelogin.Text = "ID:";
            this.txtnamelogin.Click += new System.EventHandler(this.txtnamelogin_Click);
            // 
            // txbFoodId
            // 
            this.txbFoodId.BackColor = System.Drawing.SystemColors.Window;
            this.txbFoodId.Location = new System.Drawing.Point(87, 19);
            this.txbFoodId.Name = "txbFoodId";
            this.txbFoodId.ReadOnly = true;
            this.txbFoodId.Size = new System.Drawing.Size(273, 22);
            this.txbFoodId.TabIndex = 2;
            this.txbFoodId.TextChanged += new System.EventHandler(this.txbusername_TextChanged);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txbFoodName);
            this.panel8.Controls.Add(this.label1);
            this.panel8.Location = new System.Drawing.Point(15, 65);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(363, 55);
            this.panel8.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên món:";
            // 
            // txbFoodName
            // 
            this.txbFoodName.BackColor = System.Drawing.SystemColors.Window;
            this.txbFoodName.Location = new System.Drawing.Point(87, 19);
            this.txbFoodName.Name = "txbFoodName";
            this.txbFoodName.Size = new System.Drawing.Size(273, 22);
            this.txbFoodName.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.cbFoodCategory);
            this.panel9.Controls.Add(this.label2);
            this.panel9.Location = new System.Drawing.Point(15, 126);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(363, 55);
            this.panel9.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(14, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh mục:";
            // 
            // cbFoodCategory
            // 
            this.cbFoodCategory.FormattingEnabled = true;
            this.cbFoodCategory.Location = new System.Drawing.Point(87, 19);
            this.cbFoodCategory.Name = "cbFoodCategory";
            this.cbFoodCategory.Size = new System.Drawing.Size(273, 24);
            this.cbFoodCategory.TabIndex = 2;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.nmFood);
            this.panel10.Controls.Add(this.Gia);
            this.panel10.Location = new System.Drawing.Point(15, 187);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(363, 55);
            this.panel10.TabIndex = 5;
            // 
            // Gia
            // 
            this.Gia.AutoSize = true;
            this.Gia.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gia.ForeColor = System.Drawing.Color.Tomato;
            this.Gia.Location = new System.Drawing.Point(14, 18);
            this.Gia.Name = "Gia";
            this.Gia.Size = new System.Drawing.Size(33, 16);
            this.Gia.TabIndex = 1;
            this.Gia.Text = "Giá:";
            this.Gia.Click += new System.EventHandler(this.Gia_Click);
            // 
            // nmFood
            // 
            this.nmFood.Location = new System.Drawing.Point(87, 16);
            this.nmFood.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nmFood.Name = "nmFood";
            this.nmFood.Size = new System.Drawing.Size(276, 22);
            this.nmFood.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.Controls.Add(this.btnshowfood);
            this.panel5.Controls.Add(this.btnEdit);
            this.panel5.Controls.Add(this.btnExit);
            this.panel5.Controls.Add(this.btnaddFood);
            this.panel5.Location = new System.Drawing.Point(6, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(379, 61);
            this.panel5.TabIndex = 2;
            // 
            // btnaddFood
            // 
            this.btnaddFood.ForeColor = System.Drawing.Color.Tomato;
            this.btnaddFood.Location = new System.Drawing.Point(3, 0);
            this.btnaddFood.Name = "btnaddFood";
            this.btnaddFood.Size = new System.Drawing.Size(87, 58);
            this.btnaddFood.TabIndex = 0;
            this.btnaddFood.Text = "Thêm";
            this.btnaddFood.UseVisualStyleBackColor = true;
            this.btnaddFood.Click += new System.EventHandler(this.btnaddFood_Click);
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.Tomato;
            this.btnExit.Location = new System.Drawing.Point(96, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 58);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Xóa";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ForeColor = System.Drawing.Color.Tomato;
            this.btnEdit.Location = new System.Drawing.Point(194, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(93, 58);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnshowfood
            // 
            this.btnshowfood.ForeColor = System.Drawing.Color.Tomato;
            this.btnshowfood.Location = new System.Drawing.Point(293, 0);
            this.btnshowfood.Name = "btnshowfood";
            this.btnshowfood.Size = new System.Drawing.Size(83, 58);
            this.btnshowfood.TabIndex = 3;
            this.btnshowfood.Text = "Xem";
            this.btnshowfood.UseVisualStyleBackColor = true;
            this.btnshowfood.Click += new System.EventHandler(this.btnshowfood_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txbsearchFoodName);
            this.panel6.Controls.Add(this.btnSearch);
            this.panel6.Location = new System.Drawing.Point(388, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(393, 58);
            this.panel6.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.ForeColor = System.Drawing.Color.Tomato;
            this.btnSearch.Location = new System.Drawing.Point(285, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 52);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txbsearchFoodName
            // 
            this.txbsearchFoodName.Location = new System.Drawing.Point(3, 18);
            this.txbsearchFoodName.Name = "txbsearchFoodName";
            this.txbsearchFoodName.Size = new System.Drawing.Size(264, 22);
            this.txbsearchFoodName.TabIndex = 3;
            // 
            // tabBill
            // 
            this.tabBill.Controls.Add(this.panel2);
            this.tabBill.Controls.Add(this.panel1);
            this.tabBill.Location = new System.Drawing.Point(4, 25);
            this.tabBill.Name = "tabBill";
            this.tabBill.Padding = new System.Windows.Forms.Padding(3);
            this.tabBill.Size = new System.Drawing.Size(781, 402);
            this.tabBill.TabIndex = 0;
            this.tabBill.Text = "Doanh thu";
            this.tabBill.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvBill);
            this.panel1.Location = new System.Drawing.Point(22, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 332);
            this.panel1.TabIndex = 0;
            // 
            // dtgvBill
            // 
            this.dtgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBill.Location = new System.Drawing.Point(6, 0);
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.RowHeadersWidth = 51;
            this.dtgvBill.RowTemplate.Height = 24;
            this.dtgvBill.Size = new System.Drawing.Size(730, 332);
            this.dtgvBill.TabIndex = 0;
            this.dtgvBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvBill_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnViewbill);
            this.panel2.Controls.Add(this.dateTimePickertoday);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Location = new System.Drawing.Point(20, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(738, 32);
            this.panel2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(2, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(256, 22);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2024, 12, 1, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePickertoday
            // 
            this.dateTimePickertoday.Location = new System.Drawing.Point(476, 3);
            this.dateTimePickertoday.Name = "dateTimePickertoday";
            this.dateTimePickertoday.Size = new System.Drawing.Size(259, 22);
            this.dateTimePickertoday.TabIndex = 2;
            this.dateTimePickertoday.Value = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.dateTimePickertoday.ValueChanged += new System.EventHandler(this.dateTimePickertoday_ValueChanged);
            // 
            // btnViewbill
            // 
            this.btnViewbill.ForeColor = System.Drawing.Color.Tomato;
            this.btnViewbill.Location = new System.Drawing.Point(309, 2);
            this.btnViewbill.Name = "btnViewbill";
            this.btnViewbill.Size = new System.Drawing.Size(102, 27);
            this.btnViewbill.TabIndex = 3;
            this.btnViewbill.Text = "Thống kê";
            this.btnViewbill.UseVisualStyleBackColor = true;
            this.btnViewbill.Click += new System.EventHandler(this.btnViewbill_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabBill);
            this.tabControl1.Controls.Add(this.tabFood);
            this.tabControl1.Controls.Add(this.tabAccount);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(789, 431);
            this.tabControl1.TabIndex = 0;
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(814, 456);
            this.Controls.Add(this.tabControl1);
            this.Name = "fAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.fAdmin_Load);
            this.tabAccount.ResumeLayout(false);
            this.panel20.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).EndInit();
            this.panel21.ResumeLayout(false);
            this.panel25.ResumeLayout(false);
            this.panel25.PerformLayout();
            this.panel24.ResumeLayout(false);
            this.panel24.PerformLayout();
            this.panel23.ResumeLayout(false);
            this.panel23.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabFood.ResumeLayout(false);
            this.tabFood.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFood)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tabBill.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabAccount;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.TextBox txbDisplayName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dtgvAccount;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Button btnShowAccount;
        private System.Windows.Forms.Button btnEditAccount;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.TabPage tabFood;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txbsearchFoodName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnshowfood;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnaddFood;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.NumericUpDown nmFood;
        private System.Windows.Forms.Label Gia;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ComboBox cbFoodCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txbFoodName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txbFoodId;
        private System.Windows.Forms.Label txtnamelogin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvFood;
        private System.Windows.Forms.TabPage tabBill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnViewbill;
        private System.Windows.Forms.DateTimePicker dateTimePickertoday;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvBill;
        private System.Windows.Forms.TabControl tabControl1;
    }
}