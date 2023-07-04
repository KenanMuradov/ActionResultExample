using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ActionResultExample.ActionResults;
public class EmptyResult : IActionResult
{
    public void ExecuteResult(HttpListenerContext context)
    {
        Console.WriteLine("Some Action happened in back but no change in the view");
    }
}
