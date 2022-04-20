using HotelApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApi.Controllers
{
    [Route("/")]
    [ApiController]
    public class RootController : ControllerBase
    {
        private readonly HotelApiDbContext _context;

        public RootController(HotelApiDbContext context)
        {
            _context = context;
        }

        [HttpGet(Name = nameof(GetRoot))]
        [ProducesResponseType(200)]
        public IActionResult GetRoot()
        {
            var response = new RootResponse
            {
                Href = null,// Url.Link(nameof(GetRoot), null),
                Rooms = Link.To(nameof(RoomsController.GetRooms)),               
                Info = Link.To(nameof(InfoController.GetInfo))
            };

            return Ok(response);
        }

        
    }
}
