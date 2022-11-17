using MFilesMDemo1;
using MFilesMDemo1.Properties;
using MFilesMDemo1.Theme;
namespace MFilesMDemo2.Forms
{
    partial class FormFiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFiles));
            this.uiSplitContainer1 = new Sunny.UI.UISplitContainer();
            this.tvwDirectory = new System.Windows.Forms.TreeView();
            this.lvwFiles = new System.Windows.Forms.ListView();
            this.RightClickContextMenuStrip1 = new Sunny.UI.UIContextMenuStrip();
            this.剪切ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LargeImage = new System.Windows.Forms.ImageList(this.components);
            this.SmallImage = new System.Windows.Forms.ImageList(this.components);
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.panelFunction = new System.Windows.Forms.TableLayoutPanel();
            this.iconButton8 = new FontAwesome.Sharp.IconButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.iconButton9 = new FontAwesome.Sharp.IconButton();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.btnView = new FontAwesome.Sharp.IconButton();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.ViewContextMenuStrip = new Sunny.UI.UIContextMenuStrip();
            this.大图标ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.小图标ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.详细信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MediumImage = new System.Windows.Forms.ImageList(this.components);
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.uiSplitContainer1)).BeginInit();
            this.uiSplitContainer1.Panel1.SuspendLayout();
            this.uiSplitContainer1.Panel2.SuspendLayout();
            this.uiSplitContainer1.SuspendLayout();
            this.RightClickContextMenuStrip1.SuspendLayout();
            this.panelFunction.SuspendLayout();
            this.ViewContextMenuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiSplitContainer1
            // 
            this.uiSplitContainer1.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.uiSplitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.uiSplitContainer1.BarColor = System.Drawing.Color.WhiteSmoke;
            this.uiSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiSplitContainer1.HandleColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.uiSplitContainer1.HandleHoverColor = System.Drawing.Color.IndianRed;
            this.uiSplitContainer1.Location = new System.Drawing.Point(0, 1);
            this.uiSplitContainer1.MinimumSize = new System.Drawing.Size(20, 20);
            this.uiSplitContainer1.Name = "uiSplitContainer1";
            // 
            // uiSplitContainer1.Panel1
            // 
            this.uiSplitContainer1.Panel1.Controls.Add(this.tvwDirectory);
            // 
            // uiSplitContainer1.Panel2
            // 
            this.uiSplitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.uiSplitContainer1.Panel2.Controls.Add(this.lvwFiles);
            this.uiSplitContainer1.Size = new System.Drawing.Size(800, 383);
            this.uiSplitContainer1.SplitterDistance = 268;
            this.uiSplitContainer1.SplitterWidth = 11;
            this.uiSplitContainer1.Style = Sunny.UI.UIStyle.Gray;
            this.uiSplitContainer1.TabIndex = 1;
            this.uiSplitContainer1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // tvwDirectory
            // 
            this.tvwDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.tvwDirectory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvwDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvwDirectory.Location = new System.Drawing.Point(0, 0);
            this.tvwDirectory.Name = "tvwDirectory";
            this.tvwDirectory.Size = new System.Drawing.Size(268, 383);
            this.tvwDirectory.TabIndex = 0;
            this.tvwDirectory.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvwDirectory_NodeMouseClick);
            // 
            // lvwFiles
            // 
            this.lvwFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.lvwFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwFiles.ContextMenuStrip = this.RightClickContextMenuStrip1;
            this.lvwFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwFiles.LargeImageList = this.LargeImage;
            this.lvwFiles.Location = new System.Drawing.Point(0, 0);
            this.lvwFiles.Name = "lvwFiles";
            this.lvwFiles.Size = new System.Drawing.Size(521, 383);
            this.lvwFiles.SmallImageList = this.SmallImage;
            this.lvwFiles.StateImageList = this.SmallImage;
            this.lvwFiles.TabIndex = 0;
            this.lvwFiles.UseCompatibleStateImageBehavior = false;
            this.lvwFiles.View = System.Windows.Forms.View.Details;
            // 
            // RightClickContextMenuStrip1
            // 
            this.RightClickContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.RightClickContextMenuStrip1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RightClickContextMenuStrip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.RightClickContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.剪切ToolStripMenuItem});
            this.RightClickContextMenuStrip1.Name = "uiContextMenuStrip1";
            this.RightClickContextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            this.RightClickContextMenuStrip1.Style = Sunny.UI.UIStyle.Gray;
            this.RightClickContextMenuStrip1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // 剪切ToolStripMenuItem
            // 
            this.剪切ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件夹ToolStripMenuItem,
            this.文件ToolStripMenuItem});
            this.剪切ToolStripMenuItem.Name = "剪切ToolStripMenuItem";
            this.剪切ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.剪切ToolStripMenuItem.Text = "新建";
            // 
            // 文件夹ToolStripMenuItem
            // 
            this.文件夹ToolStripMenuItem.Name = "文件夹ToolStripMenuItem";
            this.文件夹ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.文件夹ToolStripMenuItem.Text = "文件夹";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // LargeImage
            // 
            this.LargeImage.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.LargeImage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("LargeImage.ImageStream")));
            this.LargeImage.TransparentColor = System.Drawing.Color.Transparent;
            this.LargeImage.Images.SetKeyName(0, "文件.png");
            // 
            // SmallImage
            // 
            this.SmallImage.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.SmallImage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("SmallImage.ImageStream")));
            this.SmallImage.TransparentColor = System.Drawing.Color.Transparent;
            this.SmallImage.Images.SetKeyName(0, "文件箱.png");
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btnBack.IconColor = System.Drawing.Color.Black;
            this.btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBack.IconSize = 18;
            this.btnBack.Location = new System.Drawing.Point(15, 9);
            this.btnBack.Margin = new System.Windows.Forms.Padding(15, 9, 12, 9);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(24, 24);
            this.btnBack.TabIndex = 11;
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 18;
            this.iconButton1.Location = new System.Drawing.Point(51, 9);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(0, 9, 12, 9);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(24, 24);
            this.iconButton1.TabIndex = 12;
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.ArrowUp;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 18;
            this.iconButton2.Location = new System.Drawing.Point(87, 9);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(0, 9, 12, 9);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(24, 24);
            this.iconButton2.TabIndex = 13;
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 18;
            this.iconButton3.Location = new System.Drawing.Point(123, 9);
            this.iconButton3.Margin = new System.Windows.Forms.Padding(0, 9, 12, 9);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(24, 24);
            this.iconButton3.TabIndex = 14;
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.iconButton3.UseVisualStyleBackColor = false;
            // 
            // panelFunction
            // 
            this.panelFunction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.panelFunction.ColumnCount = 12;
            this.panelFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.panelFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.panelFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.panelFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.panelFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.panelFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.panelFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.panelFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.panelFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.panelFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.panelFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.panelFunction.Controls.Add(this.btnBack, 0, 0);
            this.panelFunction.Controls.Add(this.iconButton3, 3, 0);
            this.panelFunction.Controls.Add(this.iconButton1, 1, 0);
            this.panelFunction.Controls.Add(this.iconButton2, 2, 0);
            this.panelFunction.Controls.Add(this.iconButton8, 9, 0);
            this.panelFunction.Controls.Add(this.iconButton5, 7, 0);
            this.panelFunction.Controls.Add(this.iconButton7, 8, 0);
            this.panelFunction.Controls.Add(this.iconButton9, 5, 0);
            this.panelFunction.Controls.Add(this.iconButton6, 6, 0);
            this.panelFunction.Controls.Add(this.btnView, 11, 0);
            this.panelFunction.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFunction.Location = new System.Drawing.Point(0, 0);
            this.panelFunction.Margin = new System.Windows.Forms.Padding(0);
            this.panelFunction.Name = "panelFunction";
            this.panelFunction.RowCount = 1;
            this.panelFunction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelFunction.Size = new System.Drawing.Size(800, 42);
            this.panelFunction.TabIndex = 16;
            // 
            // iconButton8
            // 
            this.iconButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.iconButton8.FlatAppearance.BorderSize = 0;
            this.iconButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton8.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton8.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iconButton8.IconColor = System.Drawing.Color.Black;
            this.iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton8.IconSize = 18;
            this.iconButton8.Location = new System.Drawing.Point(383, 9);
            this.iconButton8.Margin = new System.Windows.Forms.Padding(0, 9, 12, 9);
            this.iconButton8.Name = "iconButton8";
            this.iconButton8.Size = new System.Drawing.Size(24, 24);
            this.iconButton8.TabIndex = 20;
            this.iconButton8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.iconButton8.UseVisualStyleBackColor = false;
            // 
            // iconButton5
            // 
            this.iconButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.StickyNote;
            this.iconButton5.IconColor = System.Drawing.Color.Black;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 18;
            this.iconButton5.Location = new System.Drawing.Point(311, 9);
            this.iconButton5.Margin = new System.Windows.Forms.Padding(0, 9, 12, 9);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(24, 24);
            this.iconButton5.TabIndex = 18;
            this.iconButton5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.iconButton5.UseVisualStyleBackColor = false;
            // 
            // iconButton7
            // 
            this.iconButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.iconButton7.FlatAppearance.BorderSize = 0;
            this.iconButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton7.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton7.IconChar = FontAwesome.Sharp.IconChar.Repeat;
            this.iconButton7.IconColor = System.Drawing.Color.Black;
            this.iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton7.IconSize = 18;
            this.iconButton7.Location = new System.Drawing.Point(347, 9);
            this.iconButton7.Margin = new System.Windows.Forms.Padding(0, 9, 12, 9);
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.Size = new System.Drawing.Size(24, 24);
            this.iconButton7.TabIndex = 19;
            this.iconButton7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.iconButton7.UseVisualStyleBackColor = false;
            // 
            // iconButton9
            // 
            this.iconButton9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.iconButton9.FlatAppearance.BorderSize = 0;
            this.iconButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton9.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton9.IconChar = FontAwesome.Sharp.IconChar.Scissors;
            this.iconButton9.IconColor = System.Drawing.Color.Black;
            this.iconButton9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton9.IconSize = 18;
            this.iconButton9.Location = new System.Drawing.Point(239, 9);
            this.iconButton9.Margin = new System.Windows.Forms.Padding(0, 9, 12, 9);
            this.iconButton9.Name = "iconButton9";
            this.iconButton9.Size = new System.Drawing.Size(24, 24);
            this.iconButton9.TabIndex = 21;
            this.iconButton9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.iconButton9.UseVisualStyleBackColor = false;
            // 
            // iconButton6
            // 
            this.iconButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.iconButton6.FlatAppearance.BorderSize = 0;
            this.iconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton6.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.Copy;
            this.iconButton6.IconColor = System.Drawing.Color.Black;
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.IconSize = 18;
            this.iconButton6.Location = new System.Drawing.Point(275, 9);
            this.iconButton6.Margin = new System.Windows.Forms.Padding(0, 9, 12, 9);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Size = new System.Drawing.Size(24, 24);
            this.iconButton6.TabIndex = 17;
            this.iconButton6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.iconButton6.UseVisualStyleBackColor = false;
            // 
            // btnView
            // 
            this.btnView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnView.BackColor = System.Drawing.Color.White;
            this.btnView.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.ForeColor = System.Drawing.Color.Black;
            this.btnView.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnView.IconColor = System.Drawing.Color.Black;
            this.btnView.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnView.Location = new System.Drawing.Point(703, 9);
            this.btnView.Margin = new System.Windows.Forms.Padding(0, 9, 20, 9);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(77, 24);
            this.btnView.TabIndex = 22;
            this.btnView.Text = "查看";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 427);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(800, 23);
            this.panelBottom.TabIndex = 18;
            // 
            // ViewContextMenuStrip
            // 
            this.ViewContextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ViewContextMenuStrip.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ViewContextMenuStrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ViewContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.大图标ToolStripMenuItem,
            this.小图标ToolStripMenuItem,
            this.列表ToolStripMenuItem,
            this.详细信息ToolStripMenuItem});
            this.ViewContextMenuStrip.Name = "ViewContextMenuStrip";
            this.ViewContextMenuStrip.Size = new System.Drawing.Size(125, 92);
            this.ViewContextMenuStrip.Style = Sunny.UI.UIStyle.Gray;
            this.ViewContextMenuStrip.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // 大图标ToolStripMenuItem
            // 
            this.大图标ToolStripMenuItem.Name = "大图标ToolStripMenuItem";
            this.大图标ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.大图标ToolStripMenuItem.Text = "大图标";
            this.大图标ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripLargeMenuItem_Click);
            // 
            // 小图标ToolStripMenuItem
            // 
            this.小图标ToolStripMenuItem.Name = "小图标ToolStripMenuItem";
            this.小图标ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.小图标ToolStripMenuItem.Text = "小图标";
            this.小图标ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripSmallMenuItem_Click);
            // 
            // 列表ToolStripMenuItem
            // 
            this.列表ToolStripMenuItem.Name = "列表ToolStripMenuItem";
            this.列表ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.列表ToolStripMenuItem.Text = "列表";
            this.列表ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripListMenuItem_Click);
            // 
            // 详细信息ToolStripMenuItem
            // 
            this.详细信息ToolStripMenuItem.Name = "详细信息ToolStripMenuItem";
            this.详细信息ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.详细信息ToolStripMenuItem.Text = "详细信息";
            this.详细信息ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripDetailsMenuItem_Click);
            // 
            // MediumImage
            // 
            this.MediumImage.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.MediumImage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("MediumImage.ImageStream")));
            this.MediumImage.TransparentColor = System.Drawing.Color.Transparent;
            this.MediumImage.Images.SetKeyName(0, "文件下载.png");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.uiSplitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 42);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.panel1.Size = new System.Drawing.Size(800, 385);
            this.panel1.TabIndex = 19;
            // 
            // FormFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelFunction);
            this.Controls.Add(this.panelBottom);
            this.Name = "FormFiles";
            this.Text = "FormFiles";
            this.Load += new System.EventHandler(this.FormFiles_Load);
            this.uiSplitContainer1.Panel1.ResumeLayout(false);
            this.uiSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiSplitContainer1)).EndInit();
            this.uiSplitContainer1.ResumeLayout(false);
            this.RightClickContextMenuStrip1.ResumeLayout(false);
            this.panelFunction.ResumeLayout(false);
            this.ViewContextMenuStrip.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion


        private Sunny.UI.UISplitContainer uiSplitContainer1;
        private FontAwesome.Sharp.IconButton btnBack;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private TableLayoutPanel panelFunction;
        private FontAwesome.Sharp.IconButton iconButton8;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton7;
        private FontAwesome.Sharp.IconButton iconButton9;
        private FontAwesome.Sharp.IconButton iconButton6;
        private Panel panelBottom;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ImageList ilstIcons;
        private TreeView tvwDirectory;
        private ListView lvwFiles;
        private ImageList LargeImage;
        private Sunny.UI.UIContextMenuStrip RightClickContextMenuStrip1;
        private ToolStripMenuItem 剪切ToolStripMenuItem;
        private ToolStripMenuItem 文件夹ToolStripMenuItem;
        private ToolStripMenuItem 文件ToolStripMenuItem;
        private FontAwesome.Sharp.IconButton btnView;
        private Sunny.UI.UIContextMenuStrip ViewContextMenuStrip;
        private ToolStripMenuItem 大图标ToolStripMenuItem;
        private ToolStripMenuItem 小图标ToolStripMenuItem;
        private ToolStripMenuItem 列表ToolStripMenuItem;
        private ToolStripMenuItem 详细信息ToolStripMenuItem;
        private ImageList SmallImage;
        private ImageList MediumImage;
        private Panel panel1;
    }
}