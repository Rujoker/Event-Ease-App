using System.Collections.Generic;

namespace EventEaseApp.Services
{
    public class AttendanceService
    {
        // Key: Event Title, Value: List of attendee emails
        private readonly Dictionary<string, HashSet<string>> _attendance = new();

        public IReadOnlyDictionary<string, HashSet<string>> Attendance => _attendance;

        public void RegisterAttendance(string eventTitle, string userEmail)
        {
            if (string.IsNullOrWhiteSpace(eventTitle) || string.IsNullOrWhiteSpace(userEmail))
                return;

            if (!_attendance.ContainsKey(eventTitle))
                _attendance[eventTitle] = new HashSet<string>();

            _attendance[eventTitle].Add(userEmail);
        }

        public int GetAttendanceCount(string eventTitle)
        {
            return _attendance.TryGetValue(eventTitle, out var attendees) ? attendees.Count : 0;
        }

        public bool IsUserAttending(string eventTitle, string userEmail)
        {
            return _attendance.TryGetValue(eventTitle, out var attendees) && attendees.Contains(userEmail);
        }
    }
}