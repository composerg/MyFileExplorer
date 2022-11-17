using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MFilesMDemo1.Forms;

namespace MFilesMDemo2.Forms
{
    public partial class FormTask : Form
    {
        public FormTask()
        {
            InitializeComponent();
        }

        private void ProcessForm_Load(object sender, EventArgs e)
        {
            //显示进程列表
            ShowProcesses();
        }

        //显示进程列表
        private void ShowProcesses()
        {
            lvwProcess.Items.Clear();

            //获取本机的当前所有正在运行的进程
            Process[] processesList = Process.GetProcesses();

            //当前进程数
            txtCurProcessNum.Text = processesList.Length.ToString();

            //有些进程无法获取启动时间和文件名信息，所以要用try/catch
            try
            {
                foreach (Process process in processesList)
                {
                    //进程名称
                    ListViewItem item = lvwProcess.Items.Add(process.ProcessName, IconsIndexes.Process);

                    //进程Id
                    item.SubItems.Add(process.Id.ToString());



                    //启动时间
                    item.SubItems.Add(process.StartTime.ToLongDateString() + process.StartTime.ToLongTimeString());

                    //基本优先级
                    item.SubItems.Add(process.BasePriority.ToString());

                    //路径 
                    item.SubItems.Add(process.MainModule.FileName);

                }

            }
            catch (Exception e)
            {

            }

        }
        class IconsIndexes
        {
            public const int Process = 0; //进程图标
        }
    }
}
