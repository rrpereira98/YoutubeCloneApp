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
        List<VideoModel> allVideos = new List<VideoModel>();

        Point location = new Point(40, 40);

        public Home()
        {
            InitializeComponent();
            CreateVideos();
            LoadVideos();
        }

        private void LoadVideos()
        {
            for (int i = 0; i < allVideos.Count; i++)
            {
                Button videoBtn = new Button();
                videoBtn.Tag = i;
                videoBtn.Image = allVideos[i].Thumbnail;
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
                videoBtn.Text = allVideos[i].Name;
                videoBtn.ForeColor = Color.White;
                videoBtn.ImageAlign = ContentAlignment.TopCenter;
                videoBtn.TextAlign = ContentAlignment.BottomCenter;
                videoBtn.BringToFront();
                videoBtn.Show();

                location = new Point(videoBtn.Location.X + 276, videoBtn.Location.Y);

                videoBtn.Click += new EventHandler(videoButton_Click);
            }
        }

        private void videoButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            OpenForm(new Video(allVideos[int.Parse(btn.Tag.ToString())]));
        }

        Form activeForm = null;
        private void OpenForm(Form form)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(form);
            form.Dock = DockStyle.Fill;

            form.BringToFront();
            form.Show();
        }

        private void CreateVideos()
        {
            for (int i = 0; i < 12; i++)
            {
                VideoModel video = new VideoModel("video " + (i + 1), Properties.Resources.Waste, Properties.Resources.Untitled_11);
                allVideos.Add(video);
            }
        }
    }
}
