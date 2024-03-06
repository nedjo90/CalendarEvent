using System.Globalization;

namespace CalendarEvent;

public class HolidayAlert : Alert
{
    private List<PublicHolidays> _listOfPublicHolidays;

    public HolidayAlert(List<PublicHolidays> publicHolidays)
    {
        _listOfPublicHolidays = publicHolidays;
    }
    public override void Trigger(object? sender, CalendarArgs arg)
    {
            foreach (PublicHolidays holiday in _listOfPublicHolidays)
            {
                if (holiday.Day == arg.DayNumber && holiday.Month == (int)arg.Month + 1)
                {
                    Console.Write($" We are in Holiday it's {holiday.NameOfTheDay}");
                }
            }
    }
}