using HotelFinder.Business.Abstract;
using HotelFinder.Business.Concrete;
using HotelFinder.Entites;
using Microsoft.AspNetCore.Mvc;

namespace HotelFinder.API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class HotelsController : ControllerBase
    {
        private IHotelService _hotelService;
        public HotelsController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }

        /// <summary>
        /// Get All Hotels
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Hotel> Get()
        {
            return _hotelService.GetAllHotels();
        }

        /// <summary>
        /// Get Hotel By ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public Hotel Get(int id)
        {
            return _hotelService.GetHotelById(id);
        }

        /// <summary>
        /// Create Hotel
        /// </summary>
        /// <param name="hotel"></param>
        /// <returns></returns>
        [HttpPost]
        public Hotel Post([FromBody]Hotel hotel)
        {
            return _hotelService.CreateHotel(hotel);
        }

        /// <summary>
        /// Update Hotel
        /// </summary>
        /// <param name="hotel"></param>
        /// <returns></returns>
        [HttpPut]
        public Hotel Put([FromBody] Hotel hotel)
        {
            return _hotelService.UpdateHotel(hotel);
        }

        /// <summary>
        /// Delete Hotel
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _hotelService.DeleteHotel(id);
        }


    }
}
