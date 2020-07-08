using System.Linq;
using System.Web.Http;
using WebActivatorEx;
using Swashbuckle.Application;
using LitService;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]
namespace LitService
{
    public class SwaggerConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.EnableSwagger(c =>
            {
                c.SingleApiVersion("v1", "");
                c.IncludeXmlComments(GetXmlCommentsPath());
                c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
            }).EnableSwaggerUi();
        }
        private static string GetXmlCommentsPath()
        {
            return string.Format(@"{0}\Swagger.XML", System.AppDomain.CurrentDomain.BaseDirectory);
        }
    }
}
