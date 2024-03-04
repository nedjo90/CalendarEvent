namespace CalendarEvent;

class Program
{
    static void Main(string[] args)
    {
        Calendar cal = new Calendar();
        List<Person> listOfPerson =
        [
            new Person("Jacky", new DateTime(2, 10, 11)),
            new Person("Michel", new DateTime(2, 10, 10)),
            new Person("Jean", new DateTime(2, 10, 10)),
            new Person("Jean", new DateTime(2, 10, 7))
        ];
        DailyAlert daily = new DailyAlert();
        BirthdayAlert birthdayAlert = new BirthdayAlert(listOfPerson);
        List<PublicHolidays> listOfPublicHolidays =
        [
            new PublicHolidays("New Year", 1, 1),
            new PublicHolidays("Holy Friday", 29, 3),
            new PublicHolidays("Easter Monday", 1, 4),
            new PublicHolidays("Labor Day", 1, 5),
            new PublicHolidays("WWII Victory Day", 8, 5),
            new PublicHolidays("Ascension Day", 9, 5),
            new PublicHolidays("Pentecost", 20, 5),
            new PublicHolidays("National Day(Bastille Day)", 14, 7),
            new PublicHolidays("Assumption of Mary", 15, 8),
            new PublicHolidays("All Saints' Day", 1, 11),
            new PublicHolidays("Christmas Day", 25, 12),
            new PublicHolidays("Saint-Etienne Day", 26, 12)
        ];
        HolidayAlert holidayAlert = new HolidayAlert(listOfPublicHolidays);
        FirstDayOfWeekInMonthAlert firstWednesday = new FirstDayOfWeekInMonthAlert(Day.Wednesday);
        FirstDayOfWeekInMonthAlert firstSunday = new FirstDayOfWeekInMonthAlert(Day.Sunday);
        cal.DailyMessage += (sender, messageArgs) => daily.Trigger(sender, messageArgs);
        cal.DailyMessage += (sender, messageArgs) => holidayAlert.Trigger(sender, messageArgs); 
        cal.DailyMessage += (sender, messageArgs) => birthdayAlert.Trigger(sender, messageArgs); 
        cal.DailyMessage += (sender, messageArgs) => firstWednesday.Trigger(sender, messageArgs);
        cal.DailyMessage += (sender, messageArgs) => firstSunday.Trigger(sender, messageArgs);
        
        for (int i = 0; i < 1000; i++)
        {
            cal.NextDay();
        }
    }
}