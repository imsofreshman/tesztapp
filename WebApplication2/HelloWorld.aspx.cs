using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class HelloWorld : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                ddl1.Items.Add(new ListItem("János", "János"));
                ddl1.Items.Add(new ListItem("László", "László"));
                ddl1.Items.Add(new ListItem("Géza", "Géza"));
                ddl1.Items.Add(new ListItem("Tamás", "Tamás"));
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Literal1.Text = "A gomb meg lett nyomva, a legördülő lista értéke: " + ddl1.SelectedValue;
        }


    }
}