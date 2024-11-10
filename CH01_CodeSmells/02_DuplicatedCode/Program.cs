using System;

class Program
{
    static void Main(string[] args)
    {
        DuplicatedCode logger = new DuplicatedCode();

        //błąd
        logger.LogError("This is an error.", DateTime.Now);

        //ostrzeżenie
        logger.LogWarning("This is a warning.", DateTime.Now);
    }
}

public class DuplicatedCode
{
    //metoda do formatowania komunikatów
    private string FormatLogMessage(string logType, string message, DateTime timestamp)
    {
        string formattedTimestamp = timestamp.ToString("yyyy-MM-dd HH:mm:ss");
        return $"{logType}: [{formattedTimestamp}] {message}";
    }

    //metoda logowania błędów
    public void LogError(string message, DateTime timestamp)
    {
        string formattedMessage = FormatLogMessage("ERROR", message, timestamp);
        Console.WriteLine(formattedMessage);
    }

    //metoda logowania ostrzeżeń
    public void LogWarning(string message, DateTime timestamp)
    {
        string formattedMessage = FormatLogMessage("WARNING", message, timestamp);
        Console.WriteLine(formattedMessage);

        Console.ReadKey();
    }

}
