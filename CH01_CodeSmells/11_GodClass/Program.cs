using System;

public class UserManager
{
    public void ManageUsers()
    {
        Console.WriteLine("Managing users.");
    }
}

public class SystemConfigurator
{
    public void ConfigureSystem()
    {
        Console.WriteLine("Configuring system.");
    }
}

public class LogRegistrar
{
    public void RegisterLog(string log)
    {
        Console.WriteLine($"Log: {log}");
    }
}

public class SystemReportGenerator
{
    public void GenerateSystemReport()
    {
        Console.WriteLine("System report generated.");
    }
}

public class AdminPanel
{
    private readonly UserManager _userManager;
    private readonly SystemConfigurator _systemConfigurator;
    private readonly LogRegistrar _logRegistrar;
    private readonly SystemReportGenerator _systemReportGenerator;

    public AdminPanel()
    {
        _userManager = new UserManager();
        _systemConfigurator = new SystemConfigurator();
        _logRegistrar = new LogRegistrar();
        _systemReportGenerator = new SystemReportGenerator();
    }

    public void ManageUsers()
    {
        _userManager.ManageUsers();
    }

    public void ConfigureSystem()
    {
        _systemConfigurator.ConfigureSystem();
    }

    public void RegisterLog(string log)
    {
        _logRegistrar.RegisterLog(log);
    }

    public void GenerateSystemReport()
    {
        _systemReportGenerator.GenerateSystemReport();
    }
}

class Program
{
    static void Main(string[] args)
    {
        AdminPanel adminPanel = new AdminPanel();

        adminPanel.ManageUsers();
        adminPanel.ConfigureSystem();
        adminPanel.RegisterLog("User logged in.");
        adminPanel.GenerateSystemReport();

        Console.ReadKey();
    }
}