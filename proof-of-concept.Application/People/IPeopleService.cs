namespace proof_of_concept.Application.People
{
    using System.Collections.Generic;
    using proof_of_concept.Models.People.Models;

    public interface IPeopleService
    {
        List<People> All();
    }
}