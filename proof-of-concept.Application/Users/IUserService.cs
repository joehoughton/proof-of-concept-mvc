namespace proof_of_concept.Application.Users
{
    using proof_of_concept.Domain.Users.Dto;

    public interface IUserService
    {
        UserDetailDto GetUserDetails(string currentUserId);
        void UpdateUserDetails(UserDetailDto userDetailDto);
    }
}
