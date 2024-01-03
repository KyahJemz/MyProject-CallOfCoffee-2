namespace LaysonMidtermsProjet
{
    partial class AdminPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Items = new System.Windows.Forms.Button();
            this.btn_Accounts = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Orders = new System.Windows.Forms.Button();
            this.pnl_Orders = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_Date1 = new System.Windows.Forms.DateTimePicker();
            this.dtp_Date2 = new System.Windows.Forms.DateTimePicker();
            this.rb_Custom = new System.Windows.Forms.RadioButton();
            this.rb_All = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_Id = new System.Windows.Forms.CheckBox();
            this.cb_Timestamp = new System.Windows.Forms.CheckBox();
            this.cb_CustomerName = new System.Windows.Forms.CheckBox();
            this.cb_TotalPrice = new System.Windows.Forms.CheckBox();
            this.cb_ItemQuantity = new System.Windows.Forms.CheckBox();
            this.btn_Search1 = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.dgv_Orders = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl_Accounts = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_AccDelete = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.btn_AccSave = new System.Windows.Forms.Button();
            this.txt_Firstname = new System.Windows.Forms.TextBox();
            this.txt_Gender = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_Lastname = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Age = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dgv_Accounts = new System.Windows.Forms.DataGridView();
            this.pnl_Items = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_ItemsDelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ItemsSave = new System.Windows.Forms.Button();
            this.txt_ItemName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ItemPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ItemImage = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv_Items = new System.Windows.Forms.DataGridView();
            this.cb_NewItem = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.pnl_Orders.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Orders)).BeginInit();
            this.pnl_Accounts.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Accounts)).BeginInit();
            this.pnl_Items.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Items)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_Items);
            this.panel1.Controls.Add(this.btn_Accounts);
            this.panel1.Controls.Add(this.btn_Logout);
            this.panel1.Controls.Add(this.btn_Orders);
            this.panel1.Location = new System.Drawing.Point(12, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 345);
            this.panel1.TabIndex = 20;
            // 
            // btn_Items
            // 
            this.btn_Items.BackColor = System.Drawing.Color.White;
            this.btn_Items.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Items.Location = new System.Drawing.Point(3, 62);
            this.btn_Items.Name = "btn_Items";
            this.btn_Items.Size = new System.Drawing.Size(134, 23);
            this.btn_Items.TabIndex = 5;
            this.btn_Items.Text = "Items";
            this.btn_Items.UseVisualStyleBackColor = false;
            this.btn_Items.Click += new System.EventHandler(this.btn_Items_Click);
            // 
            // btn_Accounts
            // 
            this.btn_Accounts.BackColor = System.Drawing.Color.White;
            this.btn_Accounts.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Accounts.Location = new System.Drawing.Point(3, 33);
            this.btn_Accounts.Name = "btn_Accounts";
            this.btn_Accounts.Size = new System.Drawing.Size(134, 23);
            this.btn_Accounts.TabIndex = 4;
            this.btn_Accounts.Text = "Accounts";
            this.btn_Accounts.UseVisualStyleBackColor = false;
            this.btn_Accounts.Click += new System.EventHandler(this.btn_Accounts_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.White;
            this.btn_Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Logout.Location = new System.Drawing.Point(3, 319);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(134, 23);
            this.btn_Logout.TabIndex = 3;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_Orders
            // 
            this.btn_Orders.BackColor = System.Drawing.Color.White;
            this.btn_Orders.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Orders.Location = new System.Drawing.Point(3, 4);
            this.btn_Orders.Name = "btn_Orders";
            this.btn_Orders.Size = new System.Drawing.Size(134, 23);
            this.btn_Orders.TabIndex = 2;
            this.btn_Orders.Text = "Orders";
            this.btn_Orders.UseVisualStyleBackColor = false;
            this.btn_Orders.Click += new System.EventHandler(this.btn_Orders_Click);
            // 
            // pnl_Orders
            // 
            this.pnl_Orders.BackColor = System.Drawing.Color.White;
            this.pnl_Orders.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Orders.Controls.Add(this.groupBox2);
            this.pnl_Orders.Controls.Add(this.groupBox1);
            this.pnl_Orders.Controls.Add(this.btn_Search1);
            this.pnl_Orders.Controls.Add(this.txt_Search);
            this.pnl_Orders.Controls.Add(this.dgv_Orders);
            this.pnl_Orders.Location = new System.Drawing.Point(158, 84);
            this.pnl_Orders.Name = "pnl_Orders";
            this.pnl_Orders.Size = new System.Drawing.Size(594, 345);
            this.pnl_Orders.TabIndex = 21;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtp_Date1);
            this.groupBox2.Controls.Add(this.dtp_Date2);
            this.groupBox2.Controls.Add(this.rb_Custom);
            this.groupBox2.Controls.Add(this.rb_All);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(211, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 82);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Date Range";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "to";
            // 
            // dtp_Date1
            // 
            this.dtp_Date1.CustomFormat = "YYYY-MM-DD";
            this.dtp_Date1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Date1.Location = new System.Drawing.Point(4, 57);
            this.dtp_Date1.Name = "dtp_Date1";
            this.dtp_Date1.Size = new System.Drawing.Size(80, 20);
            this.dtp_Date1.TabIndex = 24;
            this.dtp_Date1.Value = new System.DateTime(2023, 5, 7, 0, 0, 0, 0);
            // 
            // dtp_Date2
            // 
            this.dtp_Date2.CustomFormat = "YYYY-MM-DD";
            this.dtp_Date2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Date2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtp_Date2.Location = new System.Drawing.Point(103, 57);
            this.dtp_Date2.Name = "dtp_Date2";
            this.dtp_Date2.Size = new System.Drawing.Size(80, 20);
            this.dtp_Date2.TabIndex = 25;
            this.dtp_Date2.Value = new System.DateTime(2023, 5, 7, 0, 0, 0, 0);
            // 
            // rb_Custom
            // 
            this.rb_Custom.AutoSize = true;
            this.rb_Custom.Location = new System.Drawing.Point(6, 35);
            this.rb_Custom.Name = "rb_Custom";
            this.rb_Custom.Size = new System.Drawing.Size(86, 17);
            this.rb_Custom.TabIndex = 1;
            this.rb_Custom.Text = "Custom Date";
            this.rb_Custom.UseVisualStyleBackColor = true;
            // 
            // rb_All
            // 
            this.rb_All.AutoSize = true;
            this.rb_All.Checked = true;
            this.rb_All.Location = new System.Drawing.Point(6, 16);
            this.rb_All.Name = "rb_All";
            this.rb_All.Size = new System.Drawing.Size(62, 17);
            this.rb_All.TabIndex = 0;
            this.rb_All.TabStop = true;
            this.rb_All.Text = "All Date";
            this.rb_All.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.cb_Id);
            this.groupBox1.Controls.Add(this.cb_Timestamp);
            this.groupBox1.Controls.Add(this.cb_CustomerName);
            this.groupBox1.Controls.Add(this.cb_TotalPrice);
            this.groupBox1.Controls.Add(this.cb_ItemQuantity);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 82);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Query Selector";
            // 
            // cb_Id
            // 
            this.cb_Id.AutoSize = true;
            this.cb_Id.Checked = true;
            this.cb_Id.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Id.Location = new System.Drawing.Point(6, 16);
            this.cb_Id.Name = "cb_Id";
            this.cb_Id.Size = new System.Drawing.Size(64, 17);
            this.cb_Id.TabIndex = 24;
            this.cb_Id.Text = "Order Id";
            this.cb_Id.UseVisualStyleBackColor = true;
            // 
            // cb_Timestamp
            // 
            this.cb_Timestamp.AutoSize = true;
            this.cb_Timestamp.Checked = true;
            this.cb_Timestamp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Timestamp.Location = new System.Drawing.Point(105, 39);
            this.cb_Timestamp.Name = "cb_Timestamp";
            this.cb_Timestamp.Size = new System.Drawing.Size(77, 17);
            this.cb_Timestamp.TabIndex = 29;
            this.cb_Timestamp.Text = "Timestamp";
            this.cb_Timestamp.UseVisualStyleBackColor = true;
            // 
            // cb_CustomerName
            // 
            this.cb_CustomerName.AutoSize = true;
            this.cb_CustomerName.Checked = true;
            this.cb_CustomerName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_CustomerName.Location = new System.Drawing.Point(6, 39);
            this.cb_CustomerName.Name = "cb_CustomerName";
            this.cb_CustomerName.Size = new System.Drawing.Size(101, 17);
            this.cb_CustomerName.TabIndex = 26;
            this.cb_CustomerName.Text = "Customer Name";
            this.cb_CustomerName.UseVisualStyleBackColor = true;
            // 
            // cb_TotalPrice
            // 
            this.cb_TotalPrice.AutoSize = true;
            this.cb_TotalPrice.Checked = true;
            this.cb_TotalPrice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_TotalPrice.Location = new System.Drawing.Point(105, 16);
            this.cb_TotalPrice.Name = "cb_TotalPrice";
            this.cb_TotalPrice.Size = new System.Drawing.Size(77, 17);
            this.cb_TotalPrice.TabIndex = 28;
            this.cb_TotalPrice.Text = "Total Price";
            this.cb_TotalPrice.UseVisualStyleBackColor = true;
            // 
            // cb_ItemQuantity
            // 
            this.cb_ItemQuantity.AutoSize = true;
            this.cb_ItemQuantity.Checked = true;
            this.cb_ItemQuantity.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_ItemQuantity.Location = new System.Drawing.Point(6, 62);
            this.cb_ItemQuantity.Name = "cb_ItemQuantity";
            this.cb_ItemQuantity.Size = new System.Drawing.Size(88, 17);
            this.cb_ItemQuantity.TabIndex = 27;
            this.cb_ItemQuantity.Text = "Item Quantity";
            this.cb_ItemQuantity.UseVisualStyleBackColor = true;
            // 
            // btn_Search1
            // 
            this.btn_Search1.Location = new System.Drawing.Point(532, 61);
            this.btn_Search1.Name = "btn_Search1";
            this.btn_Search1.Size = new System.Drawing.Size(49, 23);
            this.btn_Search1.TabIndex = 25;
            this.btn_Search1.Text = "Search";
            this.btn_Search1.UseVisualStyleBackColor = true;
            this.btn_Search1.Click += new System.EventHandler(this.btn_Search1_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(403, 62);
            this.txt_Search.MaxLength = 50;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(127, 20);
            this.txt_Search.TabIndex = 24;
            // 
            // dgv_Orders
            // 
            this.dgv_Orders.AllowUserToAddRows = false;
            this.dgv_Orders.AllowUserToDeleteRows = false;
            this.dgv_Orders.AllowUserToResizeRows = false;
            this.dgv_Orders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Orders.Location = new System.Drawing.Point(11, 87);
            this.dgv_Orders.Name = "dgv_Orders";
            this.dgv_Orders.ReadOnly = true;
            this.dgv_Orders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Orders.Size = new System.Drawing.Size(570, 245);
            this.dgv_Orders.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(8, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 26);
            this.label2.TabIndex = 23;
            this.label2.Text = "Welcome to our coffee shop! \r\nEnjoy our delicious coffee in a cozy atmosphere.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mistral", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(4, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 48);
            this.label3.TabIndex = 22;
            this.label3.Text = "Coffee Ko";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_Accounts
            // 
            this.pnl_Accounts.BackColor = System.Drawing.Color.White;
            this.pnl_Accounts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Accounts.Controls.Add(this.groupBox3);
            this.pnl_Accounts.Controls.Add(this.dgv_Accounts);
            this.pnl_Accounts.Location = new System.Drawing.Point(158, 84);
            this.pnl_Accounts.Name = "pnl_Accounts";
            this.pnl_Accounts.Size = new System.Drawing.Size(594, 345);
            this.pnl_Accounts.TabIndex = 32;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.btn_AccDelete);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txt_Email);
            this.groupBox3.Controls.Add(this.btn_AccSave);
            this.groupBox3.Controls.Add(this.txt_Firstname);
            this.groupBox3.Controls.Add(this.txt_Gender);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txt_Lastname);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txt_Password);
            this.groupBox3.Controls.Add(this.txt_Age);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox3.Location = new System.Drawing.Point(431, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(150, 313);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Profile Details";
            // 
            // btn_AccDelete
            // 
            this.btn_AccDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_AccDelete.ForeColor = System.Drawing.Color.Black;
            this.btn_AccDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_AccDelete.Location = new System.Drawing.Point(9, 284);
            this.btn_AccDelete.Name = "btn_AccDelete";
            this.btn_AccDelete.Size = new System.Drawing.Size(63, 23);
            this.btn_AccDelete.TabIndex = 44;
            this.btn_AccDelete.Text = "Delete";
            this.btn_AccDelete.UseVisualStyleBackColor = false;
            this.btn_AccDelete.Click += new System.EventHandler(this.btn_AccDelete_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label16.Location = new System.Drawing.Point(6, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "Firstname : ";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(28, 200);
            this.txt_Email.MaxLength = 50;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(116, 20);
            this.txt_Email.TabIndex = 36;
            // 
            // btn_AccSave
            // 
            this.btn_AccSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_AccSave.ForeColor = System.Drawing.Color.Black;
            this.btn_AccSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_AccSave.Location = new System.Drawing.Point(81, 284);
            this.btn_AccSave.Name = "btn_AccSave";
            this.btn_AccSave.Size = new System.Drawing.Size(63, 23);
            this.btn_AccSave.TabIndex = 26;
            this.btn_AccSave.Text = "Save";
            this.btn_AccSave.UseVisualStyleBackColor = false;
            this.btn_AccSave.Click += new System.EventHandler(this.btn_AccSave_Click);
            // 
            // txt_Firstname
            // 
            this.txt_Firstname.Location = new System.Drawing.Point(28, 43);
            this.txt_Firstname.MaxLength = 50;
            this.txt_Firstname.Name = "txt_Firstname";
            this.txt_Firstname.Size = new System.Drawing.Size(116, 20);
            this.txt_Firstname.TabIndex = 29;
            // 
            // txt_Gender
            // 
            this.txt_Gender.FormattingEnabled = true;
            this.txt_Gender.ItemHeight = 13;
            this.txt_Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.txt_Gender.Location = new System.Drawing.Point(28, 160);
            this.txt_Gender.Name = "txt_Gender";
            this.txt_Gender.Size = new System.Drawing.Size(116, 21);
            this.txt_Gender.TabIndex = 43;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label15.Location = new System.Drawing.Point(6, 66);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Lastname : ";
            // 
            // txt_Lastname
            // 
            this.txt_Lastname.Location = new System.Drawing.Point(28, 82);
            this.txt_Lastname.MaxLength = 50;
            this.txt_Lastname.Name = "txt_Lastname";
            this.txt_Lastname.Size = new System.Drawing.Size(116, 20);
            this.txt_Lastname.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(6, 105);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Age : ";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(28, 239);
            this.txt_Password.MaxLength = 50;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(116, 20);
            this.txt_Password.TabIndex = 40;
            this.txt_Password.UseWaitCursor = true;
            // 
            // txt_Age
            // 
            this.txt_Age.Location = new System.Drawing.Point(28, 121);
            this.txt_Age.MaxLength = 3;
            this.txt_Age.Name = "txt_Age";
            this.txt_Age.Size = new System.Drawing.Size(116, 20);
            this.txt_Age.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(6, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Password : ";
            this.label10.UseWaitCursor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(6, 144);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Gender :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(6, 184);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Email : ";
            // 
            // dgv_Accounts
            // 
            this.dgv_Accounts.AllowUserToAddRows = false;
            this.dgv_Accounts.AllowUserToDeleteRows = false;
            this.dgv_Accounts.AllowUserToResizeRows = false;
            this.dgv_Accounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Accounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Accounts.Location = new System.Drawing.Point(11, 19);
            this.dgv_Accounts.Name = "dgv_Accounts";
            this.dgv_Accounts.ReadOnly = true;
            this.dgv_Accounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Accounts.Size = new System.Drawing.Size(414, 313);
            this.dgv_Accounts.TabIndex = 2;
            this.dgv_Accounts.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Accounts_CellMouseDoubleClick);
            // 
            // pnl_Items
            // 
            this.pnl_Items.BackColor = System.Drawing.Color.White;
            this.pnl_Items.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Items.Controls.Add(this.groupBox4);
            this.pnl_Items.Controls.Add(this.dgv_Items);
            this.pnl_Items.Location = new System.Drawing.Point(158, 84);
            this.pnl_Items.Name = "pnl_Items";
            this.pnl_Items.Size = new System.Drawing.Size(594, 345);
            this.pnl_Items.TabIndex = 49;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.cb_NewItem);
            this.groupBox4.Controls.Add(this.btn_ItemsDelete);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.btn_ItemsSave);
            this.groupBox4.Controls.Add(this.txt_ItemName);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txt_ItemPrice);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txt_ItemImage);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox4.Location = new System.Drawing.Point(431, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(150, 205);
            this.groupBox4.TabIndex = 48;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Item Details";
            // 
            // btn_ItemsDelete
            // 
            this.btn_ItemsDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_ItemsDelete.ForeColor = System.Drawing.Color.Black;
            this.btn_ItemsDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_ItemsDelete.Location = new System.Drawing.Point(9, 170);
            this.btn_ItemsDelete.Name = "btn_ItemsDelete";
            this.btn_ItemsDelete.Size = new System.Drawing.Size(63, 23);
            this.btn_ItemsDelete.TabIndex = 44;
            this.btn_ItemsDelete.Text = "Delete";
            this.btn_ItemsDelete.UseVisualStyleBackColor = false;
            this.btn_ItemsDelete.Click += new System.EventHandler(this.btn_ItemsDelete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Item Name :";
            // 
            // btn_ItemsSave
            // 
            this.btn_ItemsSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_ItemsSave.ForeColor = System.Drawing.Color.Black;
            this.btn_ItemsSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_ItemsSave.Location = new System.Drawing.Point(81, 170);
            this.btn_ItemsSave.Name = "btn_ItemsSave";
            this.btn_ItemsSave.Size = new System.Drawing.Size(63, 23);
            this.btn_ItemsSave.TabIndex = 26;
            this.btn_ItemsSave.Text = "Save";
            this.btn_ItemsSave.UseVisualStyleBackColor = false;
            this.btn_ItemsSave.Click += new System.EventHandler(this.btn_ItemsSave_Click);
            // 
            // txt_ItemName
            // 
            this.txt_ItemName.Location = new System.Drawing.Point(28, 43);
            this.txt_ItemName.MaxLength = 50;
            this.txt_ItemName.Name = "txt_ItemName";
            this.txt_ItemName.Size = new System.Drawing.Size(116, 20);
            this.txt_ItemName.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(6, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Item Price :";
            // 
            // txt_ItemPrice
            // 
            this.txt_ItemPrice.Location = new System.Drawing.Point(28, 82);
            this.txt_ItemPrice.MaxLength = 50;
            this.txt_ItemPrice.Name = "txt_ItemPrice";
            this.txt_ItemPrice.Size = new System.Drawing.Size(116, 20);
            this.txt_ItemPrice.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(6, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Item Image :";
            // 
            // txt_ItemImage
            // 
            this.txt_ItemImage.Location = new System.Drawing.Point(28, 121);
            this.txt_ItemImage.MaxLength = 50;
            this.txt_ItemImage.Name = "txt_ItemImage";
            this.txt_ItemImage.Size = new System.Drawing.Size(116, 20);
            this.txt_ItemImage.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(6, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 34;
            // 
            // dgv_Items
            // 
            this.dgv_Items.AllowUserToAddRows = false;
            this.dgv_Items.AllowUserToDeleteRows = false;
            this.dgv_Items.AllowUserToResizeRows = false;
            this.dgv_Items.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Items.Location = new System.Drawing.Point(11, 19);
            this.dgv_Items.Name = "dgv_Items";
            this.dgv_Items.ReadOnly = true;
            this.dgv_Items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Items.Size = new System.Drawing.Size(414, 313);
            this.dgv_Items.TabIndex = 2;
            this.dgv_Items.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Items_CellMouseDoubleClick);
            // 
            // cb_NewItem
            // 
            this.cb_NewItem.AutoSize = true;
            this.cb_NewItem.Location = new System.Drawing.Point(9, 147);
            this.cb_NewItem.Name = "cb_NewItem";
            this.cb_NewItem.Size = new System.Drawing.Size(105, 17);
            this.cb_NewItem.TabIndex = 45;
            this.cb_NewItem.Text = "Add as new Item";
            this.cb_NewItem.UseVisualStyleBackColor = true;
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(764, 441);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_Orders);
            this.Controls.Add(this.pnl_Items);
            this.Controls.Add(this.pnl_Accounts);
            this.Name = "AdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Page <3";
            this.panel1.ResumeLayout(false);
            this.pnl_Orders.ResumeLayout(false);
            this.pnl_Orders.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Orders)).EndInit();
            this.pnl_Accounts.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Accounts)).EndInit();
            this.pnl_Items.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Items)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Orders;
        private System.Windows.Forms.DataGridView dgv_Orders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Search1;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_Custom;
        private System.Windows.Forms.RadioButton rb_All;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cb_Id;
        private System.Windows.Forms.CheckBox cb_Timestamp;
        private System.Windows.Forms.CheckBox cb_CustomerName;
        private System.Windows.Forms.CheckBox cb_TotalPrice;
        private System.Windows.Forms.CheckBox cb_ItemQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_Date1;
        private System.Windows.Forms.DateTimePicker dtp_Date2;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Panel pnl_Orders;
        private System.Windows.Forms.Button btn_Items;
        private System.Windows.Forms.Button btn_Accounts;
        private System.Windows.Forms.Panel pnl_Accounts;
        private System.Windows.Forms.DataGridView dgv_Accounts;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_AccSave;
        private System.Windows.Forms.TextBox txt_Firstname;
        private System.Windows.Forms.ComboBox txt_Gender;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_Lastname;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_Age;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_AccDelete;
        private System.Windows.Forms.Panel pnl_Items;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_ItemsDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_ItemsSave;
        private System.Windows.Forms.TextBox txt_ItemName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ItemPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ItemImage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgv_Items;
        private System.Windows.Forms.CheckBox cb_NewItem;
    }
}