namespace MFilesMDemo1.Forms
{
    partial class FormRecent
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
            this.panelFunction = new Sunny.UI.UITableLayoutPanel();
            this.SearchBox = new MFilesMDemo1.MyUserControl.SearchBox();
            this.panelBottonOfDesktop = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.listRecentFiles = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.lineRecentFiles = new Sunny.UI.UILine();
            this.panelFunction.SuspendLayout();
            this.panelBottonOfDesktop.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFunction
            // 
            this.panelFunction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.panelFunction.ColumnCount = 7;
            this.panelFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.panelFunction.Controls.Add(this.SearchBox, 6, 0);
            this.panelFunction.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFunction.Location = new System.Drawing.Point(0, 0);
            this.panelFunction.Name = "panelFunction";
            this.panelFunction.RowCount = 1;
            this.panelFunction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelFunction.Size = new System.Drawing.Size(800, 42);
            this.panelFunction.TabIndex = 12;
            this.panelFunction.TagString = null;
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
            this.SearchBox.TabIndex = 17;
            // 
            // panelBottonOfDesktop
            // 
            this.panelBottonOfDesktop.BackColor = System.Drawing.Color.Gainsboro;
            this.panelBottonOfDesktop.Controls.Add(this.panelDesktop);
            this.panelBottonOfDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottonOfDesktop.Location = new System.Drawing.Point(0, 42);
            this.panelBottonOfDesktop.Margin = new System.Windows.Forms.Padding(0);
            this.panelBottonOfDesktop.Name = "panelBottonOfDesktop";
            this.panelBottonOfDesktop.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.panelBottonOfDesktop.Size = new System.Drawing.Size(800, 408);
            this.panelBottonOfDesktop.TabIndex = 13;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.panelDesktop.Controls.Add(this.listRecentFiles);
            this.panelDesktop.Controls.Add(this.lineRecentFiles);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 1);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Padding = new System.Windows.Forms.Padding(25, 15, 25, 0);
            this.panelDesktop.Size = new System.Drawing.Size(800, 407);
            this.panelDesktop.TabIndex = 2;
            // 
            // listRecentFiles
            // 
            this.listRecentFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.listRecentFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listRecentFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listRecentFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.listRecentFiles.Location = new System.Drawing.Point(25, 44);
            this.listRecentFiles.Name = "listRecentFiles";
            this.listRecentFiles.Size = new System.Drawing.Size(750, 183);
            this.listRecentFiles.TabIndex = 1;
            this.listRecentFiles.UseCompatibleStateImageBehavior = false;
            this.listRecentFiles.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "名称";
            this.columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "修改日期";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "类型";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "大小";
            this.columnHeader4.Width = 150;
            // 
            // lineRecentFiles
            // 
            this.lineRecentFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.lineRecentFiles.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.lineRecentFiles.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lineRecentFiles.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.lineRecentFiles.Location = new System.Drawing.Point(25, 15);
            this.lineRecentFiles.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.lineRecentFiles.MinimumSize = new System.Drawing.Size(1, 1);
            this.lineRecentFiles.Name = "lineRecentFiles";
            this.lineRecentFiles.Size = new System.Drawing.Size(750, 29);
            this.lineRecentFiles.Style = Sunny.UI.UIStyle.Gray;
            this.lineRecentFiles.TabIndex = 0;
            this.lineRecentFiles.Text = "最近访问的文件";
            this.lineRecentFiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lineRecentFiles.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // FormRecent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelBottonOfDesktop);
            this.Controls.Add(this.panelFunction);
            this.Name = "FormRecent";
            this.Text = "FormRelate";
            this.panelFunction.ResumeLayout(false);
            this.panelBottonOfDesktop.ResumeLayout(false);
            this.panelDesktop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITableLayoutPanel panelFunction;
        private MyUserControl.SearchBox SearchBox;
        private Panel panelBottonOfDesktop;
        private Panel panelDesktop;
        private Sunny.UI.UILine lineRecentFiles;
        private ListView listRecentFiles;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}