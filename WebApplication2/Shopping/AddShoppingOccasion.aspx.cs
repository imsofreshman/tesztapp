using ShoppingDataAccessLayer.Models;
using System;
using System.Linq;

namespace WebApplication2.Shopping
{
    public partial class AddShoppingOccasion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var selectedDate = cndDate.SelectedDate;
            var description = txtDescription.Text;
            using (var db = new ShoppingContext())
            {
                var isSelectedDateExist = db.ShoppingOccasions.Any(x => x.Date.Year == selectedDate.Year 
                                                                && x.Date.Month == selectedDate.Month 
                                                                && x.Date.Day == selectedDate.Day);
                if (isSelectedDateExist)
                {
                    lResult.Text = "Ez a Dátum már létezik";
                }
                else
                {
                    var shoppingOccasion = new ShoppingOccasion()
                    {
                        Date = selectedDate,
                        Description = description
                    };
                    db.ShoppingOccasions.Add(shoppingOccasion);
                    db.SaveChanges();
                    lResult.Text = "Dátum sikeresen hozzáadva.";
                }
            }
        }
    }
}