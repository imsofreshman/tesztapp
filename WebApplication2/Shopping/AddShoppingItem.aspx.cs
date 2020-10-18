using ShoppingDataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2.Shopping
{
    public partial class AddShoppingItem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                using (var db = new ShoppingContext())
                {
                    var shoppingPlaces = db.shoppingPlaces.ToArray().Select(x => new ListItem()
                    {
                        Text = x.Name,
                        Value = x.ShoppingPlaceID.ToString()
                    }).ToArray();
                    ddlShoppingPlaces.Items.AddRange(shoppingPlaces);

                    var shoppingOccasions = db.ShoppingOccasions.ToArray().Select(x => new ListItem()
                    {
                        Text = x.Date.ToShortDateString(),
                        Value = x.ShoppingOccasionID.ToString()
                    }).ToArray();
                    ddlShoppingOccasions.Items.AddRange(shoppingOccasions);
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new ShoppingContext())
                {
                    var selectedShoppingPlaceID = Convert.ToInt32(ddlShoppingPlaces.SelectedValue);
                    var shoppingPlace = db.shoppingPlaces.FirstOrDefault(x => x.ShoppingPlaceID == selectedShoppingPlaceID);
                    var selectedShoppingOccasionId = Convert.ToInt32(ddlShoppingPlaces.SelectedValue);
                    var shoppingOccasion = db.ShoppingOccasions.FirstOrDefault(x => x.ShoppingOccasionID == selectedShoppingOccasionId);

                    var shoppingItem = new ShoppingItem()
                    {
                        ItemName = txtName.Text,
                        Quantity = Convert.ToInt32(txtQuantity.Text),
                        UnitOfMeasure = txtUnitOfMeasure.Text,
                        ShoppingPlace = shoppingPlace,
                        ShoppingOccasion = shoppingOccasion,

                    };
                    db.ShoppingItems.Add(shoppingItem);
                    db.SaveChanges();
                    lResult.Text = "Tétel sikeresen hozzáadva.";
                }
            }
            catch (Exception ex)
            {

                lResult.Text = "Hiba történt";
            }

        }
    }
}