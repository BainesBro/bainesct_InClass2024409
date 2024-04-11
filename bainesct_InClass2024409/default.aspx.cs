using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bainesct_InClass2024409
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
            
        {
            lbFruits.Items.Add("Strawberry");

        }

        protected void lbFruits_SelectedIndexChanged(object sender, EventArgs e)
        {

            lblChosenFruit.Text = lbFruits.SelectedValue;
        }
        // I need an event that will run when the user,
        // in their browser, selects a fruit from the list box
        // "event-driven" programming.
        // Our event is The user selected an item from the list box
    }
}