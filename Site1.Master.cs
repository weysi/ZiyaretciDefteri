using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CFZiyaretciDefteri
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        public string scriptler = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.Url.AbsolutePath != "/Giris.aspx" && Session["GirisYapanID"] == null)
            {
                scriptler = "yonlendir();";
                //Response.Redirect("/Giris.aspx");
            }
        }
    }
}