namespace CalendarEvent;

public abstract class Alert
{
    public abstract void Trigger(object? sender, CalendarArgs arg);
}