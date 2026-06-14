# User Management System

A full-stack learning project: **C# / .NET Web API** backend and **React** frontend, containerized with Docker and deployed to a HomeLab server via GitHub Actions and Cloudflare Tunnel.

**Live API (smoke test):** [https://apiusermanagement.martinyoungproject.com/weatherforecast](https://apiusermanagement.martinyoungproject.com/weatherforecast)

Full build checklist and learning path → **[ROADMAP.md](./ROADMAP.md)**

---

## Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download)
- [Docker](https://www.docker.com/) (for containerized runs)

---

## Quick start

### Run locally

```bash
cd UserManagementApi
dotnet run
```

Then open `http://localhost:5xxx/weatherforecast` (port shown in the terminal).

### Run with Docker

From the repo root:

```bash
docker compose up -d --build
curl http://localhost:8082/weatherforecast
```

---

## Project structure

```text
UserManagementSystem/
├── UserManagementApi/          # .NET 9 Web API
├── Dockerfile
├── docker-compose.yml
├── .github/workflows/          # CI build + HomeLab deploy
├── README.md                   # This file
└── ROADMAP.md                  # Phases, checklists, learning goals
```

---

## Deployment

Pushes to `main` trigger GitHub Actions:

1. **Build** — restore and compile on `ubuntu-latest`
2. **Deploy** — self-hosted runner on HomeLab pulls the repo, rebuilds containers, and runs a smoke test

Manual redeploy on the server (optional):

```bash
cd ~/DockerProjects/UserManagementSystem
git pull origin main
docker compose up -d --build
```

---

## Current status

- Infrastructure and CI/CD are in place (see [ROADMAP.md](./ROADMAP.md) Phase 1)
- Backend model and service layer are started; user API endpoints are next
