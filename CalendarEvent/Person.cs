namespace CalendarEvent;

public class Person
{
    public string Name { get; }

    public DateTime Birthday { get; }

    public Person(string name, DateTime birthday)
    {
        this.Name = name;
        Birthday = birthday;
    }

    public override int GetHashCode()
    {
        return Name.GetHashCode() + Birthday.GetHashCode() + this.GetHashCode();
    }
}