namespace proof_of_concept.Domain.Organisation
{
    using proof_of_concept.Domain.Organisation.Dto;

    public interface IOrganisationRepository
    {
        OrganisationDto GetByUserId(string userId);
    }
}
