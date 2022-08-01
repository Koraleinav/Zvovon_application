using System.Web.Http;
using WebActivatorEx;
using Zvovon_application;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace Zvovon_application
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration.EnableSwagger(c =>
            {
                c.SingleApiVersion("v1", "ZvovonWebAPI");
            })
                .EnableSwaggerUi();
        }
    }
}
