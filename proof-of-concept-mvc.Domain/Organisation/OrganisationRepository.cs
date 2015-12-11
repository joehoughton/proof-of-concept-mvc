namespace proof_of_concept_mvc.Domain.Organisation
{
    using System.Data.Entity;
    using System.Linq;

    using proof_of_concept_mvc.Domain.Data;
    using proof_of_concept_mvc.Domain.Organisation.Dto;

    class OrganisationRepository : IOrganisationRepository
    {
        private readonly SparebedsContext _context;

        public OrganisationRepository(SparebedsContext context)
        {
            _context = context;
        }

        public OrganisationDto GetByUserId(string currentUserId)
        {
             var userOrganisation = this._context.UserDetails
            .Include(o => o.Organisation)
            .Single(o => o.AspNetUser.Id == currentUserId).Organisation;

            var organisationDto = new OrganisationDto(
                userOrganisation.Name,
                userOrganisation.OrganisationType.Type
             );

            return organisationDto;
        }
    }
}
