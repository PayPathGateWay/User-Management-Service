using UserManagement.Domain.User.ValueObjects;
namespace UserManagement.Domain.User;

public interface IUser
{
    // General User Properties 
    public Guid UserId { get; set; }
    public string? UserName { get; set; }
    public string? PhoneNumber { get; set; }
    public bool IsVerify { get; set; }
    public string? UserRoles { get; set; }
    public EmailAddress? EmailAddress { get; set; }
    public DateTime UpdatedDate { get; set; }
    public DateTime CreatedDate { get; set; }
}