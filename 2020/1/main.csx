#!/usr/bin/env dotnet-script

var input = File.ReadAllText("input.txt");
var numbers = input.Split(',', StringSplitOptions.RemoveEmptyEntries).Select(s => int.Parse(s)).ToArray();

var oneTo100K = Enumerable.Range(1, 100000);
foreach (var n in oneTo100K)
{
    if (!numbers.Contains(n)) {
        Console.WriteLine(n);
        return;
    }
}

Console.WriteLine("Could not find an answer...");
