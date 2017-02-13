using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyHttp.Http;
namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient http = new HttpClient() ;
            http.Request.Cookies = new System.Net.CookieCollection();
            http.Request.AllowAutoRedirect = false;
            var html = http.Get("http://www.baidu.com").RawText;
            Console.WriteLine(html);
            Console.Read();
        }
    }
}
