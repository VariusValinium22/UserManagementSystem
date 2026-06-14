/* What is a class?
    A class is a 'blueprint' for creating objects. It defines class members:
        properties - define the data of an object; they control access to the object.(get/set)
        fields - variables that store the internal data of an object, often accessed through Properties.
        methods - defines the behavior of an object; performs an action ON the object.
        a Constructor - when an object is created(INSTANTIATED), a constructor is a special method
            that executes automatically... INITIALIZING the object with its STARTING value.
        
    BONUS: get/set properties are common examples of Encapsulation! 
            Fields are hidden and accessed through Properties.
            When you see 'private', think ENCAPSULATION!
    What is the importance of a Constructor?
        When an object is created(INSTANTIATED), it automatically executes ensuring 
        the object starts in a valid state and INITIALIZES an initial value.
            (using the 'new' keyword OR Dependency Injection; UserService.cs).

    Instantiation vs Initialization?
        Instantiation  - creating an object(instance) from a class; the 'new' keyword. 
            i.e. UserService.cs or Program.cs
        Initialization - AFTER an object is instantiated, assigning an initial value and the state of an object.
    
    Common convention order for C# Classes:
        1. Private fields
        2. Public properties
        3. Constructor(s)
        4. Methods
 */

// === C1 — Add User Class =====================================================================

namespace UserManagementApi.Models;

public class User {                                 // Object Blueprint: Defines what a user IS
    private string _role;                           // ENCAPSULATION: This field is hidden(private), accessed through the Role property 
    
    public int Id { get; set; }                     // Property/Data also ENCAPSULATION
    public string Name { get; set; } = "";      
    public string Email { get; set; } = "";
    public string Role { get { return _role; }  
                         set { _role = value; } }   // ENCAPSULATION: the field _role is accessed here through this property

    public User() {                                 // Constructor: INITIALIZATION of a user object
        _role = "User";                                 // INITIALIZED the starting value of _role field
    }

    public void DisplayRole() {                     // Method: Access to the Role property on ONE user instance
        Console.WriteLine(Role);                        // Reads Role property and prints it
    }
}
