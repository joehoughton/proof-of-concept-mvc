namespace proof_of_concept_mvc.Controllers.Organisation
{
    using System.Web.Mvc;
    using Microsoft.AspNet.Identity;
    using proof_of_concept_mvc.Domain.Organisation;

    [Authorize]
    public class OrganisationController : Controller
    {
        private readonly IOrganisationRepository _organisationRepository;

        public OrganisationController(IOrganisationRepository organisationRepository)
        {
            _organisationRepository = organisationRepository;
        }

        // GET: Organisation
        public ActionResult Index()
        {
            string currentUserId = User.Identity.GetUserId();
            var organisation = _organisationRepository.GetByUserId(currentUserId);
            return View(organisation);
        }

    }
}
