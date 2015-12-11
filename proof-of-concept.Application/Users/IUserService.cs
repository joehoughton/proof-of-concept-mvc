namespace proof_of_concept_mvc.Application.Users
{
    using proof_of_concept_mvc.Domain.Users.Dto;

    public interface IUserService
    {
        UserDetailDto GetUserDetails(string currentUserId);
        void UpdateUserDetails(UserDetailDto userDetailDto);
    }
}
