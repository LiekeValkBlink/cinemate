namespace Cinemate.Models.Dto;

public class AddOrUpdateTheaterRoomDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int SeatsNo { get; set; }
    public int TheaterId { get; set; }
}