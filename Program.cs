﻿string value = "102";
int result;

if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine("Unable to report the measurement");
}

if (result > 0)
    Console.WriteLine($"Measurement (w/ offset): {50 + result}");