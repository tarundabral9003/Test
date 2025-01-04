using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_concept.Solid_Principal.OCP
{
    //OCP: open\closed principal(open for extention but closed for modification)
    // Before: Violates OCP because to add a new discount strategy, we modify the existing class(abstract class)
    /*
 public class DiscountService
     {
         public double CalculateDiscount(Order order)
         {
             if (order.Type == "Holiday")
             {
                 return order.Total * 0.2; // Holiday discount
             }
             else if (order.Type == "Seasonal")
             {
                 return order.Total * 0.1; // Seasonal discount
             }
             return 0;
         }
     }
    */
    public class Abstract_DiscountStrategy
    {
    }

    public abstract class DiscountStrategy
    {

        public abstract double CalculateDiscount(Order order);


    }
    public class HolidayDiscount : DiscountStrategy
    {
        public override double CalculateDiscount(Order order)
        {

            return order.Total * 0.2; // Holiday discount
        }
    }

    public class SeasonalDiscount : DiscountStrategy
    {
        public override double CalculateDiscount(Order order)
        {

            return order.Total * 0.1; // Seasonal discount
        }
    }


}
