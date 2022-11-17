using MFilesMDemo1.Theme;
namespace MFilesMDemo1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.btnFiles = new FontAwesome.Sharp.IconButton();
            this.btnTask = new FontAwesome.Sharp.IconButton();
            this.btnDev = new FontAwesome.Sharp.IconButton();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.uiTableLayoutPanel1 = new Sunny.UI.UITableLayoutPanel();
            this.IconPicture = new System.Windows.Forms.PictureBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.userIDlabel = new System.Windows.Forms.Label();
            this.UserPicture = new System.Windows.Forms.PictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.uiTableLayoutPanel2 = new Sunny.UI.UITableLayoutPanel();
            this.btnRecent = new FontAwesome.Sharp.IconButton();
            this.btnSetting = new FontAwesome.Sharp.IconButton();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.panelBottomOfTop = new System.Windows.Forms.Panel();
            this.panelDesktop = new Sunny.UI.UIPanel();
            this.panelTitle.SuspendLayout();
            this.uiTableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicture)).BeginInit();
            this.panelTop.SuspendLayout();
            this.uiTableLayoutPanel2.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.panelBottomOfTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMenu.ForeColor = System.Drawing.Color.Black;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.ListDots;
            this.btnMenu.IconColor = System.Drawing.Color.DimGray;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.IconSize = 24;
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnMenu.Size = new System.Drawing.Size(120, 42);
            this.btnMenu.TabIndex = 6;
            this.btnMenu.Text = "   主菜单";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.HouseChimney;
            this.btnHome.IconColor = System.Drawing.Color.DimGray;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 24;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 80);
            this.btnHome.Margin = new System.Windows.Forms.Padding(0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(120, 42);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "   我的应用";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnFiles
            // 
            this.btnFiles.FlatAppearance.BorderSize = 0;
            this.btnFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiles.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFiles.ForeColor = System.Drawing.Color.Black;
            this.btnFiles.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.btnFiles.IconColor = System.Drawing.Color.DimGray;
            this.btnFiles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFiles.IconSize = 24;
            this.btnFiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiles.Location = new System.Drawing.Point(0, 120);
            this.btnFiles.Margin = new System.Windows.Forms.Padding(0);
            this.btnFiles.Name = "btnFiles";
            this.btnFiles.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnFiles.Size = new System.Drawing.Size(120, 42);
            this.btnFiles.TabIndex = 1;
            this.btnFiles.Text = "   文件管理";
            this.btnFiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFiles.UseVisualStyleBackColor = true;
            this.btnFiles.Click += new System.EventHandler(this.btnFiles_Click);
            // 
            // btnTask
            // 
            this.btnTask.FlatAppearance.BorderSize = 0;
            this.btnTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTask.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTask.ForeColor = System.Drawing.Color.Black;
            this.btnTask.IconChar = FontAwesome.Sharp.IconChar.TasksAlt;
            this.btnTask.IconColor = System.Drawing.Color.DimGray;
            this.btnTask.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTask.IconSize = 24;
            this.btnTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTask.Location = new System.Drawing.Point(0, 160);
            this.btnTask.Margin = new System.Windows.Forms.Padding(0);
            this.btnTask.Name = "btnTask";
            this.btnTask.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnTask.Size = new System.Drawing.Size(120, 42);
            this.btnTask.TabIndex = 2;
            this.btnTask.Text = "   任务管理";
            this.btnTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTask.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTask.UseVisualStyleBackColor = true;
            this.btnTask.Click += new System.EventHandler(this.btnTask_Click);
            // 
            // btnDev
            // 
            this.btnDev.FlatAppearance.BorderSize = 0;
            this.btnDev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDev.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDev.ForeColor = System.Drawing.Color.Black;
            this.btnDev.IconChar = FontAwesome.Sharp.IconChar.TabletAlt;
            this.btnDev.IconColor = System.Drawing.Color.DimGray;
            this.btnDev.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDev.IconSize = 24;
            this.btnDev.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDev.Location = new System.Drawing.Point(0, 200);
            this.btnDev.Margin = new System.Windows.Forms.Padding(0);
            this.btnDev.Name = "btnDev";
            this.btnDev.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnDev.Size = new System.Drawing.Size(120, 42);
            this.btnDev.TabIndex = 3;
            this.btnDev.Text = "   设备管理";
            this.btnDev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDev.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDev.UseVisualStyleBackColor = true;
            this.btnDev.Click += new System.EventHandler(this.btnDev_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.panelTitle.Controls.Add(this.uiTableLayoutPanel1);
            this.panelTitle.Controls.Add(this.btnClose);
            this.panelTitle.Controls.Add(this.btnMaximize);
            this.panelTitle.Controls.Add(this.btnMinimize);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(2, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1020, 30);
            this.panelTitle.TabIndex = 1;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // uiTableLayoutPanel1
            // 
            this.uiTableLayoutPanel1.ColumnCount = 2;
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTableLayoutPanel1.Controls.Add(this.IconPicture, 0, 0);
            this.uiTableLayoutPanel1.Controls.Add(this.uiLabel1, 1, 0);
            this.uiTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiTableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiTableLayoutPanel1.Name = "uiTableLayoutPanel1";
            this.uiTableLayoutPanel1.RowCount = 1;
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.uiTableLayoutPanel1.Size = new System.Drawing.Size(200, 30);
            this.uiTableLayoutPanel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiTableLayoutPanel1.TabIndex = 14;
            this.uiTableLayoutPanel1.TagString = null;
            // 
            // IconPicture
            // 
            this.IconPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IconPicture.BackgroundImage")));
            this.IconPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.IconPicture.Location = new System.Drawing.Point(0, 3);
            this.IconPicture.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.IconPicture.Name = "IconPicture";
            this.IconPicture.Size = new System.Drawing.Size(24, 24);
            this.IconPicture.TabIndex = 0;
            this.IconPicture.TabStop = false;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel1.Location = new System.Drawing.Point(27, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(170, 30);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "应用资源管理器";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 13;
            this.btnClose.Location = new System.Drawing.Point(988, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 13;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.ForeColor = System.Drawing.Color.Transparent;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btnMaximize.IconColor = System.Drawing.Color.Black;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 13;
            this.btnMaximize.Location = new System.Drawing.Point(957, 4);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(20, 20);
            this.btnMaximize.TabIndex = 12;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinimize.IconColor = System.Drawing.Color.Black;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 13;
            this.btnMinimize.Location = new System.Drawing.Point(926, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 20);
            this.btnMinimize.TabIndex = 11;
            this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // userIDlabel
            // 
            this.userIDlabel.AutoSize = true;
            this.userIDlabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userIDlabel.Location = new System.Drawing.Point(39, 0);
            this.userIDlabel.Name = "userIDlabel";
            this.userIDlabel.Size = new System.Drawing.Size(158, 40);
            this.userIDlabel.TabIndex = 8;
            this.userIDlabel.Text = "ID: client_app_01";
            this.userIDlabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserPicture
            // 
            this.UserPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UserPicture.BackgroundImage")));
            this.UserPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UserPicture.Location = new System.Drawing.Point(3, 5);
            this.UserPicture.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.UserPicture.Name = "UserPicture";
            this.UserPicture.Size = new System.Drawing.Size(30, 29);
            this.UserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserPicture.TabIndex = 7;
            this.UserPicture.TabStop = false;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.panelTop.Controls.Add(this.uiTableLayoutPanel2);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1020, 40);
            this.panelTop.TabIndex = 5;
            // 
            // uiTableLayoutPanel2
            // 
            this.uiTableLayoutPanel2.ColumnCount = 2;
            this.uiTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.uiTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTableLayoutPanel2.Controls.Add(this.UserPicture, 0, 0);
            this.uiTableLayoutPanel2.Controls.Add(this.userIDlabel, 1, 0);
            this.uiTableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiTableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.uiTableLayoutPanel2.Name = "uiTableLayoutPanel2";
            this.uiTableLayoutPanel2.RowCount = 1;
            this.uiTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTableLayoutPanel2.Size = new System.Drawing.Size(200, 40);
            this.uiTableLayoutPanel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiTableLayoutPanel2.TabIndex = 9;
            this.uiTableLayoutPanel2.TagString = null;
            // 
            // btnRecent
            // 
            this.btnRecent.FlatAppearance.BorderSize = 0;
            this.btnRecent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecent.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRecent.ForeColor = System.Drawing.Color.Black;
            this.btnRecent.IconChar = FontAwesome.Sharp.IconChar.Shopify;
            this.btnRecent.IconColor = System.Drawing.Color.DimGray;
            this.btnRecent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRecent.IconSize = 24;
            this.btnRecent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecent.Location = new System.Drawing.Point(0, 40);
            this.btnRecent.Margin = new System.Windows.Forms.Padding(0);
            this.btnRecent.Name = "btnRecent";
            this.btnRecent.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnRecent.Size = new System.Drawing.Size(120, 42);
            this.btnRecent.TabIndex = 8;
            this.btnRecent.Text = "   最近访问";
            this.btnRecent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRecent.UseVisualStyleBackColor = true;
            this.btnRecent.Click += new System.EventHandler(this.btnRecent_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.AutoSize = true;
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSetting.ForeColor = System.Drawing.Color.Black;
            this.btnSetting.IconChar = FontAwesome.Sharp.IconChar.Sliders;
            this.btnSetting.IconColor = System.Drawing.Color.DimGray;
            this.btnSetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSetting.IconSize = 24;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(0, 605);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(0);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnSetting.Size = new System.Drawing.Size(42, 42);
            this.btnSetting.TabIndex = 7;
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting.UseVisualStyleBackColor = true;
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.panelSidebar.Controls.Add(this.btnDev);
            this.panelSidebar.Controls.Add(this.btnTask);
            this.panelSidebar.Controls.Add(this.btnFiles);
            this.panelSidebar.Controls.Add(this.btnHome);
            this.panelSidebar.Controls.Add(this.btnRecent);
            this.panelSidebar.Controls.Add(this.btnMenu);
            this.panelSidebar.Controls.Add(this.btnSetting);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelSidebar.Location = new System.Drawing.Point(2, 71);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSidebar.MaximumSize = new System.Drawing.Size(120, 2000);
            this.panelSidebar.MinimumSize = new System.Drawing.Size(42, 613);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(42, 647);
            this.panelSidebar.TabIndex = 6;
            // 
            // panelBottomOfTop
            // 
            this.panelBottomOfTop.BackColor = System.Drawing.Color.Gainsboro;
            this.panelBottomOfTop.Controls.Add(this.panelTop);
            this.panelBottomOfTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBottomOfTop.Location = new System.Drawing.Point(2, 30);
            this.panelBottomOfTop.Margin = new System.Windows.Forms.Padding(0);
            this.panelBottomOfTop.Name = "panelBottomOfTop";
            this.panelBottomOfTop.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.panelBottomOfTop.Size = new System.Drawing.Size(1020, 41);
            this.panelBottomOfTop.TabIndex = 8;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.Gainsboro;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.FillColor = System.Drawing.Color.Gainsboro;
            this.panelDesktop.FillColor2 = System.Drawing.Color.Gainsboro;
            this.panelDesktop.FillDisableColor = System.Drawing.Color.Gainsboro;
            this.panelDesktop.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelDesktop.Location = new System.Drawing.Point(44, 71);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(0);
            this.panelDesktop.MinimumSize = new System.Drawing.Size(1, 1);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.panelDesktop.RectColor = System.Drawing.Color.Gainsboro;
            this.panelDesktop.Size = new System.Drawing.Size(978, 647);
            this.panelDesktop.Style = Sunny.UI.UIStyle.Custom;
            this.panelDesktop.TabIndex = 9;
            this.panelDesktop.Text = null;
            this.panelDesktop.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.panelDesktop.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // MainForm
            // 
            this.AllowShowTitle = false;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1024, 720);
            this.ControlBoxFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelBottomOfTop);
            this.Controls.Add(this.panelTitle);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.ShowDragStretch = true;
            this.ShowRadius = false;
            this.ShowShadow = true;
            this.ShowTitle = false;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.ZoomScaleDisabled = true;
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 1044, 683);
            this.panelTitle.ResumeLayout(false);
            this.uiTableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicture)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.uiTableLayoutPanel2.ResumeLayout(false);
            this.uiTableLayoutPanel2.PerformLayout();
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.panelBottomOfTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton btnFiles;
        private FontAwesome.Sharp.IconButton btnTask;
        private FontAwesome.Sharp.IconButton btnDev;
        private FontAwesome.Sharp.IconButton btnMenu;
        private Panel panelTitle;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel1;
        private PictureBox IconPicture;
        private Sunny.UI.UILabel uiLabel1;
        private Label userIDlabel;
        private PictureBox UserPicture;
        private Panel panelTop;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel2;
        private FontAwesome.Sharp.IconButton btnSetting;
        private FontAwesome.Sharp.IconButton btnRecent;
        private Panel panelSidebar;
        private Panel panelBottomOfTop;
        private Sunny.UI.UIPanel panelDesktop;
    }
}