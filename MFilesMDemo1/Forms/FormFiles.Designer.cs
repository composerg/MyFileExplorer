using MFilesMDemo1;
using MFilesMDemo1.Properties;
using MFilesMDemo1.Theme;
namespace MFilesMDemo1.Forms
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
            this.uiSplitContainer = new Sunny.UI.UISplitContainer();
            this.tvwDirectory = new System.Windows.Forms.TreeView();
            this.lvwFiles = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.RightClickContextMenuStrip1 = new Sunny.UI.UIContextMenuStrip();
            this.剪切ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LargeImage = new System.Windows.Forms.ImageList(this.components);
            this.SmallImage = new System.Windows.Forms.ImageList(this.components);
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.btnForward = new FontAwesome.Sharp.IconButton();
            this.btnUp = new FontAwesome.Sharp.IconButton();
            this.btnRefresh = new FontAwesome.Sharp.IconButton();
            this.panelFunction = new System.Windows.Forms.TableLayoutPanel();
            this.searchBox1 = new MFilesMDemo1.MyUserControl.SearchBox();
            this.btnView = new FontAwesome.Sharp.IconButton();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.ViewContextMenuStrip = new Sunny.UI.UIContextMenuStrip();
            this.大图标ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.小图标ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.详细信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MediumImage = new System.Windows.Forms.ImageList(this.components);
            this.panelBottomOfDeaktop = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.uiSplitContainer)).BeginInit();
            this.uiSplitContainer.Panel1.SuspendLayout();
            this.uiSplitContainer.Panel2.SuspendLayout();
            this.uiSplitContainer.SuspendLayout();
            this.RightClickContextMenuStrip1.SuspendLayout();
            this.panelFunction.SuspendLayout();
            this.ViewContextMenuStrip.SuspendLayout();
            this.panelBottomOfDeaktop.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiSplitContainer
            // 
            this.uiSplitContainer.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.uiSplitContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.uiSplitContainer.BarColor = System.Drawing.Color.WhiteSmoke;
            this.uiSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiSplitContainer.HandleColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.uiSplitContainer.HandleHoverColor = System.Drawing.Color.IndianRed;
            this.uiSplitContainer.Location = new System.Drawing.Point(25, 15);
            this.uiSplitContainer.MinimumSize = new System.Drawing.Size(20, 20);
            this.uiSplitContainer.Name = "uiSplitContainer";
            // 
            // uiSplitContainer.Panel1
            // 
            this.uiSplitContainer.Panel1.Controls.Add(this.tvwDirectory);
            // 
            // uiSplitContainer.Panel2
            // 
            this.uiSplitContainer.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.uiSplitContainer.Panel2.Controls.Add(this.lvwFiles);
            this.uiSplitContainer.Size = new System.Drawing.Size(775, 343);
            this.uiSplitContainer.SplitterDistance = 258;
            this.uiSplitContainer.SplitterWidth = 11;
            this.uiSplitContainer.Style = Sunny.UI.UIStyle.Gray;
            this.uiSplitContainer.TabIndex = 1;
            this.uiSplitContainer.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // tvwDirectory
            // 
            this.tvwDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.tvwDirectory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvwDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvwDirectory.Location = new System.Drawing.Point(0, 0);
            this.tvwDirectory.Name = "tvwDirectory";
            this.tvwDirectory.Size = new System.Drawing.Size(258, 343);
            this.tvwDirectory.TabIndex = 0;
            this.tvwDirectory.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvwDirectory_NodeMouseClick);
            // 
            // lvwFiles
            // 
            this.lvwFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.lvwFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvwFiles.ContextMenuStrip = this.RightClickContextMenuStrip1;
            this.lvwFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwFiles.LargeImageList = this.LargeImage;
            this.lvwFiles.Location = new System.Drawing.Point(0, 0);
            this.lvwFiles.Name = "lvwFiles";
            this.lvwFiles.Size = new System.Drawing.Size(506, 343);
            this.lvwFiles.SmallImageList = this.SmallImage;
            this.lvwFiles.StateImageList = this.SmallImage;
            this.lvwFiles.TabIndex = 0;
            this.lvwFiles.UseCompatibleStateImageBehavior = false;
            this.lvwFiles.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "名称";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "修改日期";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "类型";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "大小";
            this.columnHeader4.Width = 50;
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
            this.btnBack.Location = new System.Drawing.Point(25, 9);
            this.btnBack.Margin = new System.Windows.Forms.Padding(25, 9, 12, 9);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(24, 24);
            this.btnBack.TabIndex = 11;
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnForward
            // 
            this.btnForward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnForward.FlatAppearance.BorderSize = 0;
            this.btnForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForward.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnForward.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.btnForward.IconColor = System.Drawing.Color.Black;
            this.btnForward.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnForward.IconSize = 18;
            this.btnForward.Location = new System.Drawing.Point(61, 9);
            this.btnForward.Margin = new System.Windows.Forms.Padding(0, 9, 12, 9);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(24, 24);
            this.btnForward.TabIndex = 12;
            this.btnForward.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnForward.UseVisualStyleBackColor = false;
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnUp.FlatAppearance.BorderSize = 0;
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUp.IconChar = FontAwesome.Sharp.IconChar.ArrowUp;
            this.btnUp.IconColor = System.Drawing.Color.Black;
            this.btnUp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUp.IconSize = 18;
            this.btnUp.Location = new System.Drawing.Point(97, 9);
            this.btnUp.Margin = new System.Windows.Forms.Padding(0, 9, 12, 9);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(24, 24);
            this.btnUp.TabIndex = 13;
            this.btnUp.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnUp.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRefresh.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.btnRefresh.IconColor = System.Drawing.Color.Black;
            this.btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRefresh.IconSize = 18;
            this.btnRefresh.Location = new System.Drawing.Point(133, 9);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(0, 9, 12, 9);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(24, 24);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // panelFunction
            // 
            this.panelFunction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.panelFunction.ColumnCount = 6;
            this.panelFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.panelFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.panelFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.panelFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.panelFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.panelFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.panelFunction.Controls.Add(this.btnBack, 0, 0);
            this.panelFunction.Controls.Add(this.btnRefresh, 3, 0);
            this.panelFunction.Controls.Add(this.btnForward, 1, 0);
            this.panelFunction.Controls.Add(this.btnUp, 2, 0);
            this.panelFunction.Controls.Add(this.searchBox1, 5, 0);
            this.panelFunction.Controls.Add(this.btnView, 4, 0);
            this.panelFunction.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFunction.Location = new System.Drawing.Point(0, 0);
            this.panelFunction.Margin = new System.Windows.Forms.Padding(0);
            this.panelFunction.Name = "panelFunction";
            this.panelFunction.RowCount = 1;
            this.panelFunction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelFunction.Size = new System.Drawing.Size(800, 42);
            this.panelFunction.TabIndex = 16;
            // 
            // searchBox1
            // 
            this.searchBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.searchBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox1.Location = new System.Drawing.Point(642, 9);
            this.searchBox1.Margin = new System.Windows.Forms.Padding(3, 9, 25, 9);
            this.searchBox1.Name = "searchBox1";
            this.searchBox1.Size = new System.Drawing.Size(133, 24);
            this.searchBox1.TabIndex = 23;
            // 
            // btnView
            // 
            this.btnView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnView.BackColor = System.Drawing.Color.White;
            this.btnView.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.ForeColor = System.Drawing.Color.Black;
            this.btnView.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnView.IconColor = System.Drawing.Color.Black;
            this.btnView.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnView.Location = new System.Drawing.Point(169, 9);
            this.btnView.Margin = new System.Windows.Forms.Padding(0, 9, 20, 9);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(76, 24);
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
            // panelBottomOfDeaktop
            // 
            this.panelBottomOfDeaktop.BackColor = System.Drawing.Color.Gainsboro;
            this.panelBottomOfDeaktop.Controls.Add(this.panelDesktop);
            this.panelBottomOfDeaktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottomOfDeaktop.Location = new System.Drawing.Point(0, 42);
            this.panelBottomOfDeaktop.Margin = new System.Windows.Forms.Padding(0);
            this.panelBottomOfDeaktop.Name = "panelBottomOfDeaktop";
            this.panelBottomOfDeaktop.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.panelBottomOfDeaktop.Size = new System.Drawing.Size(800, 385);
            this.panelBottomOfDeaktop.TabIndex = 19;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.panelDesktop.Controls.Add(this.uiSplitContainer);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 1);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Padding = new System.Windows.Forms.Padding(25, 15, 0, 25);
            this.panelDesktop.Size = new System.Drawing.Size(800, 383);
            this.panelDesktop.TabIndex = 2;
            // 
            // FormFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelBottomOfDeaktop);
            this.Controls.Add(this.panelFunction);
            this.Controls.Add(this.panelBottom);
            this.Name = "FormFiles";
            this.Text = "FormFiles";
            this.Load += new System.EventHandler(this.FormFiles_Load);
            this.uiSplitContainer.Panel1.ResumeLayout(false);
            this.uiSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiSplitContainer)).EndInit();
            this.uiSplitContainer.ResumeLayout(false);
            this.RightClickContextMenuStrip1.ResumeLayout(false);
            this.panelFunction.ResumeLayout(false);
            this.ViewContextMenuStrip.ResumeLayout(false);
            this.panelBottomOfDeaktop.ResumeLayout(false);
            this.panelDesktop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion


        private Sunny.UI.UISplitContainer uiSplitContainer;
        private FontAwesome.Sharp.IconButton btnBack;
        private FontAwesome.Sharp.IconButton btnForward;
        private FontAwesome.Sharp.IconButton btnUp;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private TableLayoutPanel panelFunction;
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
        private Panel panelBottomOfDeaktop;
        private MyUserControl.SearchBox searchBox1;
        private Panel panelDesktop;
    }
}