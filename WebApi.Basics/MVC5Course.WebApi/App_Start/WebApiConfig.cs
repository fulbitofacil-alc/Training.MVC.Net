using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using MVC5Course.WebApi.Filters;

namespace MVC5Course.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Filters.Add(new ValidationErrorHandlerFilterAttribute());  // filtro global
            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "mywebapi/{orgid}/{controller}/{id}",
            //    defaults: new {id = RouteParameter.Optional}, 
            //    constraints: new {orgid = @"\d+"}
            //    );

            //config.Routes.MapHttpRoute(name: "RpcApi",
            //    routeTemplate: "api/{controller}/{action}/{id}",
            //  defaults: new { id = RouteParameter.Optional }
            //  );
             config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new {id = RouteParameter.Optional},
                constraints: new { id=@"\d+" }
                );
            config.Routes.MapHttpRoute(
                name: "ActionApi",
                routeTemplate: "api/{controller}/{id}/{action}",
                defaults: new { id = RouteParameter.Optional },
                constraints: new { id=@"\d+" }
                );
            config.Routes.MapHttpRoute(
              name: "OfficeApi",
              routeTemplate: "api/{controller}/{office}/{id}",
              defaults: new { office ="all", id = RouteParameter.Optional }
              );
           
        }
    }
}
