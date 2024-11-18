using Bridge;

public class Program
{
    static void Main(string[] args)
    {
        var linux = new Linux();
        linux.userInterface = new ConsoleInterface();
        linux.DisplayMenu();

        linux.userInterface = new GraphicInterface();
        linux.DisplayMenu();


        Console.ReadKey();
    }
}