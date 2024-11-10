using DataClumps;

class Program
{
    static void Main(string[] args)
    {
        EventDetails eventDetails = new EventDetails("First date", DateTime.Now, "Pool");
        RegisterEvent(eventDetails);
        Console.ReadKey();
    }

    public static void RegisterEvent(EventDetails eventDetails)
    {
        Console.WriteLine($"Event: {eventDetails.EventName}, Date: {eventDetails.EventDate}, Location: {eventDetails.Location}");
    }
}