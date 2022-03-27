using System.Web.Mvc;

namespace CMSFinal.Areas.Administrator
{
    public class AdministratorAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Administrator";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Administrator_default",
                "Administrator/{controller}/{action}/{id}",
                new { action = "Index", Controller= "Home" , id = UrlParameter.Optional },
               namespaces: new[] { "CMSFinal.Areas.Administrator.Controllers" }
            );
        }
    }
}