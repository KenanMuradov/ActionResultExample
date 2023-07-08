using ActionResultExample.ActionResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ActionResultExample.ActionResults;
public class RedirectResult : IActionResult
{
    public void ExecuteResult(HttpListenerContext context)
    {
        context.Response.Redirect("https://duiqt.github.io/herta_kuru/");
    }
}
