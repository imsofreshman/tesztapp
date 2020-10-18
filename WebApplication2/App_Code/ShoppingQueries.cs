using ShoppingDataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace WebApplication2.App_Code
{
    public class ShoppingQueries
    {
        public IEnumerable<ListItem> GetFutureShoppingOccasions()
        {
            using (var db = new ShoppingContext())
            {
                var currentDate = DateTime.Now.Date;
                var query = db.ShoppingOccasions.Where(x => x.Date >= currentDate)
                    .OrderBy(x => x.Date).ToList()
                    .Select(x => new ListItem() {Text = x.Date.ToShortDateString(), Value = x.ShoppingOccasionID.ToString() });
            }
        }
    }
}