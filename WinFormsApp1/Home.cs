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
    public partial class Home : Form
    {
        Point location = new Point(40, 40);
        int margin = 242;

        public Home()
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
                this.Controls.Add(videoBtn);
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
    }
}
