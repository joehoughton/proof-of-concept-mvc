namespace proof_of_concept_mvc.Application.Users
{
    using proof_of_concept_mvc.Domain.Users;
    using proof_of_concept_mvc.Domain.Users.Dto;

    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository organisationRepository)
        {
            _userRepository = organisationRepository;
        }

        public UserDetailDto GetUserDetails(string currentUserId)
        {
            var result = this._userRepository.GetUserDetails(currentUserId);
            return result;
        }

        public void UpdateUserDetails(UserDetailDto userDetailDto)
        {
            _userRepository.UpdateUserDetails(userDetailDto);
        }
    }
}
