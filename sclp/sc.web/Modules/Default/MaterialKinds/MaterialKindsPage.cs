
namespace sc.Default.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Default/MaterialKinds"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.MaterialKindsRow))]
    public class MaterialKindsController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Default/MaterialKinds/MaterialKindsIndex.cshtml");
        }
    }
}