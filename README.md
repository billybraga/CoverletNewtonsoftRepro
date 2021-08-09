# CoverletNewtonsoftRepro

## Repro

```powershell
dotnet publish -o publish
# or without .exe in linux
publish/CoverletNewtonsoftRepro.exe
# will output Unhandled exception. System.IO.FileLoadException: Could not load file or assembly 'Newtonsoft.Json, Version=13.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed'. The located assembly's manifest definition does not match the assembly reference. 
```
