namespace CalendarEvent;

public class CalendarArgs : EventArgs
{
    public int Year { get; private set; }
    public Month Month { get; private set; }
    public Day Day { get; private set; }
    public int DayNumber { get; private set; }

    public CalendarArgs(int year, Month month, Day day, int dayNumber)
    {
        Year = year;
        Month = month;
        Day = day;
        DayNumber = dayNumber;
    }
}