using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YinYueTai_Downloader
{
    class VideoInfo
    {
        public int VideoId { get; set; }
        public string VideoName { get; set; }
        public string HeadImage { get; set; }
        public string BigHeadImage { get; set; }
        public List<VideoFileInfo> VideoUrlModels { get; set; }
        public int Duration { get; set; }
        public string ArtistIds { get; set; }
        public bool ThreeD { get; set; }
        public string Source { get; set; }

    }
}
