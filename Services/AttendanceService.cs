using EventEase.Models;

namespace EventEase.Services;

public class AttendanceService
{
    private readonly List<Attendance> _attendances = new();
    private readonly RegistrationService _registrationService;
    private readonly EventService _eventService;

    public AttendanceService(RegistrationService registrationService, EventService eventService)
    {
        _registrationService = registrationService;
        _eventService = eventService;
    }

    public List<Attendance> GetAllAttendances()
    {
        // Sync attendances with registrations
        var registrations = _registrationService.GetAllRegistrations();
        foreach (var reg in registrations)
        {
            if (!_attendances.Any(a => a.RegistrationId == reg.Id))
            {
                var ev = _eventService.GetEventById(reg.EventId);
                if (ev != null)
                {
                    _attendances.Add(new Attendance
                    {
                        Id = _attendances.Count + 1,
                        RegistrationId = reg.Id,
                        Registration = reg,
                        Event = ev,
                        IsPresent = false
                    });
                }
            }
        }
        return _attendances;
    }

    public void UpdateAttendance(int id, bool isPresent)
    {
        var attendance = _attendances.FirstOrDefault(a => a.Id == id);
        if (attendance != null)
        {
            attendance.IsPresent = isPresent;
        }
    }
}
