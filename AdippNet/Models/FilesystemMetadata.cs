namespace AdippNet.Models;

public class FilesystemMetadata
{
    public bool Deleted { get; set; }
    public bool Overwritten { get; set; }

    // ReSharper disable once InconsistentNaming
    public string SourceID { get; set; } = string.Empty;
    public string DisplayDirectory { get; set; } = string.Empty;
    public string DisplayFilename { get; set; } = string.Empty;
    public string CreationTime { get; set; } = string.Empty;
    public string LastAccessTime { get; set; } = string.Empty;
    public string LastWriteTime { get; set; } = string.Empty;
}