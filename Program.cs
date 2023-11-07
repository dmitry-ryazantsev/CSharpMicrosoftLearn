string[] roles = new string[] { "administrator", "manager", "user" };
string? readResult;
string roleName = "";
bool validString = false;

Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

while (validString == false)
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        roleName = readResult.ToLower().Trim();
        if (roles.Contains(roleName))
        {
            validString = true;
        }
        else
            Console.WriteLine($"The role name that you entered, '{readResult}', is not valid.");
    }
}

Console.WriteLine($"Your input value ({roleName}) has been accepted.");