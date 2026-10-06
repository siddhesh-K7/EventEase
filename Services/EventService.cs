using EventEase.Models;

namespace EventEase.Services;

public class EventService
{
    private List<Event> _events = new();

    public EventService()
    {
        // Sample data for assignment rubric
        _events = new List<Event>
        {
            new Event { Id = 1, Name = "Tech Innovation Summit", Description = "Explore the latest in tech.", Date = DateTime.Now.AddDays(10), Time = "09:00 AM", Location = "Main Hall", Category = "Technology", MaximumCapacity = 100, AvailableSeats = 100 },
            new Event { Id = 2, Name = "AI & Machine Learning Workshop", Description = "Hands-on AI workshop.", Date = DateTime.Now.AddDays(15), Time = "10:30 AM", Location = "Room 201", Category = "Workshop", MaximumCapacity = 50, AvailableSeats = 50 },
            new Event { Id = 3, Name = "Web Development Bootcamp", Description = "Learn Blazor and .NET.", Date = DateTime.Now.AddDays(20), Time = "08:00 AM", Location = "Online", Category = "Bootcamp", MaximumCapacity = 200, AvailableSeats = 200 },
            new Event { Id = 4, Name = "Cloud Computing Seminar", Description = "AWS and Azure insights.", Date = DateTime.Now.AddDays(25), Time = "02:00 PM", Location = "Auditorium", Category = "Seminar", MaximumCapacity = 150, AvailableSeats = 150 },
            new Event { Id = 5, Name = "Cyber Security Conference", Description = "Security best practices.", Date = DateTime.Now.AddDays(30), Time = "11:00 AM", Location = "Main Hall", Category = "Conference", MaximumCapacity = 300, AvailableSeats = 300 },
            new Event { Id = 6, Name = "Hackathon 2026", Description = "Build the future in 48 hours.", Date = DateTime.Now.AddDays(40), Time = "06:00 PM", Location = "Innovation Lab", Category = "Hackathon", MaximumCapacity = 80, AvailableSeats = 80 }
        };
    }

    public List<Event> GetAllEvents() => _events;

    public Event? GetEventById(int id) => _events.FirstOrDefault(e => e.Id == id);

    public bool ReduceAvailableSeats(int eventId, int numberOfTickets)
    {
        var ev = GetEventById(eventId);
        if (ev != null && ev.AvailableSeats >= numberOfTickets)
        {
            ev.AvailableSeats -= numberOfTickets;
            return true;
        }
        return false;
    }
}
