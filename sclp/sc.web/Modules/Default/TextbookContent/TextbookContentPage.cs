
namespace sc.Default.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Default/TextbookContent"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.TextbookContentRow))]
    public class TextbookContentController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Default/TextbookContent/TextbookContentIndex.cshtml");
        }
    }
}