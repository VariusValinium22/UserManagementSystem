/* 
What is a class?
    A class is 'blueprint' for creating objects.
    It defines the data(properties) and behavior(methods) of an object.
    BONUS: a get/set property is a common example of Encapsulation!
 */
// Erase and write a User Class:
public class User {
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Email { get; set; } = "";

    public void DisplayInfo() {
        Console.WriteLine(Name);
    }
}
