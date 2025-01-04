using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_concept.Sealed_and_Static
{
    internal class Sealed
    {
    }
    //sealed class as base class cannot use simple/abstract/sealed/static/partial class as derived
    // simple base /abstract as base class and derived class sealed combination is happen
    public sealed class SealedBase
    {

        private static int _i;
        private static int _j;

        public static int i
        {
            get { return _i; }
            set { _i = value; }
        }
        public void testc()
        {
            i = 100;
            Console.WriteLine(i);
        
        }



    }

    public  class simpleClass
    {

        private static int _i;
        private int _j;

        public static int i
        {
            get { return _i; }
            set { _i = value; }
        }
        public  static void testcing()
        {
            i = 100;
            Console.WriteLine(i);

        }



    }

    public sealed class SealedDerived3 : partialBase
    {
        public static void testing()
        {
           int i = 100;
            Console.WriteLine(i);

        }
    }


    public partial class partialBase
    {
        public static int test()
        {
            return 100;
        }

    }

    public static class static_derived 
    { 
    
    
    }
    public abstract class absdevided 
    {
          public abstract int  testing();
        public int sum()
        {
            return 1;
        }
    }

  
    public sealed class SealedDerived : simpleClass
    {
        public static void testing()
        {
            i = 100;
            Console.WriteLine(i);

        }
    }

    public sealed class SealedDerived1 : absdevided
    {
       public override int testing()
        {
            return 1;
        }
    }
   

    /* not working
    public sealed class SealedDerived : SealedBase
    {

    }
   

    public abstract class absdevided : SealedBase
    { 
    
    }
    

    public class simpleclass1: SealedBase
     */
}

