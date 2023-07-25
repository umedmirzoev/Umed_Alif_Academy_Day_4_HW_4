using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umed_Alif_Academy_Day_4_HW_4
{
    public class Order
    {
        public int OrderID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime OrderDate { get; set; }
        public string DeliveryType { get; set; }
        public string DeliveryAddress { get; set; }

    }
}
