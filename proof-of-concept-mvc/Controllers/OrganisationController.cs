namespace proof_of_concept_mvc.Controllers
{
    using System.Web.Mvc;
    using Microsoft.AspNet.Identity;
    using proof_of_concept.Application.Organisation;

    [Authorize]
    public class OrganisationController : Controller
    {
        private readonly IOrganisationService _organisationService;

        public OrganisationController(IOrganisationService organisationService)
        {
            _organisationService = organisationService;
        }

        // GET: Organisation
        public ActionResult Index()
        {
            string currentUserId = User.Identity.GetUserId();
            var organisation = _organisationService.GetUserOrganisation(currentUserId);
            return View(organisation);
        }

    }
}
