using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComDAL.Model
{
    public class CartItem:AuditFields
    {
        public Cart? Cart_Id { get; set; }
        public Product? Product_Id { get; set; }

    }
}
