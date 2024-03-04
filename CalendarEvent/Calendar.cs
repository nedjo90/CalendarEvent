namespace CalendarEvent;

public class Calendar
{
    public int Year { get; private set; }
    public Month Month { get; private set; }
    public Day Day { get; private set; }
    public int DayNumber { get; private set; }
    public event EventHandler<MessageArgs> DailyMessage;
    

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
        OnDailyMessage();
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
    }
    public void NextYear()
    {
        Year++;
    }

    public virtual void OnDailyMessage()
    {
        DailyMessage?.Invoke(this, new MessageArgs(Year, Month, Day, DayNumber));
    }

    public override string ToString()
    {
        string date = $"{Day,-12}{DayNumber,-5}{Month,-10}{Year}";
        return date;
    }
}