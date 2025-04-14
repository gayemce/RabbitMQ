# FormulaAirline - Booking & Ticket Processing System (with RabbitMQ)

This project simulates a simple airline booking and ticket processing system using **RabbitMQ**. Flight bookings are created via a Web API and sent to a message queue, where they are then consumed and processed by a separate console application.

---

## 🔹 Project Structure

- **FormulaAirline.API**:
  - ASP.NET Core Web API project.
  - Handles booking creation and sends booking messages to RabbitMQ.
  
- **FormulaAirline.TicketProcessing**:
  - Console application.
  - Listens to the RabbitMQ queue and processes booking messages (prints them to the console).

---

## 🔹 Technologies Used

- ASP.NET Core Web API
- .NET 8+
- RabbitMQ
- Docker & Docker Compose
- RabbitMQ.Client (NuGet package)

---

## 🔹 Running the System Locally

1. **Start RabbitMQ using Docker:**
   ```sh
   docker-compose up -d
   ```
   - RabbitMQ Management UI will be available at `http://localhost:15672`
   - Username: `user`
   - Password: `mypass`

2. **Run the API project (FormulaAirline.API) via your IDE or terminal:**
   ```sh
   cd FormulaAirline.API
   dotnet run
   ```
3. **Start the console app (FormulaAirline.TicketProcessing) in a new terminal::**
   ```sh
   cd FormulaAirline.TicketProcessing
   dotnet run
   ```
