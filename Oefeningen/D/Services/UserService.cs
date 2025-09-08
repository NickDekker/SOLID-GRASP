public class UserService
{
    private readonly UserRepository _userRepository = new UserRepository();

    public void RegisterUser(string username)
    {
        _userRepository.AddUser(username);
    }
}