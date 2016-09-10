namespace ShoppingCart.WinFormUI
{
    partial class ApplicationForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationForm));
            this.ProductBox = new System.Windows.Forms.ListBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.ShoppingCartBox = new System.Windows.Forms.ListBox();
            this.QuantityBox = new System.Windows.Forms.TextBox();
            this.FullCartPriceLabal = new System.Windows.Forms.Label();
            this.ViktoryCartPriceLabal = new System.Windows.Forms.Label();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.CalculatButton = new System.Windows.Forms.Button();
            this.ShookHaiirCartPriceLabal = new System.Windows.Forms.Label();
            this.MahsaneiCartPeiceLabal = new System.Windows.Forms.Label();
            this.CheapestViktoryListBox = new System.Windows.Forms.ListBox();
            this.ExpensiveViktoryListBox = new System.Windows.Forms.ListBox();
            this.ExpensiveMahsaneiListBox = new System.Windows.Forms.ListBox();
            this.CheapestMahsaneiListBox = new System.Windows.Forms.ListBox();
            this.ExpensiveShookListBox = new System.Windows.Forms.ListBox();
            this.CheapestShookListBox = new System.Windows.Forms.ListBox();
            this.CheapestLabal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NisLabal1 = new System.Windows.Forms.Label();
            this.NisLabal2 = new System.Windows.Forms.Label();
            this.NisLabal3 = new System.Windows.Forms.Label();
            this.ProuctsLabal = new System.Windows.Forms.Label();
            this.ShoppingCartLabal = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.excelDataButton = new System.Windows.Forms.Button();
            this.UserNameLabal = new System.Windows.Forms.Label();
            this.UserNameText = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UsersComboBox = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.InformationProductPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.UnitsNameLabal = new System.Windows.Forms.Label();
            this.UnitsLabal = new System.Windows.Forms.Label();
            this.ProductNameLabal = new System.Windows.Forms.Label();
            this.PictureProduct = new System.Windows.Forms.PictureBox();
            this.ChipestViktoryToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ExpensiveViktoryToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ChipestMahsaneiToolTop = new System.Windows.Forms.ToolTip(this.components);
            this.ExpensiveMahsaneiToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ChipestShookListToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ExpensiveShookToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.InformationProductPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureProduct)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductBox
            // 
            this.ProductBox.FormattingEnabled = true;
            this.ProductBox.Location = new System.Drawing.Point(182, 54);
            this.ProductBox.Name = "ProductBox";
            this.ProductBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ProductBox.Size = new System.Drawing.Size(139, 225);
            this.ProductBox.TabIndex = 0;
            this.ProductBox.SelectedIndexChanged += new System.EventHandler(this.ProductBox_SelectedIndexChanged_1);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(347, 143);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(91, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add to Cart";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ShoppingCartBox
            // 
            this.ShoppingCartBox.FormattingEnabled = true;
            this.ShoppingCartBox.Location = new System.Drawing.Point(467, 54);
            this.ShoppingCartBox.Name = "ShoppingCartBox";
            this.ShoppingCartBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShoppingCartBox.Size = new System.Drawing.Size(148, 225);
            this.ShoppingCartBox.TabIndex = 2;
            // 
            // QuantityBox
            // 
            this.QuantityBox.Location = new System.Drawing.Point(385, 117);
            this.QuantityBox.Name = "QuantityBox";
            this.QuantityBox.Size = new System.Drawing.Size(72, 20);
            this.QuantityBox.TabIndex = 3;
            // 
            // FullCartPriceLabal
            // 
            this.FullCartPriceLabal.AutoSize = true;
            this.FullCartPriceLabal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullCartPriceLabal.Location = new System.Drawing.Point(98, 498);
            this.FullCartPriceLabal.Name = "FullCartPriceLabal";
            this.FullCartPriceLabal.Size = new System.Drawing.Size(89, 15);
            this.FullCartPriceLabal.TabIndex = 4;
            this.FullCartPriceLabal.Text = "Full Cart Price :";
            this.FullCartPriceLabal.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ViktoryCartPriceLabal
            // 
            this.ViktoryCartPriceLabal.AutoSize = true;
            this.ViktoryCartPriceLabal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViktoryCartPriceLabal.Location = new System.Drawing.Point(225, 498);
            this.ViktoryCartPriceLabal.Name = "ViktoryCartPriceLabal";
            this.ViktoryCartPriceLabal.Size = new System.Drawing.Size(92, 15);
            this.ViktoryCartPriceLabal.TabIndex = 5;
            this.ViktoryCartPriceLabal.Text = "ViktoryCartPrice";
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(347, 220);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(91, 23);
            this.RemoveButton.TabIndex = 7;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // CalculatButton
            // 
            this.CalculatButton.Location = new System.Drawing.Point(347, 249);
            this.CalculatButton.Name = "CalculatButton";
            this.CalculatButton.Size = new System.Drawing.Size(91, 23);
            this.CalculatButton.TabIndex = 8;
            this.CalculatButton.Text = "Calculat Cart";
            this.CalculatButton.UseVisualStyleBackColor = true;
            this.CalculatButton.Click += new System.EventHandler(this.CalculatButton_Click);
            // 
            // ShookHaiirCartPriceLabal
            // 
            this.ShookHaiirCartPriceLabal.AutoSize = true;
            this.ShookHaiirCartPriceLabal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShookHaiirCartPriceLabal.Location = new System.Drawing.Point(499, 498);
            this.ShookHaiirCartPriceLabal.Name = "ShookHaiirCartPriceLabal";
            this.ShookHaiirCartPriceLabal.Size = new System.Drawing.Size(92, 15);
            this.ShookHaiirCartPriceLabal.TabIndex = 10;
            this.ShookHaiirCartPriceLabal.Text = "ShookCartPrice";
            // 
            // MahsaneiCartPeiceLabal
            // 
            this.MahsaneiCartPeiceLabal.AutoSize = true;
            this.MahsaneiCartPeiceLabal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MahsaneiCartPeiceLabal.Location = new System.Drawing.Point(362, 498);
            this.MahsaneiCartPeiceLabal.Name = "MahsaneiCartPeiceLabal";
            this.MahsaneiCartPeiceLabal.Size = new System.Drawing.Size(102, 15);
            this.MahsaneiCartPeiceLabal.TabIndex = 12;
            this.MahsaneiCartPeiceLabal.Text = "MahsanCartPrice";
            // 
            // CheapestViktoryListBox
            // 
            this.CheapestViktoryListBox.FormattingEnabled = true;
            this.CheapestViktoryListBox.Location = new System.Drawing.Point(197, 373);
            this.CheapestViktoryListBox.MultiColumn = true;
            this.CheapestViktoryListBox.Name = "CheapestViktoryListBox";
            this.CheapestViktoryListBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CheapestViktoryListBox.Size = new System.Drawing.Size(128, 56);
            this.CheapestViktoryListBox.TabIndex = 14;
            this.CheapestViktoryListBox.SelectedIndexChanged += new System.EventHandler(this.ChipestViktoryListBox_SelectedIndexChanged);
            // 
            // ExpensiveViktoryListBox
            // 
            this.ExpensiveViktoryListBox.FormattingEnabled = true;
            this.ExpensiveViktoryListBox.Location = new System.Drawing.Point(197, 435);
            this.ExpensiveViktoryListBox.Name = "ExpensiveViktoryListBox";
            this.ExpensiveViktoryListBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ExpensiveViktoryListBox.Size = new System.Drawing.Size(128, 56);
            this.ExpensiveViktoryListBox.TabIndex = 15;
            this.ExpensiveViktoryListBox.SelectedIndexChanged += new System.EventHandler(this.ExpensiveViktoryListBox_SelectedIndexChanged);
            // 
            // ExpensiveMahsaneiListBox
            // 
            this.ExpensiveMahsaneiListBox.FormattingEnabled = true;
            this.ExpensiveMahsaneiListBox.Location = new System.Drawing.Point(331, 435);
            this.ExpensiveMahsaneiListBox.Name = "ExpensiveMahsaneiListBox";
            this.ExpensiveMahsaneiListBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ExpensiveMahsaneiListBox.Size = new System.Drawing.Size(128, 56);
            this.ExpensiveMahsaneiListBox.TabIndex = 18;
            this.ExpensiveMahsaneiListBox.SelectedIndexChanged += new System.EventHandler(this.ExpensiveMahsaneiListBox_SelectedIndexChanged);
            // 
            // CheapestMahsaneiListBox
            // 
            this.CheapestMahsaneiListBox.FormattingEnabled = true;
            this.CheapestMahsaneiListBox.Location = new System.Drawing.Point(331, 373);
            this.CheapestMahsaneiListBox.Name = "CheapestMahsaneiListBox";
            this.CheapestMahsaneiListBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CheapestMahsaneiListBox.Size = new System.Drawing.Size(128, 56);
            this.CheapestMahsaneiListBox.TabIndex = 17;
            this.CheapestMahsaneiListBox.SelectedIndexChanged += new System.EventHandler(this.ChipestMahsaneiListBox_SelectedIndexChanged);
            // 
            // ExpensiveShookListBox
            // 
            this.ExpensiveShookListBox.FormattingEnabled = true;
            this.ExpensiveShookListBox.Location = new System.Drawing.Point(466, 435);
            this.ExpensiveShookListBox.Name = "ExpensiveShookListBox";
            this.ExpensiveShookListBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ExpensiveShookListBox.Size = new System.Drawing.Size(128, 56);
            this.ExpensiveShookListBox.TabIndex = 21;
            this.ExpensiveShookListBox.SelectedIndexChanged += new System.EventHandler(this.ExpensiveShookListBox_SelectedIndexChanged);
            // 
            // CheapestShookListBox
            // 
            this.CheapestShookListBox.FormattingEnabled = true;
            this.CheapestShookListBox.Location = new System.Drawing.Point(466, 373);
            this.CheapestShookListBox.Name = "CheapestShookListBox";
            this.CheapestShookListBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CheapestShookListBox.Size = new System.Drawing.Size(128, 56);
            this.CheapestShookListBox.TabIndex = 20;
            this.CheapestShookListBox.SelectedIndexChanged += new System.EventHandler(this.ChipestShookListBox_SelectedIndexChanged);
            // 
            // CheapestLabal
            // 
            this.CheapestLabal.AutoSize = true;
            this.CheapestLabal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheapestLabal.Location = new System.Drawing.Point(98, 376);
            this.CheapestLabal.Name = "CheapestLabal";
            this.CheapestLabal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CheapestLabal.Size = new System.Drawing.Size(54, 15);
            this.CheapestLabal.TabIndex = 22;
            this.CheapestLabal.Text = "Chipest :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(97, 438);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "Most expensive :";
            // 
            // NisLabal1
            // 
            this.NisLabal1.AutoSize = true;
            this.NisLabal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NisLabal1.Location = new System.Drawing.Point(266, 498);
            this.NisLabal1.Name = "NisLabal1";
            this.NisLabal1.Size = new System.Drawing.Size(25, 15);
            this.NisLabal1.TabIndex = 24;
            this.NisLabal1.Text = "Nis";
            // 
            // NisLabal2
            // 
            this.NisLabal2.AutoSize = true;
            this.NisLabal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NisLabal2.Location = new System.Drawing.Point(403, 498);
            this.NisLabal2.Name = "NisLabal2";
            this.NisLabal2.Size = new System.Drawing.Size(25, 15);
            this.NisLabal2.TabIndex = 25;
            this.NisLabal2.Text = "Nis";
            // 
            // NisLabal3
            // 
            this.NisLabal3.AutoSize = true;
            this.NisLabal3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NisLabal3.Location = new System.Drawing.Point(540, 498);
            this.NisLabal3.Name = "NisLabal3";
            this.NisLabal3.Size = new System.Drawing.Size(25, 15);
            this.NisLabal3.TabIndex = 26;
            this.NisLabal3.Text = "Nis";
            // 
            // ProuctsLabal
            // 
            this.ProuctsLabal.AutoSize = true;
            this.ProuctsLabal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProuctsLabal.Location = new System.Drawing.Point(181, 33);
            this.ProuctsLabal.Name = "ProuctsLabal";
            this.ProuctsLabal.Size = new System.Drawing.Size(72, 18);
            this.ProuctsLabal.TabIndex = 4;
            this.ProuctsLabal.Text = "Products ";
            // 
            // ShoppingCartLabal
            // 
            this.ShoppingCartLabal.AutoSize = true;
            this.ShoppingCartLabal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShoppingCartLabal.Location = new System.Drawing.Point(464, 33);
            this.ShoppingCartLabal.Name = "ShoppingCartLabal";
            this.ShoppingCartLabal.Size = new System.Drawing.Size(106, 18);
            this.ShoppingCartLabal.TabIndex = 4;
            this.ShoppingCartLabal.Text = "Shopping Cart ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(325, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 15);
            this.label12.TabIndex = 27;
            this.label12.Text = "Quantity :";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(472, 286);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(66, 23);
            this.SaveButton.TabIndex = 28;
            this.SaveButton.Text = "Save Cart";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(545, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Load Cart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // excelDataButton
            // 
            this.excelDataButton.Location = new System.Drawing.Point(510, 214);
            this.excelDataButton.Name = "excelDataButton";
            this.excelDataButton.Size = new System.Drawing.Size(121, 23);
            this.excelDataButton.TabIndex = 30;
            this.excelDataButton.Text = "Save as Excel Data";
            this.excelDataButton.UseVisualStyleBackColor = true;
            this.excelDataButton.Click += new System.EventHandler(this.excelDataButton_Click);
            // 
            // UserNameLabal
            // 
            this.UserNameLabal.AutoSize = true;
            this.UserNameLabal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabal.Location = new System.Drawing.Point(3, 0);
            this.UserNameLabal.Name = "UserNameLabal";
            this.UserNameLabal.Size = new System.Drawing.Size(76, 15);
            this.UserNameLabal.TabIndex = 27;
            this.UserNameLabal.Text = "User Name :";
            this.UserNameLabal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // UserNameText
            // 
            this.UserNameText.AutoSize = true;
            this.UserNameText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameText.Location = new System.Drawing.Point(3, 23);
            this.UserNameText.Name = "UserNameText";
            this.UserNameText.Size = new System.Drawing.Size(117, 24);
            this.UserNameText.TabIndex = 31;
            this.UserNameText.Text = "UserName";
            this.UserNameText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(636, 24);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newUserToolStripMenuItem,
            this.removeUserToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // newUserToolStripMenuItem
            // 
            this.newUserToolStripMenuItem.Name = "newUserToolStripMenuItem";
            this.newUserToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.newUserToolStripMenuItem.Text = "New User";
            this.newUserToolStripMenuItem.Click += new System.EventHandler(this.newUserToolStripMenuItem_Click);
            // 
            // removeUserToolStripMenuItem
            // 
            this.removeUserToolStripMenuItem.Name = "removeUserToolStripMenuItem";
            this.removeUserToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.removeUserToolStripMenuItem.Text = "Remove User";
            this.removeUserToolStripMenuItem.Click += new System.EventHandler(this.removeUserToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // UsersComboBox
            // 
            this.UsersComboBox.FormattingEnabled = true;
            this.UsersComboBox.Location = new System.Drawing.Point(228, 286);
            this.UsersComboBox.Name = "UsersComboBox";
            this.UsersComboBox.Size = new System.Drawing.Size(93, 21);
            this.UsersComboBox.TabIndex = 33;
            this.UsersComboBox.SelectionChangeCommitted += new System.EventHandler(this.UsersComboBox_SelectionChangeCommitted);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(183, 289);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 15);
            this.label14.TabIndex = 27;
            this.label14.Text = "Users";
            // 
            // InformationProductPanel
            // 
            this.InformationProductPanel.BackColor = System.Drawing.SystemColors.Window;
            this.InformationProductPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InformationProductPanel.Controls.Add(this.tableLayoutPanel1);
            this.InformationProductPanel.Controls.Add(this.ProductNameLabal);
            this.InformationProductPanel.Controls.Add(this.PictureProduct);
            this.InformationProductPanel.Cursor = System.Windows.Forms.Cursors.Cross;
            this.InformationProductPanel.Location = new System.Drawing.Point(12, 71);
            this.InformationProductPanel.Name = "InformationProductPanel";
            this.InformationProductPanel.Size = new System.Drawing.Size(160, 197);
            this.InformationProductPanel.TabIndex = 34;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.89474F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.10526F));
            this.tableLayoutPanel1.Controls.Add(this.UnitsNameLabal, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.UnitsLabal, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 173);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(152, 44);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // UnitsNameLabal
            // 
            this.UnitsNameLabal.AutoSize = true;
            this.UnitsNameLabal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UnitsNameLabal.Location = new System.Drawing.Point(91, 0);
            this.UnitsNameLabal.Name = "UnitsNameLabal";
            this.UnitsNameLabal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UnitsNameLabal.Size = new System.Drawing.Size(58, 22);
            this.UnitsNameLabal.TabIndex = 0;
            this.UnitsNameLabal.Text = "יחידות :";
            this.UnitsNameLabal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UnitsLabal
            // 
            this.UnitsLabal.AutoSize = true;
            this.UnitsLabal.Dock = System.Windows.Forms.DockStyle.Right;
            this.UnitsLabal.Location = new System.Drawing.Point(28, 0);
            this.UnitsLabal.Name = "UnitsLabal";
            this.UnitsLabal.Size = new System.Drawing.Size(57, 22);
            this.UnitsLabal.TabIndex = 1;
            this.UnitsLabal.Text = "UnitsLabal";
            this.UnitsLabal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProductNameLabal
            // 
            this.ProductNameLabal.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProductNameLabal.Font = new System.Drawing.Font("David", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameLabal.Location = new System.Drawing.Point(0, 0);
            this.ProductNameLabal.Name = "ProductNameLabal";
            this.ProductNameLabal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ProductNameLabal.Size = new System.Drawing.Size(158, 13);
            this.ProductNameLabal.TabIndex = 1;
            this.ProductNameLabal.Text = "ProductNameLabal";
            this.ProductNameLabal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProductNameLabal.UseMnemonic = false;
            // 
            // PictureProduct
            // 
            this.PictureProduct.Location = new System.Drawing.Point(2, 27);
            this.PictureProduct.Name = "PictureProduct";
            this.PictureProduct.Size = new System.Drawing.Size(154, 142);
            this.PictureProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureProduct.TabIndex = 0;
            this.PictureProduct.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.excelDataButton);
            this.panel1.Location = new System.Drawing.Point(-1, 314);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 242);
            this.panel1.TabIndex = 36;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ShoppingCart.WinFormUI.Properties.Resources._11351187_Shopping_cart_full_of_different_products_Illustration_on_white_background__Stock_Vector;
            this.pictureBox4.Location = new System.Drawing.Point(-17, 95);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(240, 235);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 35;
            this.pictureBox4.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.UserNameText, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.UserNameLabal, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(334, 54);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(123, 47);
            this.tableLayoutPanel2.TabIndex = 37;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(466, 321);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(128, 46);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(331, 321);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(197, 321);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // ApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 558);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.InformationProductPanel);
            this.Controls.Add(this.UsersComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.NisLabal3);
            this.Controls.Add(this.NisLabal2);
            this.Controls.Add(this.NisLabal1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CheapestLabal);
            this.Controls.Add(this.ExpensiveShookListBox);
            this.Controls.Add(this.CheapestShookListBox);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.ExpensiveMahsaneiListBox);
            this.Controls.Add(this.CheapestMahsaneiListBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ExpensiveViktoryListBox);
            this.Controls.Add(this.CheapestViktoryListBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MahsaneiCartPeiceLabal);
            this.Controls.Add(this.ShookHaiirCartPriceLabal);
            this.Controls.Add(this.CalculatButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.ViktoryCartPriceLabal);
            this.Controls.Add(this.ShoppingCartLabal);
            this.Controls.Add(this.ProuctsLabal);
            this.Controls.Add(this.FullCartPriceLabal);
            this.Controls.Add(this.QuantityBox);
            this.Controls.Add(this.ShoppingCartBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ProductBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(652, 597);
            this.Name = "ApplicationForm";
            this.Text = "ShoppingCart";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.InformationProductPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureProduct)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ProductBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ListBox ShoppingCartBox;
        private System.Windows.Forms.TextBox QuantityBox;
        private System.Windows.Forms.Label FullCartPriceLabal;
        private System.Windows.Forms.Label ViktoryCartPriceLabal;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button CalculatButton;
        private System.Windows.Forms.Label ShookHaiirCartPriceLabal;
        private System.Windows.Forms.Label MahsaneiCartPeiceLabal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox CheapestViktoryListBox;
        private System.Windows.Forms.ListBox ExpensiveViktoryListBox;
        private System.Windows.Forms.ListBox ExpensiveMahsaneiListBox;
        private System.Windows.Forms.ListBox CheapestMahsaneiListBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListBox ExpensiveShookListBox;
        private System.Windows.Forms.ListBox CheapestShookListBox;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label CheapestLabal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label NisLabal1;
        private System.Windows.Forms.Label NisLabal2;
        private System.Windows.Forms.Label NisLabal3;
        private System.Windows.Forms.Label ProuctsLabal;
        private System.Windows.Forms.Label ShoppingCartLabal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button excelDataButton;
        private System.Windows.Forms.Label UserNameLabal;
        private System.Windows.Forms.Label UserNameText;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ComboBox UsersComboBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ToolStripMenuItem removeUserToolStripMenuItem;
        private System.Windows.Forms.Panel InformationProductPanel;
        private System.Windows.Forms.PictureBox PictureProduct;
        private System.Windows.Forms.Label ProductNameLabal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label UnitsNameLabal;
        private System.Windows.Forms.Label UnitsLabal;
        private System.Windows.Forms.ToolTip ChipestViktoryToolTip;
        private System.Windows.Forms.ToolTip ExpensiveViktoryToolTip;
        private System.Windows.Forms.ToolTip ChipestMahsaneiToolTop;
        private System.Windows.Forms.ToolTip ExpensiveMahsaneiToolTip;
        private System.Windows.Forms.ToolTip ChipestShookListToolTip;
        private System.Windows.Forms.ToolTip ExpensiveShookToolTip;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

