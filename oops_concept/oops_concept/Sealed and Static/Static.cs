using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//static class as base class cannot use simple/abstract/sealed/sealed class as derived
//simple base /abstract as base class and derived class sealed combination is happen
namespace oops_concept.Sealed_and_Static
{
    internal class Static
    {
    }

    public static class base_static
    {
        private  static int _i;

        public static int i 
        {
            get { return _i; }
            set { _i = value; }
            
        }
        public static int Add()
        {
            return i;
        }

    }
    public  class SimpleClass
    {
    }
    /*
    public abstract class AbsClass
    {
        public abstract void abc();
    }

    public static class derived_static : SimpleClass

    { }

    public  static class derived_static2 : AbsClass

    {
        public override void abc()
        { }

    }
 

    public  class derived_simpleClass: base_static
    {

    }

    public sealed class derived_Sealed : base_static
    {

    }

    public abstract class derived_abstract : base_static
    { }
    */

}
