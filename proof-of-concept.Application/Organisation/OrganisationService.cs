namespace proof_of_concept.Application.Organisation
{
    using proof_of_concept.Domain.Organisation.Dto;
    using proof_of_concept.Domain.Organisation;

    public class OrganisationService : IOrganisationService
    {
        private readonly IOrganisationRepository _organisationRepository;
        public OrganisationService(IOrganisationRepository organisationRepository)
        {
            _organisationRepository = organisationRepository;
        }

        public OrganisationDto GetUserOrganisation(string currentUserId)
        {
            var result = _organisationRepository.GetByUserId(currentUserId);
            return result;
        }
    }
}
