using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YinYueTai_Downloader
{
    class Data // 视频信息
    {
        public string Id { get; set; } // 编号
        public string Title { get; set; } // 标题
        public string HeadImg { get; set; } // 封面
        public string Duration { get; set; } // 时长
        public List<Artist> artists { get; set; } // 作者
        public string Value { get; set; } // 播放量
        public string PubDate { get; set; } // 上传时间
    }
}
