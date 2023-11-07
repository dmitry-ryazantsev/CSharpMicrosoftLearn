string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

for (int i = 0; i < stringsCount; i++)
{
    string myString = myStrings[i];
    int periodLocation = myString.IndexOf(".");
    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {
        // remove everything after the first period
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location with any leading white-space removed
        myString = myString.Substring(periodLocation + 1).TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }

    // prints the last two sentences
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}