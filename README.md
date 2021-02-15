# File Copy Util

A small utility to copy files from one location to another. You can run the .NET application directly (uses .NET 5.0) or you can download the app directory to do so

## Running the app

1. Create a `config.json` file in the downloaded app directory with the configs of the files you want to copy:

```json
[
  {
    "From": "path/to/file/1.txt",
    "To": "new/path/to/file/1.txt"
  },
  {
    "From": "path/to/file/2.txt",
    "To": "new/path/to/file/2.txt"
  }
]
```

> Note that all `\` will need to be converted to `/` on Windows directory paths

1. Run the `.exe` file or the .NET application which will handle the file copying

## Publish the app

To publish the application you can run the following `.NET CLI` commands:

### Windows 64 bit

```
dotnet publish -r win-x64 -c Release -p:PublishSingleFile=true -p:PublishTrimmed=true
```