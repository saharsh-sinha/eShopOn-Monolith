using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopOn.Ordering.Models
{
    public class Order
    {
        public dynamic ordernumber;
        public dynamic date;
        public dynamic status;
        public dynamic description;
        public dynamic street;
        public dynamic city;
        public dynamic zipcode;
        public dynamic country;
        public List<Orderitem> orderitems;
        public int total;
    }
}