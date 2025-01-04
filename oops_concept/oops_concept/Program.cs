using oops_concept.Abstact_class;
using oops_concept.Partial_class;
using oops_concept.Sealed_and_Static;
using oops_concept.Solid_Principal;
using oops_concept.Solid_Principal.OCP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static oops_concept.Abstact_class.Abstract_Employee;


namespace oops_concept
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /*  Attendence_Override Adden = new Attendence_Override();
              int adde = Adden.sum(20,10);

              Department_override dep = new Department_override();
              int xx = dep.add(123, 1);
              int YY = dep.sum(123, 1);
              int ZZ = dep.minus(100, 1);

              Department_override_2 abst = new Department_override_2();
             int t= abst.add(10, 200);
             int sm= abst.sum(12, 111);
             int ms = abst.minus(12, 1);
                         */

            //first Animal abstract class variable and created new instace to derived normal class 

            /* Animal _animal_dog = new Dog();
             _animal_dog.MakeSound();
             _animal_dog.sleep();


             Animal Animal_cat = new Cat();
             Animal_cat.MakeSound();
             Animal_cat.sleep();

             //inerface frist and derived class
              IABS_first _Abs_First = new DerivedClasses();
              int ii= _Abs_First.salary();
              IABSA_Second aBSA_Second=new DerivedClasses();
              int jj = aBSA_Second.Sal();
             Array_Arraylist arr = new Array_Arraylist();
             arr.duplicate();
             */
            //Sealed class 
            /*
            SealedDerived1 s = new SealedDerived1();
            int n =  s.testing();
            //SealedDerived
                SealedBase sb = new SealedBase();
           sb.testc();
            SealedDerived.testcing();
            SealedDerived.testing();
            */

            //static method 
            //base_static.Add();
            /* SealedDerived1 s = new SealedDerived1();
             int n = s.testing();
             int ss = s.sum();
             //Partial_class class
             person per = new person();
             string a=per.PartialTest();
             string ba = per.PartialTesting();
            */
            //SRP
            ILogger log = new Logger();
            UserService _usmservice = new UserService(log);
          _usmservice.CreateUser("Testing");
            Order order = new Order(500); // Example order with $500 total

            // Apply HolidayDiscount strategy
            DiscountService holidayDiscountService = new DiscountService(new HolidayDiscount());
            double holidayDiscount = holidayDiscountService.CalculateDiscount(order);
            Console.WriteLine($"Holiday Discount: ${holidayDiscount}");



        }
    }
}
