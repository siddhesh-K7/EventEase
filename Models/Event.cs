namespace EventEase.Models;

public class Event
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public string Time { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public int AvailableSeats { get; set; }
    public int MaximumCapacity { get; set; }
    public bool IsRegistrationOpen => AvailableSeats > 0;
}
