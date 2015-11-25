namespace proof_of_concept_mvc.Controllers
{
    using System.Web.Mvc;

    using proof_of_concept.Application.People;

    public class HomeController : Controller
    {
        private readonly IPeopleService _peopleService;

        public HomeController(IPeopleService peopleService)
        {
            _peopleService = peopleService;
        }

        public ActionResult Index()
        {
            var people = _peopleService.All();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}