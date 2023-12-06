string[,] corporate =
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external =
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

DisplayAllEmails(externalDomain);

void DisplayAllEmails(string externalDomain, string internalDomain = "contoso.com")
{
    PrintEmails(corporate, internalDomain);
    PrintEmails(external, externalDomain);
}

void PrintEmails(string[,] group, string domain)
{
    for (int i = 0; i < group.GetLength(0); i++)
    {
        // first two letters of the first name and entire last name
        string email = group[i, 0].Substring(0, 2) + group[i, 1] + "@" + domain;
        Console.WriteLine(email.ToLower());
    }
}