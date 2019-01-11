using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace YinYueTai_Downloader
{
    static class Test
    {
        static void Main(string[] args)
        {
            var result = Action.SearchVideo("向阳花", 1, 10).Result;
            Console.WriteLine(result.Videos.Data.Count);
        }
    }
}
