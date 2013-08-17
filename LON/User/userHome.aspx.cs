using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace LON.User
{
    public partial class userHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (User.Identity.IsAuthenticated)
            {
                Login1.Visible = false;
            }
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            if (Membership.ValidateUser("sai", "saisaisai"))
            {
                FormsAuthentication.SetAuthCookie("Amit Debadwar", true);
             
                Response.Redirect("~/User/userHome.aspx");
            }
        }
    }
}