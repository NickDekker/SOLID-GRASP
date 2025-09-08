namespace D.Database;

public class FakeSqlDbImplementation
{
    public void SaveUser(string username)
    {
        // Doe zogenaamd dingen 
        Console.WriteLine($"User '{username}' added to database.");
    }
}
