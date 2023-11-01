using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_One
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Image1.ImageUrl = $"~/images/Automobiles.jpg";
            }

        }

        protected void DropDownList1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            string name = DropDownList1.SelectedValue;
            Image1.ImageUrl = $"~/images/{name}";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = DropDownList1.SelectedValue;

            switch (name)
            {
                case "bugatti.jpg":
                    Label1.Text = "$1.9 Million";

                    break;
                case "Porsche.jpg":
                    Label1.Text = "$1.3 Million";

                    break;
                case "innova.jpg":
                    Label1.Text = "$150000";

                    break;
                case "Defender.jpg":
                    Label1.Text = "$1.2 Million";

                    break;
                case "rolls royce.jpg":
                    Label1.Text = "$1.7 Million";

                    break;
            }
               
        }
    }
}