using D.Database;

public class UserRepository : IUserRepository
{
    private readonly IStorageImplementation _dataBase;

    public UserRepository(IStorageImplementation database)
    {
        _dataBase = database;
    }

    public void AddUser(string username)
    {
        _dataBase.SaveUser(username);
    }
}