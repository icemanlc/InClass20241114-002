using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InClass20241114_002
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) //only run this code if it not a postback 
                
            {
                //how can we run this only one time?
                //this method runs when the page is leaded into a browser 
                //add a pizza company qto the list box 
                lbPizzaCompanies.Items.Add("Dominos");
                lbPizzaCompanies.Items.Add("Papa John");
                lbPizzaCompanies.Items.Add("LaRosa's");
                lbPizzaCompanies.Items.Add("Jets");
                lbPizzaCompanies.Items.Add("Mac's");
                cblIngredients.Items.Add("Cheese");
                cblIngredients.Items.Add("pep");
                cblIngredients.Items.Add("onion");
                cblIngredients.Items.Add("sauce");
            }

        }

        protected void cmdSelectPizzaCompany_Click(object sender, EventArgs e)
        {
            //This code runs when the cmd slelect pizzacompany button is hit 
            //we call this an event handler 
            //Write the currently selected pizza company in the list into the label 
            //we are using the text property of the label 
            //we
            lblSelectPizzaCompany.Text = lbPizzaCompanies.Text;
        }
    }
}