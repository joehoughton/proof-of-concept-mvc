namespace proof_of_concept.Domain.Users.Dto
{
    public class UserDetailDto
    {
        public UserDetailDto() { }
        public UserDetailDto(string id, string name, string telephone, string mobile, string email, bool emailNotification, bool smsNotification)
        {
            Id = id;
            Name = name;
            Telephone = telephone;
            Mobile = mobile;
            Email = email;
            EmailNotification = emailNotification;
            SmsNotification = smsNotification;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public bool EmailNotification { get; set; }
        public bool SmsNotification { get; set; }
    }
}
