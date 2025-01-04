using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_concept.Solid_Principal.OCP
{
    public class DiscountService
    {
        private DiscountStrategy _DiscountStrategy;

         public DiscountService(DiscountStrategy DiscountStrategy)
        {
            _DiscountStrategy = DiscountStrategy;

        }

        public  double CalculateDiscount(Order order)
        {
           
            return _DiscountStrategy.CalculateDiscount(order);
        }
    }



}
