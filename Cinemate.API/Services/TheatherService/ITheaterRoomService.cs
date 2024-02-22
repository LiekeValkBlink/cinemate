using Cinemate.Models.Dto;

namespace Cinemate.API.Services.TheatherService;

public interface ITheaterRoomService
{
    Task<IEnumerable<TheaterRoomsDto>> GetAllTheaterRooms();
    Task<TheaterRoomsDto> GetSingleTheaterRoom(int id);
    Task<TheaterRoomsDto> AddTheaterRoom(AddOrUpdateTheaterRoomDto theaterRoomDto);
    Task<TheaterRoomsDto> UpdateTheaterRoom(AddOrUpdateTheaterRoomDto theaterRoomDto);
    Task DeleteTheaterRoom(int id);
}