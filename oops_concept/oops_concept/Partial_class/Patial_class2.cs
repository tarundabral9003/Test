using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_concept.Partial_class
{
    internal class Patial_class2
    {
    }

    public partial class person
    {
        string subject = "al";

        public string PartialTesting()
        {

            subject = "maths";
            return subject;


        }

    }
}
