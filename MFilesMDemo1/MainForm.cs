

using FontAwesome.Sharp;
using MFilesMDemo2.Forms;
using System.Runtime.InteropServices;
using MFilesMDemo1.Theme;

namespace MFilesMDemo1
{
    public partial class MainForm : Form
    { 

        //Fields
        private IconButton currentBtn;
        //private Panel leftBorderBtn;
        private Form currentChildForm;


        public MainForm()
        {
            InitializeComponent();
            //leftBorderBtn = new Panel();
            //leftBorderBtn.Size = new Size(3, 33);
            //flowLayoutPanel1.Controls.Add(leftBorderBtn);
            //Form remove the title bar
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }


        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                //currentBtn.BackColor = RGBColors.colorSidebarFont2;
                //currentBtn.ForeColor = color;
                //currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                //currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                //currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                /*leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();*/
                //Current Child Form Icon
                //iconCurrentChildForm.IconChar = currentBtn.IconChar;
                //iconCurrentChildForm.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                //currentBtn.BackColor = Color.FromArgb(11, 7, 17);
                //currentBtn.ForeColor = Color.Gainsboro;
                //currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.DimGray;
                //currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                //currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lblTitleChildForm.Text = childForm.Text;
        }


        //MenuButtonCLick Event
        //Switching Colors 
        private void btnHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color8);
            OpenChildForm(new FormHome());

        }

        private void btnFiles_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color8);
            OpenChildForm(new FormFiles());
        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color8);
            OpenChildForm(new FormTask());
        }

        private void btnDev_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color8);
            OpenChildForm(new FormDevice());
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color8);
            if (panelSidebar.Width == panelSidebar.MaximumSize.Width)
                panelSidebar.Width = panelSidebar.MinimumSize.Width;
            else
                panelSidebar.Width = panelSidebar.MaximumSize.Width;

        }

    }
}