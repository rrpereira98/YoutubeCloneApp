using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class VideoModel
    {
        public string Name { get; set; }
        public System.Drawing.Bitmap Video { get; set; }
        public System.Drawing.Bitmap Thumbnail { get; set; }

        public VideoModel(string name, System.Drawing.Bitmap video, System.Drawing.Bitmap thumbnail)
        {
            Name = name;
            Video = video;
            Thumbnail = thumbnail;
        }
    }
}
