using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using UserManagement.Domain.Common.Models;
namespace UserManagement.Domain.ValueObjects;

public class Password : ValueObject
{
    public string HashedValue { get; }

    private Password(string hashedValue)
    {
        if (string.IsNullOrEmpty(hashedValue))
            throw new ArgumentException("Password cannot be empty.");

        HashedValue = hashedValue;
    }

    // Static factory method for creating a new password by hashing a raw password
    public static Password Create(string rawPassword)
    {
        if (string.IsNullOrEmpty(rawPassword))
            throw new ArgumentException("Raw password cannot be empty.");

        if (rawPassword.Length < 8)
            throw new ArgumentException("Password must be at least 8 characters long.");

        return new Password(HashPassword(rawPassword));
    }

    // Password hashing method (using SHA256 for simplicity)
    private static string HashPassword(string password)
    {
        using (var sha256 = SHA256.Create())
        {
            var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
        }
    }

    // Verify if a raw password matches the hashed password
    public bool VerifyPassword(string rawPassword)
    {
        return HashedValue == HashPassword(rawPassword);
    }

    // Override equality components for value object comparison
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return HashedValue;
    }

    public override string ToString()
    {
        return HashedValue;
    }
}

