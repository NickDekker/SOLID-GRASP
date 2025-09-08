using D.Database;

public class UserRepository
{
    private readonly FakeSqlDbImplementation _dataBase;

    public UserRepository()
    {
        _dataBase = new FakeSqlDbImplementation(); 
    }

    public void AddUser(string username)
    {
        _dataBase.SaveUser(username);
    }
}