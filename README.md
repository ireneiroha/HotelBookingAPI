HotelBookingAPI

A simple REST API for managing hotel room bookings, built with ASP.NET Core and Entity Framework Core.

Tech Stack
.NET 10 / ASP.NET Core Web API
Entity Framework Core (In-Memory Database)
Swagger / OpenAPI for interactive API testing
Features
Create and update hotel bookings
In-memory data store (no external database setup required)
Swagger UI for testing endpoints
Getting Started
Prerequisites
.NET SDK
Run the app
bash
git clone https://github.com/<your-username>/HotelBookingAPI.git
cd HotelBookingAPI
dotnet run --launch-profile https

Then open:

https://localhost:7163/swagger
API Endpoints
Method	Endpoint	Description
POST	/api/HotelBooking	Create a new booking (id: 0) or update an existing one (id: <existing id>)
Sample Request (Create)
json
{
  "id": 0,
  "roomNumber": 12,
  "clientName": "Oma Oke"
}
Project Structure
HotelBookingAPI/
├── Controllers/
│   └── HotelBookingController.cs
├── Data/
│   └── ApiDbContext.cs
├── Models/
│   └── HotelBooking.cs
└── Program.cs
License

MIT
