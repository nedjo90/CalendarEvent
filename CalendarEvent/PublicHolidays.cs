namespace CalendarEvent;

public class PublicHolidays
{
    public string NameOfTheDay {
        get;
        set;
    }
    public int Day { get; set; }
    public int Month { get; set; }

    public PublicHolidays(string nameOfTheDay, int day, int month)
    {
        this.NameOfTheDay = nameOfTheDay;
        Day = day;
        Month = month;
    }
}