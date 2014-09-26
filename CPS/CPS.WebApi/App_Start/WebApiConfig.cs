using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using CPS.WebApi.Converters;
using CPS.WebApi.Handlers;

namespace CPS.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            config.MessageHandlers
                .Add(new CultureHandler());

            config.Formatters.JsonFormatter
                .SerializerSettings
                    .Converters.Add(new NumberConverter());

            config.Formatters.JsonFormatter
            .SerializerSettings
                .Converters.Add(new DateTimeConverter());
        }
    }
}
