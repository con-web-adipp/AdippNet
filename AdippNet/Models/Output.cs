namespace AdippNet.Models;

public class Output
{
    public List<Bookmark> Bookmarks { get; set; } = new();
    public List<CustomProperty> CustomProperties { get; set; } = new();
}