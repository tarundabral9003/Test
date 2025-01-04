using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_concept.Solid_Principal
{
    public class Logger:ILogger
    {
     public void log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
