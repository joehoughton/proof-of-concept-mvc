namespace proof_of_concept_mvc.Domain.Organisation.Models
{
    public class Organisation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual OrganisationType OrganisationType { get; set; }
    }
}
