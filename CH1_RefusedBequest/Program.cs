using RefusedBequest;

class Program
{
    static void Main(string[] args)
    {
        Manager manager = new Manager {Name = "Alicja", Position = "Manager" };
        manager.Work();
        manager.ManageTeam();

        Employee employee = new Employee {Name = "Jacek", Position = "Developer" };
        employee.Work();
        employee.AttendMeeting();
        Console.ReadKey();
    }
}
