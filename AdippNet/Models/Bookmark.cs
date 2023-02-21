using System.Text.Json.Serialization;

namespace AdippNet.Models;

public class Bookmark
{
    [JsonIgnore] public string Name { get; set; } = string.Empty;

    [JsonIgnore] public string Path { get; set; } = string.Empty;

    public string BookmarkPath => string.Join("/", Path, Name);
    public string HtmlColor { get; set; } = "#FFFFFF";
    public string Comment { get; set; } = string.Empty;
    public string Sha1 { get; set; } = string.Empty;
}