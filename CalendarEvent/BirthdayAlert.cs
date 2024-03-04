using System.Globalization;

namespace CalendarEvent;

public class BirthdayAlert : Alert
{
    
    public List<Person> ListOfPerson { get; set; }

    public BirthdayAlert(List<Person> listOfPerson)
    {
        ListOfPerson = listOfPerson;
    }
    
    public override void Trigger(object? sender, MessageArgs arg)
    {
        string toDay = $"{arg.DayNumber:D2}/{((int)arg.Month + 1):D2}/{arg.Year:D4}";
        if (DateTime.TryParseExact(toDay, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None,
                out DateTime dateOfTheDay))
        {
            bool isWish = false;
            foreach (Person person in ListOfPerson)
            {
                
                if (person.Birthday == dateOfTheDay)
                {
                    if (!isWish)
                    {
                        Console.Write(" Happy Birthday");
                        isWish = !isWish;
                    }
                    Console.Write($" {person.Name}!");
                }
            }
        }
    }
}