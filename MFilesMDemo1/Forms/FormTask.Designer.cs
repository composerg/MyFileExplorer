namespace MFilesMDemo1.Forms
{
    partial class FormTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTask));
            this.btnRefresh = new FontAwesome.Sharp.IconButton();
            this.btnFinish = new FontAwesome.Sharp.IconButton();
            this.panelFunction = new System.Windows.Forms.TableLayoutPanel();
            this.SearchBox = new MFilesMDemo1.MyUserControl.SearchBox();
            this.lblCurProcessNum = new System.Windows.Forms.Label();
            this.txtCurProcessNum = new System.Windows.Forms.TextBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelBottonOfListView = new System.Windows.Forms.Panel();
            this.lvwProcess = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelFunction.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.panelBottonOfListView.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRefresh.IconColor = System.Drawing.Color.Black;
            this.btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRefresh.Location = new System.Drawing.Point(139, 9);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(0, 9, 15, 9);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(69, 24);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnFinish
            // 
            this.btnFinish.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnFinish.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.btnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinish.ForeColor = System.Drawing.Color.Black;
            this.btnFinish.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnFinish.IconColor = System.Drawing.Color.Black;
            this.btnFinish.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFinish.Location = new System.Drawing.Point(225, 9);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(0, 9, 15, 9);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(85, 24);
            this.btnFinish.TabIndex = 13;
            this.btnFinish.Text = "结束进程";
            this.btnFinish.UseVisualStyleBackColor = false;
            // 
            // panelFunction
            // 
            this.panelFunction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.panelFunction.ColumnCount = 5;
            this.panelFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.panelFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.panelFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.panelFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 475F));
            this.panelFunction.Controls.Add(this.SearchBox, 4, 0);
            this.panelFunction.Controls.Add(this.btnFinish, 3, 0);
            this.panelFunction.Controls.Add(this.btnRefresh, 2, 0);
            this.panelFunction.Controls.Add(this.lblCurProcessNum, 0, 0);
            this.panelFunction.Controls.Add(this.txtCurProcessNum, 1, 0);
            this.panelFunction.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFunction.Location = new System.Drawing.Point(0, 0);
            this.panelFunction.Name = "panelFunction";
            this.panelFunction.RowCount = 1;
            this.panelFunction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelFunction.Size = new System.Drawing.Size(800, 42);
            this.panelFunction.TabIndex = 14;
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchBox.Location = new System.Drawing.Point(642, 9);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(3, 9, 25, 9);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(133, 24);
            this.SearchBox.TabIndex = 18;
            // 
            // lblCurProcessNum
            // 
            this.lblCurProcessNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCurProcessNum.AutoSize = true;
            this.lblCurProcessNum.Location = new System.Drawing.Point(25, 13);
            this.lblCurProcessNum.Margin = new System.Windows.Forms.Padding(25, 13, 0, 13);
            this.lblCurProcessNum.Name = "lblCurProcessNum";
            this.lblCurProcessNum.Size = new System.Drawing.Size(71, 16);
            this.lblCurProcessNum.TabIndex = 14;
            this.lblCurProcessNum.Text = "当前应用数:";
            // 
            // txtCurProcessNum
            // 
            this.txtCurProcessNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.txtCurProcessNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCurProcessNum.Location = new System.Drawing.Point(99, 13);
            this.txtCurProcessNum.Margin = new System.Windows.Forms.Padding(0, 13, 0, 13);
            this.txtCurProcessNum.Name = "txtCurProcessNum";
            this.txtCurProcessNum.Size = new System.Drawing.Size(40, 16);
            this.txtCurProcessNum.TabIndex = 15;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.Gainsboro;
            this.panelDesktop.Controls.Add(this.panelBottonOfListView);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 42);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.panelDesktop.Size = new System.Drawing.Size(800, 408);
            this.panelDesktop.TabIndex = 15;
            // 
            // panelBottonOfListView
            // 
            this.panelBottonOfListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.panelBottonOfListView.Controls.Add(this.lvwProcess);
            this.panelBottonOfListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottonOfListView.Location = new System.Drawing.Point(0, 1);
            this.panelBottonOfListView.Margin = new System.Windows.Forms.Padding(0);
            this.panelBottonOfListView.Name = "panelBottonOfListView";
            this.panelBottonOfListView.Padding = new System.Windows.Forms.Padding(25, 15, 25, 0);
            this.panelBottonOfListView.Size = new System.Drawing.Size(800, 407);
            this.panelBottonOfListView.TabIndex = 1;
            // 
            // lvwProcess
            // 
            this.lvwProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lvwProcess.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwProcess.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvwProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwProcess.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvwProcess.FullRowSelect = true;
            this.lvwProcess.Location = new System.Drawing.Point(25, 15);
            this.lvwProcess.Name = "lvwProcess";
            this.lvwProcess.Size = new System.Drawing.Size(750, 392);
            this.lvwProcess.TabIndex = 0;
            this.lvwProcess.UseCompatibleStateImageBehavior = false;
            this.lvwProcess.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "进程名称";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "进程ID";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "专用内存大小";
            this.columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "虚拟内存大小";
            this.columnHeader4.Width = 110;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "启动时间";
            this.columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "基本优先级";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "路径";
            this.columnHeader7.Width = 250;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "消息.png");
            // 
            // FormTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelFunction);
            this.Name = "FormTask";
            this.Text = "FormTask";
            this.Load += new System.EventHandler(this.ProcessForm_Load);
            this.panelFunction.ResumeLayout(false);
            this.panelFunction.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.panelBottonOfListView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnRefresh;
        private FontAwesome.Sharp.IconButton btnFinish;
        private TableLayoutPanel panelFunction;
        private Label lblCurProcessNum;
        private Panel panelDesktop;
        private ListView lvwProcess;
        private TextBox txtCurProcessNum;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ImageList ilstIcons;
        private ImageList imageList1;
        private MyUserControl.SearchBox SearchBox;
        private Panel panelBottonOfListView;
    }
}