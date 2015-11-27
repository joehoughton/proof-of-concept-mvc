using System.Web.Mvc;

namespace proof_of_concept_mvc.Controllers
{
    [Authorize]
    public class OrganisationController : Controller
    {
        // GET: Organisation
        public ActionResult Index()
        {
            return View();
        }

    }
}
