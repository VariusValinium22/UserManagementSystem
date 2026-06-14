/* What is a Controller?
    A controller handles HTTP requests and returns HTTP responses.
    It does NOT contain business logic — it delegates to a service (IUserService → UserService).

    Flow:  Client  →  UsersController  →  IUserService  →  UserService  →  List<User>
           curl         GET /api/users       GetAllUsers()     _users

    Key concepts:
        [ApiController]  — marks this as a Web API controller (automatic model validation, etc.)
        [Route("api/[controller]")]  — base URL; [controller] becomes "users" from UsersController
        [HttpGet]  — HTTP GET verb; read data, no body required
        Constructor injection  — Program.cs registered IUserService; framework passes UserService here
*/
// === C5 — Add UsersController (expose HTTP API) =====================================================

using Microsoft.AspNetCore.Mvc;
using UserManagementApi.Models;
using UserManagementApi.Services;

namespace UserManagementApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly IUserService _userService; // C5: DI — holds the service injected by Program.cs (C4)

    public UsersController(IUserService userService) // C5: constructor injection — framework supplies UserService
    {
        _userService = userService;
    }

    [HttpGet] // C5: GET /api/users — returns all users
    public ActionResult<List<User>> GetAll()
    {
        return Ok(_userService.GetAllUsers());
    }

    [HttpGet("{id}")] // C5: GET /api/users/{id} — returns one user or 404
    public ActionResult<User> GetById(int id)
    {
        var user = _userService.GetUserById(id);
        if (user is null)
            return NotFound();

        return Ok(user);
    }
}
