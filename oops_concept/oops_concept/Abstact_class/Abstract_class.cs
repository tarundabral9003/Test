using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_concept.Abstact_class
{
    public class Abstract_class
    {
      
    }

    //Abstract class usning override function
    public abstract class Abstract_Employee
    {

        private  int _i;
        public abstract int i { get; set; }
        public abstract int minus(int x, int y);
        public abstract int sum(int z, int zz);
        public int add(int x, int y)

        {

            int xx = x + y;
            return xx;

        }
        public class Attendence_Override : Abstract_Employee
        {
            public override int i { get { return _i; } set

                { _i = value; } }
            public override int minus(int x, int y)
            {

                int xx = x - y;
                return xx;
            }

            public override int sum(int z, int zz)
            {
                int xx = z + zz;
                return xx;

            }
        }
            public class Department_override : Abstract_Employee
        {
            public override int i
            {
                get { return _i; }
                set

                { _i = value; }
            }
            public override int minus(int x, int y)
                {

                    int red = x;
                    return red;
                }
                public override int sum(int z,int zz)
                {
                    int redd = z + zz +3;
                    return redd;




                }
            }
            public class Department_override_2 : Abstract_Employee
        {
            public override int i
            {
                get { return _i; }
                set

                { _i = value; }
            }
            public override int minus(int x, int y)
                {
                    int min = x - y - 2;
                    return min;


                }
             public override int sum(int z, int zz)
            { int sm = z + zz + 23;
                return sm;

       


            }
            }

        }
    }
