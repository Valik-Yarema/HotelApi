using HotelApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace HotelApi.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class InfoController : ControllerBase
    {
        private readonly HotelInfo hotelInfo;
        public InfoController(IOptions<HotelInfo> hotelInfoWrapper)
        {
            hotelInfo = hotelInfoWrapper.Value;
        }

        [HttpGet(Name =nameof(GetInfo))]
        [ProducesResponseType(200)]
        public ActionResult<HotelInfo> GetInfo()
        {
            hotelInfo.Href = Url.Link(nameof(GetInfo), null);

            return hotelInfo;
        }
    }
}
