namespace UserManagement.Domain.Interface;

public interface IAuth
{
    bool Authenticate(string username, string password); // Authenticating user with credentials
    bool AuthenticateWithToken(string token); // Authenticating with a token (e.g., JWT, OAuth)

    // Authorization Methods
    bool Authorize(string userId, string role); // Check if the user has the required role
    bool AuthorizeWithPolicy(string userId, string policy); // Policy-based authorization

    // Token Management
    string GenerateToken(string userId, string role); // Generate a JWT or OAuth token
    bool ValidateToken(string token); // Validate the token's integrity and expiration
    void RevokeToken(string token); // Invalidate a token (revocation)

    // API Key Management
    string GenerateApiKey(string userId); // Generate an API key
    bool ValidateApiKey(string apiKey); // Validate an API key

    // Session Management
    string CreateSession(string userId); // Create a session upon successful login
    bool ValidateSession(string sessionId); // Validate the session
    void EndSession(string sessionId); // End the current session

    // Token Lifecycle
    string RefreshToken(string refreshToken); // Refresh a JWT token with a refresh token
    void RevokeRefreshToken(string refreshToken); // Invalidate a refresh token

    // OAuth Mechanisms
    string GetAuthorizationCode(string clientId, string redirectUri); // OAuth authorization code flow
    string ExchangeAuthorizationCodeForToken(string code); // Exchange authorization code for a token

    // Password Management
    string HashPassword(string password); // Hashes a password for storage
    bool VerifyPassword(string hashedPassword, string password); // Verifies the hashed password

    // CSRF Protection
    string GenerateCsrfToken(); // Generates a CSRF token
    bool ValidateCsrfToken(string csrfToken); // Validates a CSRF token

    // Rate Limiting
    bool IsRateLimited(string userId, string action); // Check if a user is rate-limited for a specific action
}

