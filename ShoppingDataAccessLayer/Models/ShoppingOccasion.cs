using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingDataAccessLayer.Models
{
    public class ShoppingOccasion
    {
        public long ShoppingOccasionID { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public virtual ICollection<ShoppingItem> ShoppingItems { get; set; }
    }
}
