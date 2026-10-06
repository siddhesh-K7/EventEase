namespace EventEase.Models;

public class Attendance
{
    public int Id { get; set; }
    public int RegistrationId { get; set; }
    public Registration Registration { get; set; } = new();
    public Event Event { get; set; } = new();
    public bool IsPresent { get; set; }
}
