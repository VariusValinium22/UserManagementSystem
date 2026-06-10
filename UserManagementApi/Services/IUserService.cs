/*
What is an interface?
    An interface is a contract that defines what a class must do,
    without saying how it does it.
*/
public interface IUserService
{
    List<User> GetAllUsers();
    User? GetUserById(int id);
}
