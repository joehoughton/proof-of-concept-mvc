namespace proof_of_concept_mvc.Application.Organisation
{
    using proof_of_concept_mvc.Domain.Organisation.Dto;

    public interface IOrganisationService
    {
        OrganisationDto GetUserOrganisation(string currentUserId);
    }
}
