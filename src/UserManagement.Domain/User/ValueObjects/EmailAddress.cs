using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UserManagement.Domain.Common.Models;
namespace UserManagement.Domain.ValueObjects;

public class EmailAddress : ValueObject
{
    public string Value { get; }

    private EmailAddress(string value)
    {
        if (string.IsNullOrEmpty(value))
            throw new ArgumentException("Email address cannot be empty.");

        if (!IsValidEmail(value))
            throw new ArgumentException("Invalid email format.");

        Value = value;
    }

    // Static factory method for creating a new email address
    public static EmailAddress Create(string value)
    {
        return new EmailAddress(value);
    }

    // Email validation method
    private static bool IsValidEmail(string email)
    {
        var emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        return emailRegex.IsMatch(email);
    }

    // Override equality components for value object comparison
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString()
    {
        return Value;
    }
}

