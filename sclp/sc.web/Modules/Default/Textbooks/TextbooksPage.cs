
namespace sc.Default.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Default/Textbooks"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.TextbooksRow))]
    public class TextbooksController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Default/Textbooks/TextbooksIndex.cshtml");
        }
    }
}