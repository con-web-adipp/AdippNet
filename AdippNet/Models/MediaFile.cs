namespace AdippNet.Models;

public class MediaFile
{
    public List<AppData> AppData { get; set; } = new();
    public List<InputBookmark> Bookmarks { get; set; } = new();
    public Category Category { get; set; } = new();
    public List<Comment> Comments { get; set; } = new();
    public List<DatabaseMatch> DataBaseMatches { get; set; } = new();
    public bool? Distributed { get; set; }
    public List<Exif> Exif { get; set; } = new();
    public string ExifSerialNumber { get; set; } = string.Empty;
    public int ExifThumbnailCount { get; set; }
    public string FileClass { get; set; } = string.Empty;
    public List<FilesystemMetadata> Files { get; set; } = new();
    public int FileSize { get; set; }
    public bool HasSound { get; set; }
    public int Height { get; set; }
    public Category InitialCategory { get; set; } = new();
    public bool IsAnimated { get; set; }
    public float? Latitude { get; set; }
    public float? Longitude { get; set; }
    public string Md5Hex { get; set; } = string.Empty;
    public string MimeType { get; set; } = string.Empty;
    public int NudityLevel { get; set; }
    public bool? OffenderIdentified { get; set; }
    public string PhotoDnaBase64 { get; set; } = string.Empty;
    public bool Representative { get; set; }
    public List<string> Series { get; set; } = new();
    public string Sha1Hex { get; set; } = string.Empty;
    public string Sha256Hex { get; set; } = string.Empty;
    public string Sha384Hex { get; set; } = string.Empty;
    public string Sha512Hex { get; set; } = string.Empty;
    public List<string> Tags { get; set; } = new();
    public bool? VictimIdentified { get; set; }
    public float VideoLength { get; set; }
    public int VisualDuplicatesCount { get; set; }
    public int Width { get; set; } = new();
    public string FilepathOriginal { get; set; } = string.Empty;
    public string FilepathConverted { get; set; } = string.Empty;
    public string OutputDirectory { get; set; } = string.Empty;
    public List<CustomPropertyValue> CustomPropertyValues { get; set; } = new();

    public List<Bookmark> NewBookmarks { get; set; } = new();
    public List<CustomProperty> NewCustomProperties { get; set; } = new();

    public void AddBookmark(Bookmark newBookmark)
    {
        newBookmark.Sha1 = Sha1Hex;
        NewBookmarks.Add(newBookmark);
    }

    public void AddCustomProperty(CustomProperty newCustomProperty)
    {
        newCustomProperty.Sha1 = Sha1Hex;
        NewCustomProperties.Add(newCustomProperty);
    }

    public void AddBookmarks(List<Bookmark> newBookmarks)
    {
        foreach (var bookmark in newBookmarks)
        {
            bookmark.Sha1 = Sha1Hex;
            NewBookmarks.Add(bookmark);
        }
    }
}