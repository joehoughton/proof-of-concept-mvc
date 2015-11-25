namespace proof_of_concept.Domain.People
{
    using System.Collections.Generic;
    using proof_of_concept.Domain.Models;
    using proof_of_concept.Models.People.Models;

    public class PeopleRepository : IPeopleRepository
    {
        private readonly SparebedsContext _context;

        public PeopleRepository(SparebedsContext context)
        {
            _context = context;
        }

        public List<People> All()
        {
            var list = new List<People> { new People() { Name = "Joe" }, new People() { Name = "Hamish" } };
            return list;
        }
    }
}
