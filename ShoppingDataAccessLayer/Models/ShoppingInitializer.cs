using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace ShoppingDataAccessLayer.Models
{
    public class ShoppingInitializer : CreateDatabaseIfNotExists<ShoppingContext>
    {
        protected override void Seed(ShoppingContext context)
        {
            var list = new List<ShoppingPlace>();
            list.Add(new ShoppingPlace() { Name = "Bolt #1", Address = "Cim#1" });
            list.Add(new ShoppingPlace() { Name = "Bolt #2", Address = "Cim#2" });
            list.Add(new ShoppingPlace() { Name = "Bolt #3", Address = "Cim#3" });
            context.shoppingPlaces.AddRange(list);
            base.Seed(context);
        }
    }
}
