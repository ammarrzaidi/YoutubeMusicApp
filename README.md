# YoutubeMusicApp
A simple Windows application for playing YouTube Music. Built using WinForms and WebView2.

Overview

This is a simple Windows Forms application for playing YouTube Music. Built using C# and WinForms, it integrates the WebView2 component for rendering YouTube Music.

Features

Play YouTube Music directly from the app

Custom application icon and title

Lightweight and standalone executable

Auto-updatable using PowerShell

Installation

Download the latest .exe file from the Releases section.

Double-click the .exe to launch the application.

How to Update

To update your installed version:

Download the latest .exe from GitHub.

Replace the existing file in your installation directory.

Run the new version.

Alternatively, update using PowerShell:

$LatestURL = "https://github.com/YOUR_GITHUB/Repo/releases/latest/download/YoutubeMusic.exe"
$Destination = "C:\Path\To\Your\App\YoutubeMusic.exe"
Invoke-WebRequest -Uri $LatestURL -OutFile $Destination -UseBasicParsing

Development

Prerequisites

.NET SDK (latest version)

Visual Studio 2022

WebView2 Runtime

Build Instructions

dotnet build --configuration Release

Publish Instructions

dotnet publish -c Release -r win-x64 --self-contained true -o "D:\projects\YoutubeMusic\Publish"

License

MIT License

Contributing

Feel free to submit pull requests or open issues if you encounter bugs!

Contact

For questions or suggestions, reach out via GitHub Issues.

