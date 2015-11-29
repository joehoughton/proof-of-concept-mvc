namespace proof_of_concept.Application.Organisation
{
    using proof_of_concept.Domain.Organisation.Dto;

    public interface IOrganisationService
    {
        OrganisationDto GetUserOrganisation(string currentUserId);
    }
}
