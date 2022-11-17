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
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.uiTableLayoutPanel1 = new Sunny.UI.UITableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.uiTableLayoutPanel2 = new Sunny.UI.UITableLayoutPanel();
            this.panelSidebar = new Sunny.UI.UIPanel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.panelTitle.SuspendLayout();
            this.uiTableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTop.SuspendLayout();
            this.uiTableLayoutPanel2.SuspendLayout();
            this.panelSidebar.SuspendLayout();
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
            this.btnMenu.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnMenu.Size = new System.Drawing.Size(120, 40);
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
            this.btnHome.Location = new System.Drawing.Point(0, 83);
            this.btnHome.Margin = new System.Windows.Forms.Padding(0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(120, 40);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "         我的应用";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnFiles.Location = new System.Drawing.Point(0, 123);
            this.btnFiles.Margin = new System.Windows.Forms.Padding(0);
            this.btnFiles.Name = "btnFiles";
            this.btnFiles.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnFiles.Size = new System.Drawing.Size(120, 40);
            this.btnFiles.TabIndex = 1;
            this.btnFiles.Text = "         文件管理";
            this.btnFiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnTask.Location = new System.Drawing.Point(0, 163);
            this.btnTask.Margin = new System.Windows.Forms.Padding(0);
            this.btnTask.Name = "btnTask";
            this.btnTask.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnTask.Size = new System.Drawing.Size(120, 40);
            this.btnTask.TabIndex = 2;
            this.btnTask.Text = "         任务管理";
            this.btnTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnDev.Location = new System.Drawing.Point(0, 203);
            this.btnDev.Margin = new System.Windows.Forms.Padding(0);
            this.btnDev.Name = "btnDev";
            this.btnDev.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnDev.Size = new System.Drawing.Size(120, 40);
            this.btnDev.TabIndex = 3;
            this.btnDev.Text = "         设备管理";
            this.btnDev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDev.UseVisualStyleBackColor = true;
            this.btnDev.Click += new System.EventHandler(this.btnDev_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(0, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(75, 23);
            this.iconButton1.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.Gainsboro;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(120, 70);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Padding = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.panelDesktop.Size = new System.Drawing.Size(924, 613);
            this.panelDesktop.TabIndex = 4;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.panelTitle.Controls.Add(this.uiTableLayoutPanel1);
            this.panelTitle.Controls.Add(this.btnClose);
            this.panelTitle.Controls.Add(this.btnMaximize);
            this.panelTitle.Controls.Add(this.btnMinimize);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1044, 30);
            this.panelTitle.TabIndex = 1;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // uiTableLayoutPanel1
            // 
            this.uiTableLayoutPanel1.ColumnCount = 2;
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTableLayoutPanel1.Controls.Add(this.pictureBox2, 0, 0);
            this.uiTableLayoutPanel1.Controls.Add(this.uiLabel1, 1, 0);
            this.uiTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiTableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiTableLayoutPanel1.Name = "uiTableLayoutPanel1";
            this.uiTableLayoutPanel1.RowCount = 1;
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.uiTableLayoutPanel1.Size = new System.Drawing.Size(200, 30);
            this.uiTableLayoutPanel1.TabIndex = 14;
            this.uiTableLayoutPanel1.TagString = null;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(0, 3);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel1.Location = new System.Drawing.Point(27, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(170, 30);
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
            this.btnClose.Location = new System.Drawing.Point(1012, 4);
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
            this.btnMaximize.Location = new System.Drawing.Point(981, 4);
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
            this.btnMinimize.Location = new System.Drawing.Point(950, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 20);
            this.btnMinimize.TabIndex = 11;
            this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(39, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID: client_app_01";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.panelTop.Controls.Add(this.uiTableLayoutPanel2);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 30);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1044, 40);
            this.panelTop.TabIndex = 5;
            // 
            // uiTableLayoutPanel2
            // 
            this.uiTableLayoutPanel2.ColumnCount = 2;
            this.uiTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.uiTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 0);
            this.uiTableLayoutPanel2.Controls.Add(this.label1, 1, 0);
            this.uiTableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiTableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.uiTableLayoutPanel2.Name = "uiTableLayoutPanel2";
            this.uiTableLayoutPanel2.RowCount = 1;
            this.uiTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTableLayoutPanel2.Size = new System.Drawing.Size(200, 40);
            this.uiTableLayoutPanel2.TabIndex = 9;
            this.uiTableLayoutPanel2.TagString = null;
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.panelSidebar.Controls.Add(this.iconButton3);
            this.panelSidebar.Controls.Add(this.iconButton2);
            this.panelSidebar.Controls.Add(this.btnHome);
            this.panelSidebar.Controls.Add(this.btnMenu);
            this.panelSidebar.Controls.Add(this.btnFiles);
            this.panelSidebar.Controls.Add(this.btnDev);
            this.panelSidebar.Controls.Add(this.btnTask);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.panelSidebar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.panelSidebar.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelSidebar.Location = new System.Drawing.Point(0, 70);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSidebar.MaximumSize = new System.Drawing.Size(120, 2000);
            this.panelSidebar.MinimumSize = new System.Drawing.Size(42, 613);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.panelSidebar.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.panelSidebar.Size = new System.Drawing.Size(120, 613);
            this.panelSidebar.Style = Sunny.UI.UIStyle.Custom;
            this.panelSidebar.TabIndex = 6;
            this.panelSidebar.Text = null;
            this.panelSidebar.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.panelSidebar.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // iconButton2
            // 
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton2.ForeColor = System.Drawing.Color.Black;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Sliders;
            this.iconButton2.IconColor = System.Drawing.Color.DimGray;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 24;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 573);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.iconButton2.Size = new System.Drawing.Size(120, 40);
            this.iconButton2.TabIndex = 7;
            this.iconButton2.Text = "         系统设置";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton3
            // 
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton3.ForeColor = System.Drawing.Color.Black;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.TabletAlt;
            this.iconButton3.IconColor = System.Drawing.Color.DimGray;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 24;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(0, 43);
            this.iconButton3.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.iconButton3.Size = new System.Drawing.Size(120, 40);
            this.iconButton3.TabIndex = 8;
            this.iconButton3.Text = "         最近访问";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1044, 683);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.iconButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainForm";
            this.panelTitle.ResumeLayout(false);
            this.uiTableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.uiTableLayoutPanel2.ResumeLayout(false);
            this.uiTableLayoutPanel2.PerformLayout();
            this.panelSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton btnFiles;
        private FontAwesome.Sharp.IconButton btnTask;
        private FontAwesome.Sharp.IconButton btnDev;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnMenu;
        private Panel panelDesktop;
        private Panel panelTitle;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel1;
        private PictureBox pictureBox2;
        private Sunny.UI.UILabel uiLabel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panelTop;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel2;
        private Sunny.UI.UIPanel panelSidebar;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
    }
}