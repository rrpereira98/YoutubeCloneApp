using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Point location = new Point(40, 40);
        int margin = 242;

        public Form1()
        {
            InitializeComponent();
            LoadVideos();
        }

        private void LoadVideos()
        {
            for (int i = 0; i < 12; i++)
            {

                Button videoBtn = new Button();
                videoBtn.Image = Properties.Resources.Untitled_11;
                panelMain.Controls.Add(videoBtn);
                videoBtn.Size = new Size(252, 162);
                videoBtn.MaximumSize = new Size(252, 162);
                if (location.X >= 900)
                {
                    location = new Point(40, location.Y + 202);
                    videoBtn.Location = location;
                }
                else
                {
                    videoBtn.Location = location;
                }
                videoBtn.Anchor = AnchorStyles.None;
                videoBtn.FlatStyle = FlatStyle.Flat;
                videoBtn.FlatAppearance.BorderSize = 0;

                videoBtn.TextImageRelation = TextImageRelation.Overlay;
                videoBtn.Text = "Video " + i.ToString();
                videoBtn.ForeColor = Color.White;
                videoBtn.ImageAlign = ContentAlignment.TopCenter;
                videoBtn.TextAlign = ContentAlignment.BottomCenter;
                videoBtn.BringToFront();
                videoBtn.Show();

                location = new Point(videoBtn.Location.X + 276, videoBtn.Location.Y);
            }
        }

        private void buttonHamburguer_Click(object sender, EventArgs e)
        {
            if (panelSide.Width == 240)
            {
                panelSide.Width = 80;

                buttonHome.Text = "";
                buttonHome.ImageAlign = ContentAlignment.MiddleCenter;
                buttonHome.Padding = new System.Windows.Forms.Padding(0);

                buttonExplore.Text = "";
                buttonExplore.ImageAlign = ContentAlignment.MiddleCenter;
                buttonExplore.Padding = new System.Windows.Forms.Padding(0);

                buttonSubs.Text = "";
                buttonSubs.ImageAlign = ContentAlignment.MiddleCenter;
                buttonSubs.Padding = new System.Windows.Forms.Padding(0);
            }

            else if (panelSide.Width == 80)
            {
                panelSide.Width = 240;

                buttonHome.Text = "     Home";
                buttonHome.ImageAlign = ContentAlignment.MiddleLeft;
                buttonHome.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);

                buttonExplore.Text = "    Explore";
                buttonExplore.ImageAlign = ContentAlignment.MiddleLeft;
                buttonExplore.Padding = new System.Windows.Forms.Padding(19, 0, 0, 0);

                buttonSubs.Text = "     Subscriptions";
                buttonSubs.ImageAlign = ContentAlignment.MiddleLeft;
                buttonSubs.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            }
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            OpenForm(new Home());
        }

        private void buttonIcon_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            OpenForm(new Home());
        }

        Form activeForm = null;
        private void OpenForm(Form form)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            panelMain.Controls.Add(form);
            form.Dock = DockStyle.Fill;

            form.BringToFront();
            form.Show();
        }
    }
}
