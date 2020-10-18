using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingDataAccessLayer.Models
{
    public class ShoppingItem
    {

        public long ShoppingItemID { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public string UnitOfMeasure { get; set; }
        public virtual ShoppingPlace ShoppingPlace { get; set; }
        public virtual ShoppingOccasion ShoppingOccasion { get; set; }

    }
}
