using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComDAL.Model
{
    public class Product:AuditFields
    {
        public string? Product_Name { get; set; }
        public string? Description { get; set; }
        public string? SKU { get; set; }
        public decimal Price { get; set; }
        public int Stock_Quantity {  get; set; }
        public string? Image {  get; set; }
        public Category? Category_Id { get; set; }
        public SubCategory? SubCategory_Id { get; set; }

    }
}
