using AutoMapper;
using HotelProject.Business.Abstract;
using HotelProject.DTO.DTO.RoomDTO;
using HotelProject.Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OptionalRoomController : ControllerBase
    {
        IRoomService _roomService;
        IMapper _mapper;

        public OptionalRoomController(IMapper mapper, IRoomService roomService)
        {
            _mapper = mapper;
            _roomService = roomService;
        }
        [HttpGet]
        public IActionResult RoomList()
        {
            var values = _roomService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult RoomAdd(RoomAddDTO roomAddDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Room>(roomAddDTO);
            _roomService.TInsert(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult RoomUpdate(RoomUpdateDTO roomUpdateDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Room>(roomUpdateDTO);
            _roomService.TUpdate(values);
            return Ok("Başarıyla Güncellendi");
        }
    }
}
