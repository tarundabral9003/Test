using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_concept
{
    public class Array_Arraylist
    {
        public void duplicate()
        {
            int[] value = new int[] { 1, 2, 3, 3, 4, 5 ,1,2};
            int count = 0;
            for (int i = 0; i<value.Length; i++)
            {

                for (int j = i + 1; j < value.Length; j++)
                {
                    if (value[j] == value[i])

                    {
                        Console.WriteLine(value[j]);
                        count++;
                    
                    }

                }
               


            }
            Console.WriteLine("Duplicate count" + " " +count);


        }

        public void SameValue()

        {
            int[] val = 
                {1,3,4,5,1,2,3,7,5,8,9,7};
                
                }
    }
}
