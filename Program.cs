string pangram = "The quick brown fox jumps over the lazy dog";
string[] pangramArray = pangram.Split(' ');

string result = "";

foreach (string word in pangramArray)
{
    char[] letters = word.ToCharArray();
    Array.Reverse(letters);
    string reversedWord = new string(letters);
    result += reversedWord + " ";
}

Console.WriteLine(result);