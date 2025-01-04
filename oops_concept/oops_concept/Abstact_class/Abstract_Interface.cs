using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_concept.Abstact_class
{
    internal class Abstract_Interface
    {
    }
    public abstract class Animal
    {

        public abstract void  MakeSound();
       public  void sleep()
        {
            Console.WriteLine("Animal_sleep");
        }
    }

    public  class Dog: Animal
    {
      public override void MakeSound()
        {
            Console.WriteLine("Dog");

        }
    }
    public class Cat : Animal 
    {
        public override void MakeSound()
        {
            Console.WriteLine("CAT");
        }

    }
   public interface IABS_first
    {


        int salary();
    
    }

    public interface IABSA_Second
    { 
         int Sal(); 
    }

    public  class DerivedClasses : IABS_first, IABSA_Second
    {
     
        // Abstract properties 

        public  int salary()
        {
       

            int i = 100;
            return i;
        }

      public  int Sal()
        { int x = 1000;

            return x;
        }

       
    }
 }


