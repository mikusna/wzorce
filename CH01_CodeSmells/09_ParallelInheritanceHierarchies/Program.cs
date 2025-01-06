using System;

public interface ILogger
{
    void LogMessage();
}

public class FileLogger : ILogger
{
    public void LogMessage()
    {
        Console.WriteLine("Logging message to file.");
    }
}

public class DatabaseLogger : ILogger
{
    public void LogMessage()
    {
        Console.WriteLine("Logging message to database.");
    }
}

public interface IExporter
{
    void ExportData();
}

public class XmlExporter : IExporter
{
    public void ExportData()
    {
        Console.WriteLine("Exporting data to XML.");
    }
}

public class JsonExporter : IExporter
{
    public void ExportData()
    {
        Console.WriteLine("Exporting data to JSON.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        ILogger fileLogger = new FileLogger();
        fileLogger.LogMessage();

        ILogger dbLogger = new DatabaseLogger();
        dbLogger.LogMessage();

        IExporter xmlExporter = new XmlExporter();
        xmlExporter.ExportData();

        IExporter jsonExporter = new JsonExporter();
        jsonExporter.ExportData();

        Console.ReadKey();
    }
}