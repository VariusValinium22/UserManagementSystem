/* What is a class?
    A class is 'blueprint' for creating objects. It defines the class members of:
        fields - variables that stores the internal data of an object, often accessed through Properties.
        a Constructor - when an object is created(INSTANTIATED), a constructor is a special method
            that executes automatically... INITIALIZING the object with its STARTING value.
        properties - defines the data of an object; controls access to the object.(get/set)
        methods - defines the behavior of an object; performs an action ON the object.
    
    BONUS: get/set properties are common examples of Encapsulation! Fields are hidden and accessed through Properties.
            When you see 'private', think ENCAPSULATION!
    What is the importance of a Constructor?
        When an object is created(INSTANTIATED), it automatically executes ensuring 
        the object starts in a valid state and INITIALIZES an initial value.
            (using the 'new' keyword OR Dependency Injection; UserService.cs).

    Instantiation vs Initialization?
        Instantiation  - creating an object(instance) from a class; the 'new' keyword. 
            i.e. UserService.cs or Program.cs
        Initialization - AFTER an object is instantiated, assigning an initial value and the state of an object.
 */

// STUDY TASK: Erase and write a User Class:
namespace UserManagementApi.Models;
public class User {                             // Object Blueprint: Defines what a user IS
    private string _role;                       //ENCAPSULATION: hidden Field

    public User() {                             // Constructor/INITIALIZATION of a user object
        _role = "User";                             // INITIALIZE an object with a starting value
    }

    public int Id { get; set; }                 // Property/Data
    public string Name { get; set; } = "";      // ENCAPSULATION: Fields are hidden and accessed through Properties.
    public string Email { get; set; } = "";

    public void DisplayInfo() {                 // Method/Behavior
        Console.WriteLine(Name);
    }
}
