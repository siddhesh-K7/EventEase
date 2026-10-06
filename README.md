# EventEase

## Project Description
EventEase is a modern, responsive web application built with Blazor WebAssembly. It provides a comprehensive solution for managing event registrations, allowing users to discover events, register for tickets, manage their dashboard, and track attendance.

## Features
- **Event Catalog**: Browse a list of upcoming events with detailed information.
- **Event Registration**: Secure tickets through a robust registration form with comprehensive validation.
- **User Dashboard**: Track personal event registrations (requires login).
- **Attendance Tracker**: A management view to track and mark participants' attendance.
- **Responsive UI**: A professional and clean user interface built with Bootstrap.

## Technologies Used
- Blazor WebAssembly
- C#
- .NET 8.0
- Razor Components
- HTML5
- CSS3
- Bootstrap 5

## Project Structure
- `Components/`: Contains reusable UI components like `EventCard.razor`.
- `Pages/`: Contains routable views (`Home`, `Events`, `EventDetails`, `Register`, `Login`, `Dashboard`, `AttendanceTracker`).
- `Models/`: Defines data structures (`Event`, `Registration`, `User`, `Attendance`).
- `Services/`: Manages state and business logic (`EventService`, `RegistrationService`, `UserSessionService`, `AttendanceService`).
- `Layout/`: Defines application shell (`MainLayout`, `NavMenu`).
- `wwwroot/`: Static web assets, including CSS and index.html.
- `Program.cs`: Application entry point and Dependency Injection container.

## How to Run
Ensure you have the .NET SDK installed (preferably .NET 8.0). Open a terminal in the project directory and run:

```bash
dotnet restore
dotnet build
dotnet run
```
Navigate to the URL provided in the console (usually `http://localhost:5000` or `https://localhost:5001`).

## Application Pages
- **Home (`/`)**: Landing page highlighting upcoming events.
- **Events (`/events`)**: Lists all available events using the `EventCard` component.
- **Event Details (`/event/{id}`)**: Displays detailed information for a specific event.
- **Register (`/register` & `/register/{id}`)**: Form to register for an event. Includes validation.
- **Login (`/login`)**: Simple session login page.
- **Dashboard (`/dashboard`)**: Displays a user's current registrations (Protected route).
- **Attendance Tracker (`/attendance`)**: Shows statistics and a table to mark participants as present/absent.
- **About (`/about`)**: Information about the application.
- **Not Found**: Handles invalid routes gracefully via `App.razor`.

## Advanced Features
- **Registration validation**: Comprehensive `EditForm` with `DataAnnotationsValidator` enforcing required fields, email format, phone digits, and seat limits.
- **User session management**: A custom `UserSessionService` stores the logged-in user state and triggers UI updates (`StateHasChanged`) across components using events.
- **Attendance tracking**: `AttendanceService` automatically syncs with new registrations, calculating real-time statistics (total, present, absent, percentage) securely.
- **Performance optimization**: 
  - Usage of `@key` in loops (`Events.razor`, `AttendanceTracker.razor`) for efficient DOM updates.
  - Computed properties for statistical calculations to avoid unnecessary LINQ operations.
  - Null-checking implemented safely across Services and Components.
  - Extracted common UI elements to `EventCard.razor` to enforce DRY principles.

## How Microsoft Copilot Assisted in Development

1. **Foundation**: Copilot accelerated the initial scaffolding of the `EventCard` component, setting up `@bind` parameters and the basic HTML structure for two-way data binding.
2. **Routing**: Copilot helped generate boilerplate `@page` directives and `NavLink` structures within the `NavMenu`, ensuring robust navigation.
3. **Debugging**: When dealing with form validation edge cases (e.g., ticket counts exceeding capacity), Copilot suggested the logic to securely reduce available seats only after successful validation.
4. **Optimization**: Copilot recommended implementing `@key` attributes inside `foreach` loops to optimize Blazor's virtual DOM diffing algorithm, greatly improving render performance.
5. **Advanced Features**: Copilot assisted in structuring the `UserSessionService` using the C# `event Action? OnChange` pattern, enabling smooth state propagation across the application without complex state containers.

## Future Improvements
- **Database integration**: Replace in-memory lists with Entity Framework Core and SQL Server/SQLite.
- **Authentication**: Implement JWT or Identity-based authentication instead of the current session simulator.
- **Email notifications**: Add automated email confirmations using SendGrid or SMTP upon successful registration.
- **Payment integration**: Integrate Stripe or PayPal to handle paid event tickets.
