# User Management System — Roadmap

Build checklist and learning path for this project. Edit checkboxes (`[ ]` → `[x]`) as you complete each step.

- [ ] Not done
- [x] Done

On **GitHub**, checkboxes render in this file and you can click them in the web UI (if you have write access). In **Cursor**, edit the brackets directly or use Markdown preview.

---

### Phase 1 — Deployment / Infrastructure Foundation

- [x] .NET 9 Web API scaffold (`dotnet new webapi`)
- [x] Local smoke test (`dotnet run` → `/weatherforecast`)
- [x] Docker (`Dockerfile`, `.dockerignore`, `docker-compose.yml`)
- [x] GitHub repository
- [x] HomeLab deploy (`~/DockerProjects/UserManagementSystem`)
- [x] Cloudflare tunnel (`apiusermanagement.martinyoungproject.com`)
- [x] GitHub Actions build workflow
- [x] GitHub Self-hosted runner deploy to HomeLab

---

### Phase 2 — File dependency chain

Build in this order. Each file depends on the ones above it.

#### Phase 2a — Backend

| # | File | Interview / learning concepts |
|---|------|-------------------------------|
| 1 | `UserManagementApi/Models/User.cs` | Class, object, field, property, constructor, method, encapsulation |
| 2 | `UserManagementApi/Services/IUserService.cs` | Interface, contract |
| 3 | `UserManagementApi/Services/UserService.cs` | Implementation, business logic, `List<T>`, LINQ |
| 4 | `UserManagementApi/Program.cs` | Dependency injection, service registration |
| 5 | `UserManagementApi/Controllers/UsersController.cs` | API endpoints, HTTP verbs, controller |

#### Phase 2b — Frontend (`user-management-frontend/`)

Start after backend endpoints work with `curl`.

| # | File | Interview / learning concepts |
|---|------|-------------------------------|
| 6 | `user-management-frontend` | Scaffold Vite + React app |
| 7 | `App.jsx` | Parent component, composition |
| 8 | `hooks/useUsers.js` | Custom hook, `useState`, `useEffect`, API calls |
| 9 | `components/UserList.jsx` | List rendering, `map()` |
| 10 | `components/UserCard.jsx` | Props, parent → child communication |
| 11 | `components/UserForm.jsx` | State, controlled components, child → parent |
| 12 | `context/UserContext.jsx` | Context API, prop drilling solution |

---

### Phase 2 — Checklist

Track progress here. Step numbers match the dependency chain table above.

### Backend (Phase 2a)

- [x] **1. `Models/User.cs`** — user data model
- [x] **2. `Services/IUserService.cs`** — service contract
- [x] **3. `Services/UserService.cs`** — in-memory implementation
- [x] **4. `Program.cs`** — register `IUserService` → `UserService`
- [x] **5. `Controllers/UsersController.cs`** — expose HTTP API

<div class="indent-block">

### First API milestone: Now test the backend successfully

- [x] `GET /api/users` returns hardcoded users (local `dotnet run`)
- [x] `GET /api/users/{id}` returns one user
- [x] Test with `curl` locally
- [x] Push to `main` → GitHub Actions deploys to HomeLab
- [x] Test public URL

</div>

---

### Frontend (Phase 2b)

Build in chunks — stop and test in the browser after each chunk (unlike backend, you don't need every file before something works).

#### Chunk 1 — Display users (build C7–C10, then test)

- [x] **6. `Scaffold Vite + React app`** (`user-management-frontend/`)
- [x] **7. `App.jsx`** scaffold creates App.jsx (C6), customize App.jsx (C7).
- [x] **8. `hooks/useUsers.js`**
- [ ] **9. `components/UserList.jsx`**
- [ ] **10. `components/UserCard.jsx`**

<div class="indent-block">

#### First UI milestone

- [ ] Browser shows users from API (`https://apiusermanagement.martinyoungproject.com/api/users`)
- [ ] `useUsers` hook fetches and stores data
- [ ] `UserList` renders with `map()`
- [ ] `UserCard` receives user via props

</div>

<hr class="section-break" />

#### Chunk 2 — Add user + shared state (after Chunk 1 works)

- [ ] **11. `components/UserForm.jsx`** — ties to Phase 2c (register user)
- [ ] **12. `context/UserContext.jsx`** — when you need shared state / prop drilling fix

<hr class="section-break" />

#### Later (Phase 2b)

- [ ] Extend `docker-compose.yml` for frontend (when ready)

---

### Phase 2c — Features (incremental)

- [ ] View users / profile
- [ ] Register (POST user)
- [ ] Update profile (PUT/PATCH)
- [ ] Login / auth (later — JWT or sessions)

---

### Phase 2d — Later

- [ ] Database (replace in-memory store)
- [ ] Remove or replace `/weatherforecast` smoke-test endpoint
- [ ] Update GitHub Actions smoke test to `/api/users`

---

### File layout — Build order (dependency chain)

```text
BACKEND
UserManagementSystem/
    ├── UserManagementApi/
    ├── Models/
C1  │   │   └── User.cs
    ├── Services/
C2  │   │   ├── IUserService.cs
C3  │   │   └── UserService.cs
C4  │   ├── Program.cs
    ├── Controllers/
C5  │   │   └── UsersController.cs
FRONTEND
C6  ├── user-management-frontend/ ← Vite + React scaffold
C6  └── src/
C6  │   ├── assets/
C6,C7       ├── App.jsx
    │       ├── hooks/
C8  │       │   └── useUsers.js
    │       ├── components/
C9  │       │   ├── UserList.jsx
C10 │       │   ├── UserCard.jsx
C11 │       │   └── UserForm.jsx
    │       └── context/
C12 │           └── UserContext.jsx
DRILL FILE
    ├── Study/
    │   └── UserDrill.cs

    ├── Dockerfile
    ├── docker-compose.yml
    ├── .github/workflows/build-and-deploy.yml
    ├── README.md
    └── ROADMAP.md
```

---

### File layout — Alphabetical (Explorer sidebar)

```text
UserManagementSystem/
    ├── .github/
    │   └── workflows/
    │       └── build-and-deploy.yml
    ├── Study/
    │   └── UserDrill.cs
C6  ├── user-management-frontend/ ← Vite + React scaffold
C6  ├── public/
C6  ├── src/
C6  │   ├── assets/
    │   ├── App.css
C6,C7   ├── App.jsx
C10 │   │   ├── UserCard.jsx
C11 │   │   ├── UserForm.jsx
C9  │   │   └── UserList.jsx
    │   ├── context/
C12 │   │   └── UserContext.jsx
    │   ├── hooks/
C8  │   │   └── useUsers.js
    │   ├── index.css
    │   └── main.jsx
    ├── index.html
    ├── package.json
    ├── vite.config.js
    └── eslint.config.js
├── UserManagementApi/
    ├── Controllers/
C5  │   │   └── UsersController.cs
    ├── Models/
C1  │   │   └── User.cs
    ├── Properties/
    │   └── launchSettings.json
    ├── Services/
C2  │   │   ├── IUserService.cs
C3  │   │   └── UserService.cs
C4  │   ├── Program.cs
    ├── appsettings.json
    ├── appsettings.Development.json
    ├── UserManagementApi.csproj
    └── UserManagementApi.http
    ├── .dockerignore
    ├── .gitignore
    ├── docker-compose.yml
    ├── Dockerfile
    ├── README.md
    └── ROADMAP.md
```

> `node_modules/`, `bin/`, and `obj/` omitted — generated folders, usually collapsed in the explorer.
