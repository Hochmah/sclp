
namespace sc.Default.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Default/Materials"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.MaterialsRow))]
    public class MaterialsController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Default/Materials/MaterialsIndex.cshtml");
        }
    }
}