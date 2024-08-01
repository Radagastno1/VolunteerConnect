namespace CORE;

public interface IUserService{
    Task<User> GetById(string id);
    Task<User> UpdateUser(User user);
    Task<User> Create(User user);
    Task<bool> DeleteById(string id);
   
}