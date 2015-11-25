namespace proof_of_concept.Application.People
{
    using System.Collections.Generic;
    using proof_of_concept.Domain.People;
    using proof_of_concept.Models.People.Models;

    public class PeopleService : IPeopleService
    {
        private readonly IPeopleRepository _peopleRepository;

        public PeopleService(IPeopleRepository repository)
        {
            _peopleRepository = repository;
        }

        public List<People> All()
        {
            return _peopleRepository.All();
        }
    }
}
