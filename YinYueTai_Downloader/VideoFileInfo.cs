using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YinYueTai_Downloader
{
    class VideoFileInfo
    {
        public int BitrateType { get; set; }
        public int BitRate { get; set; }
        public string QualityLevel { get; set; }
        public string QualityLevelName { get; set; }
        public string VideoUrl { get; set; }
        public int FileSize { get; set; }
        public string Sha1 { get; set; }
        public string Md5 { get; set; }
    }
}
