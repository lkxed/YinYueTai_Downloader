using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace YinYueTai_Downloader
{
    class Action
    {
        // 搜索视频
        public static Task<VideoSearchResult> SearchVideo(string key, int pageIndex=1, int pageSize=10) 
        {
            var headers = new Dictionary<string, string>
            {
                {"Host", "so.yinyuetai.com"},
                {"Referer", "http://m2.yinyuetai.com/so.html"},
                {"User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/71.0.3578.98 Safari/537.36"},
                {"Cookie", "tid=beu1ZFb61bolKqehSgbcU9EI; yyt_pref=2; yinyuetai_uid=ahba6T2u1boDoDHucReAoG3J; Hm_lvt_5885921252431e994a0a9617e39e9d73=1545751287; Hm_lpvt_5885921252431e994a0a9617e39e9d73=1545751287"},
                {"Accept-Language", "zh-CN,zh;q=0.9,en-US;q=0.8,en;q=0.7,ja;q=0.6"},
                {"Accept-Encoding", "gzip, deflate"},
                {"Accept", "*/*"}
            };

            var parameters = new Dictionary<string, string>
            {
                {"callback", "jsonpHd7t3Z"},
                {"_api", "get.videoList"},
                {"_mock", "false"},
                {"keyword", key},
                {"offset", "0"},
                {"pageIndex", pageIndex.ToString()},
                {"pageSize", pageSize.ToString()}
            };

            return Task<VideoSearchResult>.Run(() =>
            {
                var videoSearchResult = new VideoSearchResult();
                try
                {
                    var task = Util.Get("http://so.yinyuetai.com/search/video-search", headers, parameters);
                    string result = task.Result;
                    result = result.Substring(12, result.Length - 13);
                    JObject resultJson = JObject.Parse(result);
                    videoSearchResult = resultJson.ToObject<VideoSearchResult>();
                    if (videoSearchResult.PageInfo.TotalCount == 0)
                    {
                        throw new Exception("none");
                    }
                    return videoSearchResult;
                }
                catch(NullReferenceException e)
                {
                    throw e;
                }
            });
        }

        // 获取视频详细信息
        public static Task<VideoInfo> GetVideoInfo(string videoId)
        {
            var headers = new Dictionary<string, string>
            {
                {"User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/71.0.3578.98 Safari/537.36"},
                {"Cookie", "tid=beu1ZFb61bolKqehSgbcU9EI; yyt_pref=2; yinyuetai_uid=ahba6T2u1boDoDHucReAoG3J; Hm_lvt_5885921252431e994a0a9617e39e9d73=1545751287; Hm_lpvt_5885921252431e994a0a9617e39e9d73=1545751287"},
                {"Accept-Language", "zh-CN,zh;q=0.9,en-US;q=0.8,en;q=0.7,ja;q=0.6"},
                {"Accept-Encoding", "gzip, deflate"},
                {"Accept", "*/*"}
            };

            var parameters = new Dictionary<string, string>
            {
                {"json", "true"},
                {"videoId", videoId}
            };

            return Task<VideoInfo>.Run(() =>
            {
                var videoInfo = new VideoInfo();
                try
                {
                    var task = Util.Get("http://ext.yinyuetai.com/main/get-h-mv-info", headers, parameters);
                    string result = task.Result;
                    JObject resultJson = JObject.Parse(result);
                    Console.WriteLine(resultJson.ToString());
                    videoInfo = resultJson["videoInfo"]["coreVideoInfo"].ToObject<VideoInfo>();
                    return videoInfo;
                }
                catch(NullReferenceException e)
                {
                    throw e;
                }
            });
        }

        // 下载视频
        public static void DownloadVideo(string url, string fileName)
        {
            Util.HttpDownload(url, fileName);
        }
    }
}
