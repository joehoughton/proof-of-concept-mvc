namespace proof_of_concept.Domain.Organisation
{
    using System.Linq;
    using System.Data.Entity;
    using proof_of_concept.Domain.Data;
    using proof_of_concept.Domain.Organisation.Dto;

    class OrganisationRepository : IOrganisationRepository
    {
        private readonly SparebedsContext _context;

        
        public OrganisationRepository(SparebedsContext context)
        {
            _context = context;
        }

        public OrganisationDto GetByUserId(string currentUserId)
        {
             var userOrganisation = _context.UserDetails
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
