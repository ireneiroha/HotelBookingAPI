# HotelBookingAPI

A simple REST API for managing hotel room bookings, built with ASP.NET Core and Entity Framework Core.

## Tech Stack

- **.NET 10 / ASP.NET Core Web API**
- **Entity Framework Core** (In-Memory Database)
- **Swagger / OpenAPI** for interactive API testing

## Features

- Full CRUD support for hotel bookings (Create, Read, Update, Delete)
- Choose your own booking ID on creation
- In-memory data store (no external database setup required)
- Swagger UI for testing endpoints

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download)

### Run the app

```bash
git clone https://github.com/<your-username>/HotelBookingAPI.git
cd HotelBookingAPI
dotnet run --launch-profile https
```

Then open:

```
https://localhost:7163/swagger
```

## API Endpoints

| Method | Endpoint                   | Description                          |
|--------|------------------------------|----------------------------------------|
| POST   | `/api/HotelBooking`          | Create a new booking                  |
| PUT    | `/api/HotelBooking/{id}`     | Update an existing booking            |
| GET    | `/api/HotelBooking`          | Get all bookings                      |
| GET    | `/api/HotelBooking/{id}`     | Get a booking by ID                   |
| DELETE | `/api/HotelBooking/{id}`     | Delete a booking by ID                |

### Sample Request (Create)

```bash
curl -X POST https://localhost:7163/api/HotelBooking \
  -H "Content-Type: application/json" \
  -d '{"id": 101, "roomNumber": 12, "clientName": "Oma Oke"}'
```

### Sample Request (Update)

```bash
curl -X PUT https://localhost:7163/api/HotelBooking/101 \
  -H "Content-Type: application/json" \
  -d '{"roomNumber": 15, "clientName": "Oma Oke"}'
```

## Project Structure

```
HotelBookingAPI/
├── Controllers/
│   └── HotelBookingController.cs
├── Data/
│   └── ApiDbContext.cs
├── Models/
│   └── HotelBooking.cs
└── Program.cs
```

## License

MIT
