using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MFilesMDemo1.Theme;

namespace MFilesMDemo2.Forms
{
    public partial class FormHome : Form
    {
        private Button currentBtn;

        public FormHome()
        {
            InitializeComponent();
        }

        internal Button CreateBtn(string tag, string name, string imageUri)
        {
            Button b = new Button();
            b.Tag = tag;
            Image image;
            image = Image.FromFile(imageUri);
            b.BackgroundImage = image;
            b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            b.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            b.FlatAppearance.BorderSize = 0;
            b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            b.Location = new System.Drawing.Point(25, 25);
            b.Margin = new System.Windows.Forms.Padding(10);
            b.Name = name;
            b.Size = new System.Drawing.Size(50, 50);
            b.TabIndex = 10;
            b.UseVisualStyleBackColor = false;
            return b;
        }

        private void FromHome_Load(object sender, EventArgs e)
        {
            var b = CreateBtn("测试", "测试", @"D:\Git\UI2\MFilesMDemo1\MFilesMDemo1\Theme\UP\UP\access.png");
            this.panelDesktop.Controls.Add(b);
        }

        /*        private void button1_MouseMove(object sender, MouseEventArgs e)
                {
                    ActivateButton(sender, RGBColors.color9);
                }

                private void ActivateButton(object senderBtn, Color color)
                {
                    if (senderBtn != null)
                    {
                        //DisableButton();
                        //Button
                        currentBtn = (Button)senderBtn;  
                        currentBtn.BackColor = color;

                    }
                }

                private void DisableButton()
                {
                    if (currentBtn != null)
                    { 
                        currentBtn.BackColor = Color.FromArgb(0, 0, 0);

                    }
                }

                private void button1_MouseLeave(object sender, EventArgs e)
                {
                    DisableButton();
                }*/
    }
}
