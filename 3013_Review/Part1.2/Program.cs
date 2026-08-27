/*
 Website Password Validator
Ask the user to enter a proposed password.

A valid password must:

Be at least 8 characters long
Contain at least one number
Contain at least one uppercase letter
Display whether the password is valid. 
    If it isn't, tell the user which requirements are missing.

 */

Console.WriteLine("Enter a proposed password:");
string password = Console.ReadLine();

bool isPasswordLongEnough = MeetsLengthRequirement(password);
bool hasUppercaseLetter = MeetsUppercaseRequirement(password);
bool hasNumber = MeetsNumberRequirement(password);

if (isPasswordLongEnough && hasUppercaseLetter && hasNumber)
{
    Console.WriteLine("Password is valid.");

}
else
{
    Console.WriteLine("Password is invalid. Please ensure your password meets the following requirements:");
    if (!isPasswordLongEnough)
    {
        Console.WriteLine("- Be at least 8 characters long");
    }
    if (!hasUppercaseLetter)
    {
        Console.WriteLine("- Contain at least one uppercase letter");
    }
    if (!hasNumber)
    {
        Console.WriteLine("- Contain at least one number");
    }
}

bool MeetsUppercaseRequirement(string? password)
{
    bool isValid = false;

    foreach (var character in password)
    {
        if (char.IsUpper(character) == true)
        {
            isValid = true;
            break;
        }
    }

    return isValid;
}
bool MeetsNumberRequirement(string? password)
{
    bool isValid = false;

    foreach (var character in password)
    {
        if (char.IsDigit(character) == true)
        {
            isValid = true;
            break;
        }
    }

    return isValid;
}
bool MeetsLengthRequirement(string? password)
{
    bool isValid = false;

    if (password.Length >= 8)
    {
        isValid = true;
    }

    return isValid;
}