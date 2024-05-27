using Microsoft.AspNetCore.Mvc;
using TFGBackend.Business;
using TFGBackend.Models;
using TFGBackend.Models.DTOs;

namespace TFGBackend.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReservaController : ControllerBase
    {
        private readonly IReservaService _reservaService;
        private readonly IPistaService _pistaService;
        private readonly ISesionService _sesionService;
        private readonly IUsuarioService _usuarioService;

        public ReservaController(IReservaService reservaService, IPistaService pistaService, ISesionService sesionService, IUsuarioService usuarioService)
        {
            _reservaService = reservaService;
            _pistaService = pistaService;
            _sesionService = sesionService;
            _usuarioService = usuarioService;
        }

        [HttpGet]
        public ActionResult<List<ReservaResponseDto>> GetAll() =>
            _reservaService.GetAll();

        [HttpGet("{id}")]
        public ActionResult<ReservaResponseDto> Get(int id)
        {
            var reserva = _reservaService.Get(id);

            if (reserva == null)
                return NotFound();

            var response = new ReservaResponseDto
            {
                IdReservation = reserva.IdReservation,
                ReservationPrice = reserva.ReservationPrice,
                ReservationDate = reserva.ReservationDate,
                
                };

            return response;
        }

        [HttpPost]
        public IActionResult Create([FromBody] ReservaRequestDto reservaRequest)
        {
           
            var sesion = _sesionService.Get(reservaRequest.IdSesion);
            var usuario = _usuarioService.Get(reservaRequest.IdUser);

            if ( sesion == null || usuario == null)
                return NotFound();

            var reserva = new Reserva
            {
                IdUser = reservaRequest.IdUser,
      
                IdSesion = reservaRequest.IdSesion,
                ReservationDate = reservaRequest.ReservationDate,
                ReservationPrice = reservaRequest.ReservationPrice,
            };

            _reservaService.Add(reserva);

            return CreatedAtAction(nameof(Get), new { id = reserva.IdReservation }, reserva);
        }


        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] ReservaRequestDto reservaRequest)
        {

            var existingReserva = _reservaService.Get(id);
            if (existingReserva == null)
                return NotFound();

        
            existingReserva.IdSesion = reservaRequest.IdSesion;
            existingReserva.ReservationDate = reservaRequest.ReservationDate;
            existingReserva.ReservationPrice = reservaRequest.ReservationPrice;

            _reservaService.Update(existingReserva);

            return NoContent();
        }


        [HttpGet("user/{userId}")]

        public ActionResult<List<ReservaResponseDto>> GetReservasByUser(int userId)
        {

            var reservations = _reservaService.GetReservasByUser(userId);
            if (reservations is null)
                return NotFound();

            return reservations;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var reserva = _reservaService.Get(id);

            if (reserva is null)
                return NotFound();

            _reservaService.Delete(id);

            return NoContent();
        }
    }
}
