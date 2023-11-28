const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity;
string output;

// Retrieving quantity between the span tag
const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingSpanPosition = input.IndexOf(openSpan);
int closingSpanPosition = input.IndexOf(closeSpan);

openingSpanPosition += openSpan.Length;
int quantityLength = closingSpanPosition - openingSpanPosition;

quantity = input.Substring(openingSpanPosition, quantityLength);

// Removing the div tag and replacing &trade with &reg
const string openDiv = "<div>";
const string closeDiv = "</div>";

int openingDivPosition = input.IndexOf(openDiv);
int openDivLength = openDiv.Length;
output = input.Remove(openingDivPosition, openDivLength);

int closingDivPosition = output.IndexOf(closeDiv);
output = output.Remove(closingDivPosition);

output = output.Replace("&trade", "&reg");

Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine($"Output: {output}");