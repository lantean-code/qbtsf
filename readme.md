# qbtsf

qbtsf is a drop-in replacement for qBittorrent's default WebUI, implementing all of its functionality with a modern and user-friendly interface using SyncFusion's components.

## Features

qbtsf replicates all core features of the qBittorrent WebUI, including:

- **Torrent Management** – Add, remove, and control torrents.
- **Tracker Control** – View and manage trackers.
- **Peer Management** – Monitor and manage peers connected to torrents.
- **File Prioritization** – Select and prioritize specific files within a torrent.
- **Speed Limits** – Set global and per-torrent speed limits.
- **RSS Integration** – Subscribe to RSS feeds for automated torrent downloads.
- **Search Functionality** – Integrated torrent search.
- **Sequential Downloading** – Download files in order for media streaming.
- **Super Seeding Mode** – Efficiently distribute torrents as an initial seeder.
- **IP Filtering** – Improve security by filtering specific IP addresses.
- **IPv6 Support** – Full support for IPv6 networks.
- **Bandwidth Scheduler** – Schedule bandwidth limits.

<img width="2070" height="1494" alt="Screenshot 2026-01-03 120037" src="https://github.com/user-attachments/assets/de12286c-f731-4b36-a714-a93af1084f83" />
<img width="2068" height="1494" alt="Screenshot 2026-01-03 120122" src="https://github.com/user-attachments/assets/3029cfb9-b299-4363-a174-58e0f7352697" />
<img width="2070" height="1494" alt="Screenshot 2026-01-03 120148" src="https://github.com/user-attachments/assets/4056058e-9b8e-4fcd-9c38-d8a139e9ca13" />
<img width="2070" height="1494" alt="Screenshot 2026-01-03 120228" src="https://github.com/user-attachments/assets/103671b8-b694-44ca-b5a4-5fb9899403ae" />

For a detailed explanation of these features, refer to the [qBittorrent Options Guide](https://github.com/qbittorrent/qBittorrent/wiki/Explanation-of-Options-in-qBittorrent).

---

## Installation

To install qbtsf without building from source:

### 1. Download the Latest Release
- Go to the [qbtsf Releases](https://github.com/lantean-code/qbtsf/releases) page.
- Download the latest release archive for your operating system.

### 2. Extract the Archive
- Extract the contents of the downloaded archive to a directory of your choice.

### 3. Configure qBittorrent to Use qbtsf
- Open qBittorrent and navigate to `Tools` > `Options` > `Web UI`.
- Enable the option **"Use alternative WebUI"**.
- Set the **"Root Folder"** to the directory where you extracted qbtsf.
- Click **OK** to save the settings.

### 4. Access qbtsf
- Open your web browser and go to `http://localhost:8080` (or the port configured in qBittorrent).

For more detailed instructions, refer to the [Alternate WebUI Usage Guide](https://github.com/qbittorrent/qBittorrent/wiki/Alternate-WebUI-usage).

---

## Building from Source

To build qbtsf from source, you need to have the **.NET 10.0 SDK** installed on your system.

### 1. Clone the Repository
```sh
git clone https://github.com/lantean-code/qbtsf.git
cd qbtsf
```

### 2. Restore Dependencies
```sh
dotnet restore
```

### 3. Build and Publish the Application
```sh
dotnet publish --configuration Release
```

This will output the Web UI files to `Lantean.qbtsf\bin\Release\net9.0\publish\wwwroot`.

### 4. Configure qBittorrent to Use qbtsf
Follow the same steps as in the **Installation** section to set qbtsf as your WebUI.

### 5. Run qbtsf
Navigate to the directory containing the built files and run the application using the appropriate command for your OS.

By following these steps, you can set up qbtsf to manage your qBittorrent server with an improved web interface, offering better functionality and usability.
