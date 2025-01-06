using System;

public class UserAccount
{
    public string Username { get; set; }
    public string Password { get; set; }

}

public class AuthenticationService
{
    public void Login(string username, string password)
    {
        Console.WriteLine("User logged in.");
    }

    public void Logout()
    {
        Console.WriteLine("User logged out.");
    }
}

public class UserReportGenerator
{
    public void GenerateReport(string username)
    {
        Console.WriteLine($"Generating report for user: {username}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        UserAccount userAccount = new UserAccount
        {
            Username = "john_doe",
            Password = "password123"
        };

        AuthenticationService authService = new AuthenticationService();
        authService.Login(userAccount.Username, userAccount.Password);

        UserReportGenerator reportGenerator = new UserReportGenerator();
        reportGenerator.GenerateReport(userAccount.Username);

        authService.Logout();
        Console.ReadKey();
    }
}
