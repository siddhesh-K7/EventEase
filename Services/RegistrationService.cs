using EventEase.Models;

namespace EventEase.Services;

public class RegistrationService
{
    private readonly List<Registration> _registrations = new();
    private int _nextId = 1;

    public Registration AddRegistration(Registration registration)
    {
        registration.Id = _nextId++;
        _registrations.Add(registration);
        return registration;
    }

    public List<Registration> GetAllRegistrations() => _registrations;
    
    public List<Registration> GetRegistrationsByEmail(string email) => 
        _registrations.Where(r => r.Email.Equals(email, StringComparison.OrdinalIgnoreCase)).ToList();
}
