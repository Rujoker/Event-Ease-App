# EventEaseApp

EventEaseApp is a Blazor WebAssembly application for managing events, registrations, and attendance tracking. It demonstrates modern state management, component-based architecture, and best practices for building interactive web apps with .NET.

---

## Features

- **Event Listing:**  
  Browse a paginated list of upcoming events.

- **Event Details:**  
  View detailed information about each event, including date, location, and a list of registered attendees.

- **Registration:**  
  Register for any event using a simple form with real-time validation.

- **Attendance Tracking:**  
  See who has registered for each event. Attendance is tracked and displayed on the event details page.

- **User Session Management:**  
  User information (name and email) is tracked during the session for a personalized experience.

- **Navigation:**  
  Seamless navigation between event list, details, and registration pages.

- **Input Validation:**  
  All forms use data annotation attributes for robust validation and user feedback.

---

## Getting Started

### Prerequisites

- [.NET 7.0 SDK or later](https://dotnet.microsoft.com/download)
- [Node.js](https://nodejs.org/) (for some Blazor tooling, optional)

### Running the App

1. **Clone the repository:**
    ```bash
    git clone https://github.com/yourusername/EventEaseApp.git
    cd EventEaseApp
    ```

2. **Restore dependencies and run:**
    ```bash
    dotnet restore
    dotnet run
    ```

3. **Open in browser:**  
   Navigate to `https://localhost:5001` (or the URL shown in your terminal).

---

## Project Structure

- `Pages/Home.razor`  
  Main event list with pagination.

- `Pages/Details.razor`  
  Event details, including attendee list and navigation.

- `Pages/Register.razor`  
  Registration form with validation.

- `Components/EventCard.razor`  
  Reusable component for displaying event summary.

- `Services/UserSessionService.cs`  
  Tracks user session state (name, email).

- `Services/AttendanceService.cs`  
  Tracks event attendance and provides attendee lists.

- `App.razor`  
  Configures routing and not-found handling.

---

## How It Works

- **Events** are displayed on the home page.  
- **Details** for each event can be viewed, including a list of registered attendees.
- **Registration** is available for each event; upon successful registration, the user is added to the attendee list.
- **State management** is handled via DI services for user session and attendance, making the app scalable and maintainable.

---

## Customization

- To add or edit events, modify the `allEvents` list in `Home.razor` and `Details.razor`.  
- For production, connect to a real database and use unique IDs for events.

---

## Contributing

Pull requests are welcome! For major changes, please open an issue first to discuss what you would like to change.

---

## License

This project is licensed under the MIT License.

---

## Acknowledgements

- Built with [Blazor WebAssembly](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor)
- Inspired by real-world event management needs
