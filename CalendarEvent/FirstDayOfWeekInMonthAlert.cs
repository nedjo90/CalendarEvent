namespace CalendarEvent;

public class FirstDayOfWeekInMonthAlert : Alert
{
    public Day Day { get; set; }

    public FirstDayOfWeekInMonthAlert(Day day)
    {
        this.Day = day;
    }
    public override void Trigger(object? sender, MessageArgs arg)
    {
        if (arg.DayNumber <= 7 && arg.Day == Day)
            Console.Write($" It's the first {Day} of {arg.Month}");
    }
}