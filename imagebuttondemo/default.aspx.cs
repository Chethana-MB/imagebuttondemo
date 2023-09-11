using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace imagebuttondemo
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if (e.X > 234 && e.X < 272)
            {
                Response.Redirect("csharp.aspx");
            }
            else
                if (e.X > 273 && e.X < 647)
            {
                Response.Redirect("asppage.aspx");
            }
            else
            {
                Response.Redirect("vb.aspx");
            }
        }
    }
}
