using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace SimpleRestSand
{
    public static class WebApiConfig
    {
        // Il config gestisce la configurazione di parte del servizio
        public static void Register(HttpConfiguration config)
        {
            // Servizi e configurazione dell'API Web


            //con queste due rughe si decide il routing delle chiamate 
            // utilizzando routeTemplate: "api/{controller}/{id}" si fa in modo che per chiamare i vari metodi si debba utilizzare 
            // una url di questo genere :
            //http://localhost:50762/api/Person
            // Dove http://localhost:50762/ = root del servizio
            //      /api/ = stabilito da questo config come fosse un Namespace che raggruppa le Api .. volendo si potrebbe cambiare arbitrariamente
            //      /Person / Utilizza il nome del controller PersonController volendolo cambiare basta cambiare la parte prima di Controller Person
            // quindi nella Url per la chiamata deve corrispondere al nome assegnato al Controller
            //  {id} i parametri o il parametro che si vuole passare in input per la Get

            // Route dell'API Web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
