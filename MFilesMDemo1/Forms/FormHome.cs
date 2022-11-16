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
