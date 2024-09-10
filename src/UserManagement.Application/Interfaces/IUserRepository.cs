namespace UserManagement.Domain.Interface;

public interface IUserRepository
{
  public Task<IUser> CreateUserAsync(IUser user);
  public Task<IUser> UpdateUserAsync(IUser user);
  public Task<IUser> DeleteUserAsync(IUser user);
  public Task<IUser> GetUserByIdAsync(Guid id);
  public Task<bool> GetIsUserAuthenticated(string email, string password);
}