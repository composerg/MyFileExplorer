using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Microsoft.VisualBasic.Devices;
using System.Threading;
using System.Security.AccessControl;
using MFilesMDemo1.Forms;
using Sunny.UI;

namespace MFilesMDemo2.Forms
{
    public partial class FormFiles : Form
    {
        public FormFiles()
        {
            InitializeComponent();
        }




        
        private void FormFiles_Load(object sender, EventArgs e)
        {
            this.tvwDirectory.Nodes.Clear();
            this.lvwFiles.Items.Clear();
            LoadDrives();
        }

        private void LoadDrives()
        {
            DriveInfo[] _drives = DriveInfo.GetDrives();
            foreach(var _drive in _drives)
            {
                if(_drive.IsReady)
                {
                    TreeNode _treeNode = this.tvwDirectory.Nodes.Add(_drive.Name);
                    DirectoryInfo[] _dirs = new DirectoryInfo(_drive.Name).GetDirectories();
                    foreach(var _dir in _dirs)
                    {
                        _treeNode.Nodes.Add(_dir.Name);
                    }
                }
            }
        }

        private void tvwDirectory_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            this.lvwFiles.Items.Clear();
            string _path = e.Node.FullPath + @"\";
            //this.label1.Text = string
            FileInfo[] _files = new DirectoryInfo(_path).GetFiles();
            foreach(var _file in _files)
            {
                ListViewItem _item = this.lvwFiles.Items.Add(_file.Name);

            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            btnView.ShowContextMenuStrip(ViewContextMenuStrip, 0, btnView.Height);
        }

        private void ToolStripLargeMenuItem_Click(object sender, EventArgs e)
        {
            this.lvwFiles.View = View.LargeIcon;
        }

        private void ToolStripSmallMenuItem_Click(object sender, EventArgs e)
        {
            this.lvwFiles.View = View.SmallIcon;
        }

        private void ToolStripListMenuItem_Click(object sender, EventArgs e)
        {
            this.lvwFiles.View = View.List;
        }

        private void ToolStripDetailsMenuItem_Click(object sender, EventArgs e)
        {
            this.lvwFiles.View = View.Details;
        }
    }
}
