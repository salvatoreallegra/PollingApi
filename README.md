# PollingApi

Real-time polling API with a lightweight JavaScript client. The solution includes an ASP.NET Core Web API, SignalR hub for live updates, and a simple web client in `pollingclient/`. Folders include `Controllers`, `Hubs`, `Models`, and `Services`. :contentReference[oaicite:0]{index=0}

---

## Features

- REST endpoints to create polls and submit votes
- **SignalR** hub to broadcast live vote totals to connected clients
- In-memory storage by default (swap for a database if desired)
- Minimal client app (HTML/JS) in `pollingclient/` for quick testing :contentReference[oaicite:1]{index=1}

---

## Tech Stack

- **Server:** ASP.NET Core Web API, SignalR (C#)
- **Client:** HTML + JavaScript (vanilla)
- **Lang breakdown (repo):** JavaScript, C#, HTML, CSS. :contentReference[oaicite:2]{index=2}

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
