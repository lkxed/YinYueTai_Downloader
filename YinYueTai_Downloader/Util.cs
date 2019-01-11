using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace YinYueTai_Downloader
{
    public class Util
    {
        // 获取当前时间戳(13位)
        public static string GetTimeStamp()
        {
            DateTime currentTime = DateTime.Now;
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1, 0, 0, 0, 0));
            long timeStamp = (currentTime.Ticks - startTime.Ticks) / 10000; // 除10000调整为13位      
            return timeStamp.ToString();
        }

        // 获取当前IPv4地址
        public static string GetIpAddress()
        {
            string hostName = Dns.GetHostName(); // 获取本机名
            IPHostEntry localhost = Dns.GetHostEntry(hostName); // 获取IPv4的地址
            foreach (IPAddress localaddr in localhost.AddressList)
            {
                if (localaddr.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    return localaddr.ToString();
                }
            }
            return "";
        }

        // 获取随机User-Agent
        public static string GetRandomUA()
        {
            return "";
        }

        // 从URL中获取文件后缀
        public static string GetFileExtensionFromUrl(string url)
        {
            return "." + url.Split('?').First().Split('.').Last();
        }

        // 通过 HTTP URL 下载文件
        public static async void HttpDownload(String url, string fileName)
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    Task task = client.DownloadFileTaskAsync(new Uri(url), fileName);
                    await task;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                }
            }
        }

        // HTTP GET 实现
        public static async Task<string> Get(string url, Dictionary<string, string> headers=null, Dictionary<string, string> parameters=null)
        {
            using (HttpClient client = new HttpClient(new HttpClientHandler() { AutomaticDecompression = DecompressionMethods.GZip }))
            {
                try
                {
                    // 定制请求头
                    if (headers != null)
                    {
                        foreach (var header in headers)
                        {
                            client.DefaultRequestHeaders.Add(header.Key, header.Value);
                        }
                    }
                    
                    // 添加URL参数
                    if (parameters != null)
                    {
                        url += "?";
                        foreach (var parameter in parameters)
                        {
                            url = url + parameter.Key + "=" + parameter.Value + "&";
                        }
                        url = url.Substring(0, url.Length - 1);
                        Console.WriteLine(url);
                    }

                    // 发起异步请求
                    string responseBody = await client.GetStringAsync(url);
                    return responseBody;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                    return null;
                }
            }
        }

        // HTTP POST 实现
        public static async Task<string> Post(string url, Dictionary<string, string> headers=null, Dictionary<string, string> parameters=null, Dictionary<string, string> data=null)
        {
            using (HttpClient client = new HttpClient(new HttpClientHandler() { AutomaticDecompression = DecompressionMethods.GZip }))
            {
                try
                {
                    // 定制请求头
                    if (headers != null)
                    {
                        foreach (var header in headers)
                        {
                            client.DefaultRequestHeaders.Add(header.Key, header.Value);
                        }
                    }

                    // 添加URL参数
                    if (parameters != null)
                    {
                        url += "?";
                        foreach (var parameter in parameters)
                        {
                            url = url + parameter.Key + "=" + parameter.Value + "&";
                        }
                        url = url.Substring(0, url.Length - 1);
                    }

                    // 定制请求数据
                    FormUrlEncodedContent content = new FormUrlEncodedContent(data);

                    // 发起异步请求
                    var responseBody = await client.PostAsync(url, content);
                    return responseBody.Content.ReadAsStringAsync().Result;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                    return null;
                }
            }
        }
    }
}
