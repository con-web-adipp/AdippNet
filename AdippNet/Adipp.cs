using System.Text.Json;
using AdippNet.Models;
namespace AdippNet;


public class Adipp
{
    private List<MediaFile> _mediaFiles;
    private List<Action<List<MediaFile>>> BatchActions { get; } = new();
    private List<Action<MediaFile>> SingleActions { get; } = new();
    

    public Adipp()
    {
        var inputStream = Console.OpenStandardInput();
        _mediaFiles = JsonSerializer.Deserialize<List<MediaFile>>(inputStream);
    }
    
    public Adipp(string filePath)
    {
        var inputStream = File.OpenRead(filePath);
        _mediaFiles = JsonSerializer.Deserialize<List<MediaFile>>(inputStream);
    }
    

    public void AddAction(Action<List<MediaFile>> action)
    {
        BatchActions.Add(action);
    }

    public void AddAction(Action<MediaFile> action)
    {
        SingleActions.Add(action);
    }

    public void Run()
    {
        var output = new Output();
        
        foreach (var action in BatchActions) action(_mediaFiles!);

        foreach (var mediaFile in _mediaFiles!)
        {
            foreach (var action in SingleActions) action(mediaFile);
            output.Bookmarks.AddRange(mediaFile.NewBookmarks);
            output.CustomProperties.AddRange(mediaFile.NewCustomProperties);
        }

        var outputStream = Console.OpenStandardOutput();
        JsonSerializer.Serialize(outputStream, output);
        
    }

    public void DumpInput(string filePath)
    {
        var outputStream = File.OpenWrite(filePath);
        JsonSerializer.Serialize(outputStream, _mediaFiles!);
    }
    
}