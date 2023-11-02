using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using NVelocity.App;

namespace hd.sample.velocity.web.netframework
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // Khởi tạo và cấu hình VelocityEngine
            
            VelocityEngine ve = new VelocityEngine();
            ve.Init();

            // Lưu trữ VelocityEngine trong Application để sử dụng chung
            Application["VelocityEngine"] = ve;
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}