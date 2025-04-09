using FormulaAirline.API.Models;
using FormulaAirline.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace FormulaAirline.API.Controllers;

[ApiController]
[Route("bookings")]
public class BookingController(IMessageProducer messageProducer) : ControllerBase
{
    // In-Memory db
    public static readonly List<Booking> _bookings = new();

    [HttpPost]
    public IActionResult CreatingBooking(Booking newBooking)
    {
        if(!ModelState.IsValid) return BadRequest();

        _bookings.Add(newBooking);

        messageProducer.SendingMessage<Booking>(newBooking);

        return Ok();
    }

}
