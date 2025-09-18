using D.Database;

public class UserService
{
    private readonly FakeSqlDbImplementation _dataBase;

    public UserService()
    {
        _dataBase = new FakeSqlDbImplementation();
    }

    public void RegisterUser(string username)
    {
        _dataBase.SaveUser(username);
    }
}