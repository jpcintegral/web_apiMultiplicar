using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace webApiV1
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
              //BundleConfig.RegisterBundles(BundleTable.Bundles);
           /*GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings
           .ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize;
           //Linea para definir el formato con el q    ue regresa la informacion
           GlobalConfiguration.Configuration.Formatters
           .Remove(GlobalConfiguration.Configuration.Formatters.XmlFormatter);*/
        }
    }
}
