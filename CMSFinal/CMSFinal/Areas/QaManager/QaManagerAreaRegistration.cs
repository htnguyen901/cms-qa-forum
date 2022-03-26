using System.Web.Mvc;

namespace CMSFinal.Areas.QaManager
{
    public class QaManagerAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "QaManager";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "QaManager_default",
                "QaManager/{controller}/{action}/{id}",
                new { action = "Index", controller= "QAManager", id = UrlParameter.Optional }
                //namespaces: new[] { "CMSFinal.Areas.QAManager.Controllers" }
            );
        }
    }
}