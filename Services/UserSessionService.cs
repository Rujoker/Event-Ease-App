using System;

namespace EventEaseApp.Services
{
    public class UserSessionService
    {
        public string? UserName { get; private set; }
        public string? Email { get; private set; }
        public bool IsRegistered => !string.IsNullOrWhiteSpace(UserName) && !string.IsNullOrWhiteSpace(Email);

        public event Action? OnSessionChanged;

        public void Register(string name, string email)
        {
            UserName = name;
            Email = email;
            OnSessionChanged?.Invoke();
        }

        public void Logout()
        {
            UserName = null;
            Email = null;
            OnSessionChanged?.Invoke();
        }
    }
}