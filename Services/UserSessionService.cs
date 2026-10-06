using EventEase.Models;

namespace EventEase.Services;

public class UserSessionService
{
    public User? CurrentUser { get; private set; }
    public bool IsLoggedIn => CurrentUser != null;

    public event Action? OnChange;

    public void Login(string name, string email)
    {
        CurrentUser = new User { Name = name, Email = email };
        NotifyStateChanged();
    }

    public void Logout()
    {
        CurrentUser = null;
        NotifyStateChanged();
    }

    private void NotifyStateChanged() => OnChange?.Invoke();
}
