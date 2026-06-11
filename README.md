ctrl + shift + V

# User Management System

A full-stack learning project: **C# / .NET Web API** backend + **React** frontend, deployed to HomeLab via Docker and Cloudflare.

**Live API (smoke test):** `https://apiusermanagement.martinyoungproject.com/weatherforecast`

---

## How to use this checklist

Markdown supports task checkboxes. Edit this file and change `[ ]` to `[x]` when a step is done.

```markdown
- [ ] Not done
- [x] Done
```

On **GitHub**, checkboxes render in the README and you can click them in the web UI (if you have write access). In **Cursor**, edit the brackets directly or use Markdown preview.

---

## Phase 1 — Deployment / Infrastructure Foundation

- [x] .NET 9 Web API scaffold (`dotnet new webapi`)
- [x] Local smoke test (`dotnet run` → `/weatherforecast`)
- [x] Docker (`Dockerfile`, `.dockerignore`, `docker-compose.yml`)
- [x] GitHub repository
- [x] HomeLab deploy (`~/DockerProjects/UserManagementSystem`)
- [x] Cloudflare tunnel (`apiusermanagement.martinyoungproject.com`)
- [x] GitHub Actions build workflow
- [x] GitHub Self-hosted runner deploy to HomeLab

---

## Phase 2a — Backend (dependency chain)

Build in this order. Each file depends on the ones above it.

| # | File | Interview / learning concepts |
|---|------|-------------------------------|
| 1 | `UserManagementApi/Models/User.cs` | Class, object, field, property, constructor, method, encapsulation |
| 2 | `UserManagementApi/Services/IUserService.cs` | Interface, contract |
| 3 | `UserManagementApi/Services/UserService.cs` | Implementation, business logic, `List<T>`, LINQ |
| 4 | `UserManagementApi/Program.cs` | Dependency injection, service registration |
| 5 | `UserManagementApi/Controllers/UsersController.cs` | API endpoints, HTTP verbs, controller |

### Checklist

- [x] **1. `Models/User.cs`** — user data model
- [x] **2. `Services/IUserService.cs`** — service contract
- [x] **3. `Services/UserService.cs`** — in-memory implementation
- [ ] **4. `Program.cs`** — register `IUserService` → `UserService`
- [ ] **5. `Controllers/UsersController.cs`** — expose HTTP API

### First API milestone

- [ ] `GET /api/users` returns hardcoded users (local `dotnet run`)
- [ ] `GET /api/users/{id}` returns one user
- [ ] Test with `curl` locally
- [ ] Push to `main` → GitHub Actions deploys to HomeLab
- [ ] Test public URL

---

## Phase 2b — Frontend (`user-management-frontend/`)

Start after backend endpoints work with `curl`.

| # | File | Interview / learning concepts |
|---|------|-------------------------------|
| 6 | `App.jsx` | Parent component, composition |
| 7 | `hooks/useUsers.js` | Custom hook, `useState`, `useEffect`, API calls |
| 8 | `components/UserList.jsx` | List rendering, `map()` |
| 9 | `components/UserCard.jsx` | Props, parent → child communication |
| 10 | `components/UserForm.jsx` | State, controlled components, child → parent |
| 11 | `context/UserContext.jsx` | Context API, prop drilling solution |

### Checklist

- [ ] Scaffold Vite + React app (`user-management-frontend/`)
- [ ] **6. `App.jsx`**
- [ ] **7. `hooks/useUsers.js`**
- [ ] **8. `components/UserList.jsx`**
- [ ] **9. `components/UserCard.jsx`**
- [ ] **10. `components/UserForm.jsx`**
- [ ] **11. `context/UserContext.jsx`**
- [ ] UI loads users from API
- [ ] Extend `docker-compose.yml` for frontend (when ready)

---

## Phase 2c — Features (incremental)

- [ ] View users / profile
- [ ] Register (POST user)
- [ ] Update profile (PUT/PATCH)
- [ ] Login / auth (later — JWT or sessions)

---

## Phase 2d — Later

- [ ] Database (replace in-memory store)
- [ ] Remove or replace `/weatherforecast` smoke-test endpoint
- [ ] Update GitHub Actions smoke test to `/api/users`

---

## Repo layout

```text
UserManagementSystem/
├── UserManagementApi/
│   ├── Models/
│   │   └── User.cs
│   ├── Services/
│   │   ├── IUserService.cs
│   │   └── UserService.cs
│   ├── Controllers/
│   │   └── UsersController.cs          ← next
│   └── Program.cs
├── user-management-frontend/           ← later
├── Dockerfile
├── docker-compose.yml
├── .github/workflows/build-and-deploy.yml
└── README.md
```

---

## Quick commands

**Local run**

```bash
cd UserManagementApi
dotnet run
```

**Docker (repo root)**

```bash
docker compose up -d --build
curl http://localhost:8082/weatherforecast
```

**HomeLab redeploy (manual — optional; Actions does this on push)**

```bash
cd ~/DockerProjects/UserManagementSystem
git pull origin main
docker compose up -d --build
```
