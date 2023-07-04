using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ActionResultExample.ActionResults;
public class FileResult : IActionResult
{


    public void ExecuteResult(HttpListenerContext context)
    {
        string filePath = @$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\MyMiddleWebServer\MyMiddleWebServer\StaticFiles\somePdf.pdf";
        context.Response.ContentType = "application/pdf";
        var bytes = File.ReadAllBytes(filePath);
        context.Response.OutputStream.Write(bytes);
    }
}
