namespace CalendarEvent;

class Program
{
    static void Main(string[] args)
    {
        Calendar cal = new Calendar();
        Alert alert = new Alert();
        cal.OnNewDay += alert.LaunchAlert;
        cal.OnNewMonth += alert.LaunchAlert;
        cal.OnNewYear += alert.LaunchAlert;
        for (int i = 0; i < 1000; i++)
        {
            cal.NextDay();
        }
    }
}