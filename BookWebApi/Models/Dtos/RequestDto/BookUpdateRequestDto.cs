namespace BookWebApi.Models.Dtos.RequestDto;

public class BookUpdateRequestDto
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Author { get; set; }
    public string Category { get; set; }
    public double Price { get; set; }
    public int Stock { get; set; }
    public int Id { get; set; }
}
