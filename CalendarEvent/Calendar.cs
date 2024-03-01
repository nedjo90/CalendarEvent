namespace CalendarEvent;

public class Calendar
{
    public int Year { get; private set; }
    public Month Month { get; private set; }
    public Day Day { get; private set; }
    public int DayNumber { get; private set; }

    public event Action<string> OnNewDay;
    public event Action<string> OnNewMonth;
    public event Action<string> OnNewYear;
    

    public Calendar()
    {
        Year = 0;
        Month = 0;
        Day = 0;
        DayNumber = 1;
    }

    public void NextDay()
    {
        if (DayNumber == 30)
        {
            DayNumber = 1;
            NextMonth();
        }
        else
        {
            DayNumber++;
        }
        if (Day == Day.Sunday)
            Day = Day.Monday;
        else
        {
            Day++;
        }
        if (OnNewDay != null)
            OnNewDay($"Hello, {Day,-12}{DayNumber,-5}{Month,-10}{Year}");

    }

    public void NextMonth()
    {
        if (Month == Month.December)
        {
            Month = Month.January;
            NextYear();
        }
        else
        {
            Month++;
        }
        if (OnNewMonth != null)
            OnNewMonth($"It's the first day of {Month}");
    }
    public void NextYear()
    {
        Year++;
        if (OnNewYear != null)
            OnNewYear("Happy New Year !");
    }

    public override string ToString()
    {
        string date = $"{Day,-12}{DayNumber,-5}{Month,-10}{Year}";
        return date;
    }
}