using System.Net;
using System.Text;

namespace ActionResultExample.ActionResults;
public class ContentResult : IActionResult
{
    public void ExecuteResult(HttpListenerContext context)
    {
        var bytes = Encoding.UTF8.GetBytes("Data from mehtod with Type ContentResult");
        context.Response.ContentType = "text/plain";
        context.Response.OutputStream.Write(bytes);
    }
}
