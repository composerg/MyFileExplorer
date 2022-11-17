namespace MFilesMDemo1.Forms
{
    partial class FormDevice
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
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelPrinterList = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPrinter1 = new FontAwesome.Sharp.IconButton();
            this.btnPrinter2 = new FontAwesome.Sharp.IconButton();
            this.panelFunction = new Sunny.UI.UITableLayoutPanel();
            this.SearchBox = new MFilesMDemo1.MyUserControl.SearchBox();
            this.panelBottonOfDesktop = new System.Windows.Forms.Panel();
            this.panelAddDevice = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddDevice = new FontAwesome.Sharp.IconButton();
            this.labelAddDevice = new System.Windows.Forms.Label();
            this.panelDesktop.SuspendLayout();
            this.panelPrinterList.SuspendLayout();
            this.panelFunction.SuspendLayout();
            this.panelBottonOfDesktop.SuspendLayout();
            this.panelAddDevice.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.panelDesktop.Controls.Add(this.panelPrinterList);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 52);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(800, 356);
            this.panelDesktop.TabIndex = 1;
            // 
            // panelPrinterList
            // 
            this.panelPrinterList.Controls.Add(this.btnPrinter1);
            this.panelPrinterList.Controls.Add(this.btnPrinter2);
            this.panelPrinterList.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPrinterList.Location = new System.Drawing.Point(0, 0);
            this.panelPrinterList.Name = "panelPrinterList";
            this.panelPrinterList.Padding = new System.Windows.Forms.Padding(15, 15, 0, 0);
            this.panelPrinterList.Size = new System.Drawing.Size(800, 122);
            this.panelPrinterList.TabIndex = 0;
            // 
            // btnPrinter1
            // 
            this.btnPrinter1.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnPrinter1.FlatAppearance.BorderSize = 0;
            this.btnPrinter1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrinter1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrinter1.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnPrinter1.IconColor = System.Drawing.Color.DimGray;
            this.btnPrinter1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrinter1.IconSize = 24;
            this.btnPrinter1.Location = new System.Drawing.Point(20, 25);
            this.btnPrinter1.Margin = new System.Windows.Forms.Padding(5, 10, 10, 10);
            this.btnPrinter1.Name = "btnPrinter1";
            this.btnPrinter1.Size = new System.Drawing.Size(91, 33);
            this.btnPrinter1.TabIndex = 0;
            this.btnPrinter1.Text = "打印机1";
            this.btnPrinter1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrinter1.UseVisualStyleBackColor = true;
            // 
            // btnPrinter2
            // 
            this.btnPrinter2.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnPrinter2.FlatAppearance.BorderSize = 0;
            this.btnPrinter2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrinter2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrinter2.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnPrinter2.IconColor = System.Drawing.Color.DimGray;
            this.btnPrinter2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrinter2.IconSize = 24;
            this.btnPrinter2.Location = new System.Drawing.Point(131, 25);
            this.btnPrinter2.Margin = new System.Windows.Forms.Padding(10);
            this.btnPrinter2.Name = "btnPrinter2";
            this.btnPrinter2.Size = new System.Drawing.Size(91, 33);
            this.btnPrinter2.TabIndex = 1;
            this.btnPrinter2.Text = "打印机2";
            this.btnPrinter2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrinter2.UseVisualStyleBackColor = true;
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
            this.panelFunction.TabIndex = 11;
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
            this.panelBottonOfDesktop.Controls.Add(this.panelAddDevice);
            this.panelBottonOfDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottonOfDesktop.Location = new System.Drawing.Point(0, 42);
            this.panelBottonOfDesktop.Margin = new System.Windows.Forms.Padding(0);
            this.panelBottonOfDesktop.Name = "panelBottonOfDesktop";
            this.panelBottonOfDesktop.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.panelBottonOfDesktop.Size = new System.Drawing.Size(800, 408);
            this.panelBottonOfDesktop.TabIndex = 14;
            // 
            // panelAddDevice
            // 
            this.panelAddDevice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.panelAddDevice.ColumnCount = 2;
            this.panelAddDevice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelAddDevice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelAddDevice.Controls.Add(this.btnAddDevice, 1, 0);
            this.panelAddDevice.Controls.Add(this.labelAddDevice, 0, 0);
            this.panelAddDevice.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAddDevice.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelAddDevice.Location = new System.Drawing.Point(0, 1);
            this.panelAddDevice.Margin = new System.Windows.Forms.Padding(0);
            this.panelAddDevice.Name = "panelAddDevice";
            this.panelAddDevice.RowCount = 1;
            this.panelAddDevice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelAddDevice.Size = new System.Drawing.Size(800, 51);
            this.panelAddDevice.TabIndex = 0;
            // 
            // btnAddDevice
            // 
            this.btnAddDevice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddDevice.BackColor = System.Drawing.Color.White;
            this.btnAddDevice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.btnAddDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDevice.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddDevice.ForeColor = System.Drawing.Color.Black;
            this.btnAddDevice.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAddDevice.IconColor = System.Drawing.Color.Black;
            this.btnAddDevice.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddDevice.Location = new System.Drawing.Point(642, 11);
            this.btnAddDevice.Margin = new System.Windows.Forms.Padding(0, 11, 20, 11);
            this.btnAddDevice.Name = "btnAddDevice";
            this.btnAddDevice.Size = new System.Drawing.Size(138, 29);
            this.btnAddDevice.TabIndex = 23;
            this.btnAddDevice.Text = "添加设备";
            this.btnAddDevice.UseVisualStyleBackColor = false;
            // 
            // labelAddDevice
            // 
            this.labelAddDevice.AutoSize = true;
            this.labelAddDevice.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAddDevice.Location = new System.Drawing.Point(25, 17);
            this.labelAddDevice.Margin = new System.Windows.Forms.Padding(25, 17, 3, 17);
            this.labelAddDevice.Name = "labelAddDevice";
            this.labelAddDevice.Size = new System.Drawing.Size(116, 17);
            this.labelAddDevice.TabIndex = 0;
            this.labelAddDevice.Text = "添加打印机或扫描仪";
            // 
            // FormDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelBottonOfDesktop);
            this.Controls.Add(this.panelFunction);
            this.Name = "FormDevice";
            this.Text = "FormDevice";
            this.panelDesktop.ResumeLayout(false);
            this.panelPrinterList.ResumeLayout(false);
            this.panelFunction.ResumeLayout(false);
            this.panelBottonOfDesktop.ResumeLayout(false);
            this.panelAddDevice.ResumeLayout(false);
            this.panelAddDevice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelDesktop;
        private Sunny.UI.UITableLayoutPanel panelFunction;
        private MFilesMDemo1.MyUserControl.SearchBox SearchBox;
        private Panel panelBottonOfDesktop;
        private TableLayoutPanel panelAddDevice;
        private Label labelAddDevice;
        private FontAwesome.Sharp.IconButton btnAddDevice;
        private FlowLayoutPanel panelPrinterList;
        private FontAwesome.Sharp.IconButton btnPrinter1;
        private FontAwesome.Sharp.IconButton btnPrinter2;
    }
}