# PollingApi

Real-time polling API with a lightweight JavaScript client. The solution includes an ASP.NET Core Web API, SignalR hub for live updates, and a simple web client in `pollingclient/`. Folders include `Controllers`, `Hubs`, `Models`, and `Services`. 

---

## Features

- REST endpoints to create polls and submit votes
- **SignalR** hub to broadcast live vote totals to connected clients
- In-memory storage by default (swap for a database if desired)
- React client app in `pollingclient/` 

---

## Tech Stack

- **Server:** ASP.NET Core Web API, SignalR (C#)
- **Client:** React
- **Lang breakdown (repo):** JavaScript, C#, HTML, CSS

---

## Getting Started

### Prereqs
- .NET SDK 8+ installed
- (Optional) A simple static file server (e.g., VS Code “Live Server”) for the client

### Run the API
```bash
# from the repo root
dotnet restore
dotnet build
dotnet run

### Run the Front End
```bash
# from /pollingclient
npm install
npm start
