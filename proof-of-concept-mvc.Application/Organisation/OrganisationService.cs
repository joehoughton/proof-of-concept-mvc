namespace proof_of_concept_mvc.Application.Organisation
{
    using proof_of_concept_mvc.Domain.Organisation;
    using proof_of_concept_mvc.Domain.Organisation.Dto;

    public class OrganisationService : IOrganisationService
    {
        private readonly IOrganisationRepository _organisationRepository;

        public OrganisationService(IOrganisationRepository organisationRepository)
        {
            _organisationRepository = organisationRepository;
        }

        public OrganisationDto GetUserOrganisation(string currentUserId)
        {
            var result = this._organisationRepository.GetByUserId(currentUserId);
            return result;
        }
    }
}
