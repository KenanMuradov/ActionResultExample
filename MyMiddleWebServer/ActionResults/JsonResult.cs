using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ActionResultExample.ActionResults;
public class JsonResult : IActionResult
{
    public void ExecuteResult(HttpListenerContext context)
    {
        HttpClient client = new HttpClient();
        string url = "http://www.omdbapi.com/?apikey=5aa4e11a&t=speed";
        var str = client.GetStringAsync(url).Result;
        var bytes = Encoding.UTF8.GetBytes(str);
        context.Response.ContentType = "application/json";
        context.Response.OutputStream.WriteAsync(bytes);
    }
}
