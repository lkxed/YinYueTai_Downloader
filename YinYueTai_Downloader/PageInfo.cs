using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YinYueTai_Downloader
{
    class PageInfo
    {
        public int PageNum { get; set; } // 页码
        public int PageCount { get; set; } // 页数
        public int TotalCount { get; set; } // 视频数
        public int StartIndex { get; set; } // 起始索引
        public int EndIndex { get; set; } // 结束索引
    }
}
