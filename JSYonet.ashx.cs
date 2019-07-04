using CFZiyaretciDefteri.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CFZiyaretciDefteri
{
    /// <summary>
    /// Summary description for JSYonet
    /// </summary>
    public class JSYonet : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            var id = context.Request.QueryString["silinecek"];
            ZiyaretContext ctx = new ZiyaretContext();
            var msj = ctx.Mesajlar.Find(Convert.ToInt32(id));
            ctx.Mesajlar.Remove(msj);
            ctx.SaveChanges();
            context.Response.Write("true");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}