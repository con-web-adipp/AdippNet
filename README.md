# AdippNet

![build](https://img.shields.io/github/actions/workflow/status/con-web-adipp/AdippNet/build.yml)
![release](https://img.shields.io/github/v/release/con-web-adipp/AdippNet)
![license](https://img.shields.io/github/license/con-web-adipp/AdippNet)

AdippNet is a small .NET 6.0 library for [Griffeye Analyze DI Pro](https://www.griffeye.com/analyze-di/) plugin development. 
Using AdippNet, you'll skip all the boiler plate code so you can actually focus on the features of your plugin.


## Basic usage

Inside your .NET 6.0 console project, install the AdippNet package from command line using NuGet:

```shell
dotnet add package AdippNet --version [current_version]
```

Add the following lines your ``Program.cs``:

```csharp
using AdippNet;
using AdippNet.Models;

// instantiate the plugin
var plugin = new Adipp();


// implement your plugin's feature
void MakeABookmarkFromFileSize(MediaFile file)
{
    var bookmark = new Bookmark { Path = "FileSize", Name = file.FileSize.ToString() };
    file.AddBookmark(bookmark);
}

// inject your feature into the plugin
plugin.AddAction(MakeABookmarkFromFileSize);

// make the plugin run
plugin.Run();
```

## Advanced usage

tbd