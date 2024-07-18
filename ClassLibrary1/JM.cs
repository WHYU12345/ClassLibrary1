using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static ClassLibrary1.JM;

namespace ClassLibrary1
{
    public class JM : DFJM
    {
        public interface DFJM
        {
            string DFlogin(string username, string password);
            string DFgetdata(string username, string password);

        }



        public string DFlogin(string username, string password)
        {
            throw new NotImplementedException();
        }

        public string DFgetdata(string username, string password)
        {
            throw new NotImplementedException();
        }



        public T post<T>(string url, object obj)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(@"https://www.baidu.com/");
            var result = client.PostAsJsonAsync(url, obj).Result;

            switch (result.StatusCode)
            {
                case HttpStatusCode.OK:
                    return result.Content.ReadAsAsync<T>().Result;
                case HttpStatusCode.BadRequest:
                    var jobj = result.Content.ReadAsAsync<JObject>().Result;
                    throw new Exception(result.StatusCode.ToString() + "\t" + jobj["Message"].ToString());
                default:
                    throw new Exception(result.StatusCode.ToString());
            }
        }
    }
}
