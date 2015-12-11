namespace proof_of_concept_mvc.Domain.Organisation
{
    using proof_of_concept_mvc.Domain.Organisation.Dto;

    public interface IOrganisationRepository
    {
        OrganisationDto GetByUserId(string userId);
    }
}
