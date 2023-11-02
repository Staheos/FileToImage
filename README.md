# FileToImage

A small Windows desktop app that encodes **any file into a PNG image** and decodes it back into the original file. The result is a square PNG that looks like colorful noise but actually *is* your file.

![App icon](FileToImage/FileToImageIcon.png)

## Features
- **File to Image**: load any file and export it as a lossless PNG
- **Image to File**: load a previously generated PNG and restore the original file
- Windows Forms GUI with image preview and an action log

## How it works
1. The file is read as raw bytes and a 4-byte length prefix is prepended.
2. Bytes are laid out into a square bitmap, 4 bytes per pixel across the ARGB channels.
3. The bitmap is saved as PNG. Since PNG is lossless, decoding uses the length prefix to trim padding and restore the exact original bytes.

## Limitations
- **This is an experiment, not a storage or compression tool.** Because the pixel data is essentially random, the output PNG is usually a similar size to the original file, or larger.
- Windows only (uses Windows Forms).

## Usage
1. Click **Load File** and pick any file, then click **Export Image** and save it as a `.png`.
2. To restore, click **Load Image** and pick the `.png`, then click **Export File** and save the original.

## Building
Requires the [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0) on Windows.

```
git clone https://github.com/Staheos/FileToImage.git
cd FileToImage
dotnet run --project FileToImage
```

Or open `FileToImage.sln` in Visual Studio and run.
