namespace proof_of_concept.Domain.People
{
    using System.Collections.Generic;

    using proof_of_concept.Models.People.Models;

    public interface IPeopleRepository
    {
        List<People> All();
    }
}
