using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspNetWebFormsApp
{
    public partial class About : Page
    { 

        protected void Page_PreInit(object sender, EventArgs e)
        {
            // Check if a theme is stored in session, else use a default value
            if (Session["Theme"] != null)
            {
                Page.Theme = Session["Theme"].ToString();
            }
            else
            {
                // Optionally set a default theme here if none is chosen
                Page.Theme = "MyTheme";
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
      
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            // Toggle between themes for demonstration
            if (Session["Theme"] == null || Session["Theme"].ToString() == "MyTheme2")
            {
                Session["Theme"] = "MyTheme";
            }
            else
            {
                Session["Theme"] = "MyTheme2";
            }
            // Reload the page for the new theme to take effect
            Response.Redirect(Request.Url.ToString());
        }
    }
}