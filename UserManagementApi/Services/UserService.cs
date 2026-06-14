/* Interface concept file 2 of 2: implements the contract, Business Logic
What is an interface?
    This file IMPLEMENTS the interface 'contract' and defines HOW an interface contract works. 
            Contains the business logic(Implementation), separating the contract(interface) from the implementation.
            INSTANTIATES and defines HOW the user object is managed.
            ENCAPSULATION - private readonly List<User> _users 
                            hides the internal user collection from outside classes.
                            When you see 'private', think ENCAPSULATION!
*/
// === C3 — Add the Class that implements the interface file 2 of 2 ==========================================

using UserManagementApi.Models;

namespace UserManagementApi.Services;

public class UserService : IUserService {                   // IMPLEMENTATION of IUserService interface
    private readonly List<User> _users;                     // ENCAPSULATION: hidden, only UserService can access _users

    public UserService() {                                  // Constructor/INITIALIZATION of the UserService object
        _users =                                            // Field
        [
            new User                                        // Object INSTANTIATION
            {
                Id = 1,
                Name = "Martin",
                Email = "martin@test.com"
            },

            new User                                        // Object INSTANTIATION
            {
                Id = 2, 
                Name = "Frank",
                Email = "frank@test.com"
            }
        ];
    }

    public List<User> GetAllUsers() {                       // IMPLEMENTS the interface contract
        return _users;
    }

    public User? GetUserById(int id) {
        return _users.FirstOrDefault(user => user.Id == id); // LINQ query using a Lambda expression
    }
}
