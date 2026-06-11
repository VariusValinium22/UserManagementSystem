/* Interface concept file 1 of 2: define the contract
What is an interface?
    An interface is a contract that DEFINES what a class MUST do(IUserService.cs),
    without saying how it does it(UserService.cs).
Why do we use Interfaces?
    to:
        Contains the contracts(interface) separating the concern of from the business logic(Implementation)
        Promote Abstraction - hiding implementation details, exposing ONLY essential functionality. 
            i.e. hides how users are stored, retrieved, searched.
        Reduce Tight Coupling - allowing classes to depend on contracts of concrete implementations.
        Allow multiple implementations - implement the interface in different classes using the same interface differently.
        Commonly used with DI - use an interface to inject dependencies instead of concrete classes.
*/
using UserManagementApi.Models;

namespace UserManagementApi.Services;

public interface IUserService
{
    List<User> GetAllUsers();               // the 'contract'
    User? GetUserById(int id);              // the 'contract'
}
