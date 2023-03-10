using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using WebDatVe.Models;

namespace WebDatVe.Attributes
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, Inherited = true, AllowMultiple = true)]
    public class PemisitonAttribute : AuthorizeAttribute
    {
        private string quyen;
        public PemisitonAttribute(string str)
        {
            quyen = str;
        }

        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            HttpCookie cookie = filterContext.HttpContext.Request.Cookies.Get("MaAdmin");
            var ma = int.Parse(cookie.Value);

            var db = new WebDatVePhimEntities();
            var item = db.TaiKhoans.FirstOrDefault(x => x.PhanQuyen.DanhSach.Contains("," + quyen + ",") && x.MaTaiKhoan == ma);
            if (item == null)
            {
                filterContext.Result = new RedirectToRouteResult(new
               RouteValueDictionary(new { Areas = string.Empty, Controller = "BangDieuKhien", Action = "Index" }));
            }
        }
    }
}