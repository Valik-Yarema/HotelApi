﻿using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HotelApi.Controllers
{
    [Route("/")]
    [ApiController]
    public class RootController : ControllerBase
    {
        [HttpGet(Name = nameof(GetRoot))]
        public IActionResult GetRoot()
        {
            var response = new
            {
                href = Url.Link(nameof(GetRoot), null),
                rooms = new 
                {
                    href = Url.Link(nameof(RoomsController.GetRooms),null)
                
                }
            };

            return Ok(response);
        }
    }
}
