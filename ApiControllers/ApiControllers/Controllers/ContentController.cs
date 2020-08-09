using ApiControllers.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiControllers.Controllers
{
    [Route("api/[controller]")]
    public class ContentController : Controller
    {
        [HttpGet("string")]
        public string GetString() => "this is a string response";

        [HttpGet("object/{format?}")]
        [FormatFilter]
   //     [Produces("application/json", "application/xml")]
        public Reservation GetObject() => new Reservation
        {
            ReservationId = 100,
            ClientName = "joe",
            Location = "Board ROOOM"
        };

        [HttpPost]
        [Consumes("application/json")]
        public Reservation ReceiveJson([FromBody] Reservation reservation)
        {
            reservation.ClientName = "Json";
            return reservation;
        }

        [HttpPost]
        [Consumes("application/xml")]
        public Reservation ReceiveXml([FromBody] Reservation reservation)
        {
            reservation.ClientName = "Xml";
            return reservation;
        }
    }
}