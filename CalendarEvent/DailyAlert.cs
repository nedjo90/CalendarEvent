using System.Globalization;

namespace CalendarEvent;

public class DailyAlert : Alert
{
    public override void Trigger(object? sender, MessageArgs arg)
    {
        string toDisplay = $"\n{arg.DayNumber:D2}/{((int)arg.Month + 1):D2}/{arg.Year:D4}";
        Console.Write(toDisplay);
    }
}