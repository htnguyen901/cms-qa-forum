using System.Web.Mvc;

namespace CMSFinal.Areas.QaCoordinator
{
    public class QaCoordinatorAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "QaCoordinator";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "QaCoordinator_default",
                "QaCoordinator/{controller}/{action}/{id}",
                new { action = "Index", Controller = "Home", id = UrlParameter.Optional },
                namespaces: new[] { "CMSFinal.Areas.QaCoordinator.Controllers" }
            );
        }
    }
}