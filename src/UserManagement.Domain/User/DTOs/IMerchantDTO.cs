using UserManagement.Domain.User.ValueObjects;

namespace UserManagement.Domain.User.DTOs;

public interface IMerchantDTO
{
    public int TotalAccountBalance { get; set; }
    public string? MerchantName { get; set; }

    public Guid MerchantId { get; set; }
    public string? PhoneNumber { get; set; }
    public string? UserRoles { get; set; }
    public EmailAddress? MerchantIdEmailAddress { get; set; }
    public bool IsVerify { get; set; }
    public DateTime UpdatedDate { get; set; }
    public DateTime CreatedDate { get; set; }
    public string MerchantHasPassword { get; set; }
    public string MerchantPlatformName { get; set; }
}