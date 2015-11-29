namespace proof_of_concept.Domain.Users
{
    using proof_of_concept.Domain.Users.Dto;

    public interface IUserRepository
    {
        UserDetailDto GetUserDetails(string currentUserId);
        void UpdateUserDetails(UserDetailDto userDetailDto);
    }
}