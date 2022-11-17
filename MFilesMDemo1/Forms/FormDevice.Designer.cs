namespace MFilesMDemo2.Forms
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
            this.panelFunction = new Sunny.UI.UITableLayoutPanel();
            this.searchBox1 = new MFilesMDemo1.MyUserControl.SearchBox();
            this.panelFunction.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 42);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(800, 408);
            this.panelDesktop.TabIndex = 1;
            // 
            // panelFunction
            // 
            this.panelFunction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.panelFunction.ColumnCount = 7;
            this.panelFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.panelFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.panelFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.panelFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.panelFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.panelFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.panelFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelFunction.Controls.Add(this.searchBox1, 6, 0);
            this.panelFunction.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFunction.Location = new System.Drawing.Point(0, 0);
            this.panelFunction.Name = "panelFunction";
            this.panelFunction.RowCount = 1;
            this.panelFunction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelFunction.Size = new System.Drawing.Size(800, 42);
            this.panelFunction.TabIndex = 11;
            this.panelFunction.TagString = null;
            // 
            // searchBox1
            // 
            this.searchBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.searchBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox1.Location = new System.Drawing.Point(642, 9);
            this.searchBox1.Margin = new System.Windows.Forms.Padding(3, 9, 10, 9);
            this.searchBox1.Name = "searchBox1";
            this.searchBox1.Size = new System.Drawing.Size(148, 24);
            this.searchBox1.TabIndex = 17;
            // 
            // FormDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelFunction);
            this.Name = "FormDevice";
            this.Text = "FormDevice";
            this.panelFunction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelDesktop;
        private Sunny.UI.UITableLayoutPanel panelFunction;
        private MFilesMDemo1.MyUserControl.SearchBox searchBox1;
    }
}