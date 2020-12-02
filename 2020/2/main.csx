#!/usr/bin/env dotnet-script

const int NumberOfPackages = 5433000;
var primes = File.ReadAllLines("primes.txt").Select(l => int.Parse(l)).ToArray();

var n = 0;
var packages = Enumerable.Range(0, NumberOfPackages).ToArray();
for (int i = 0; i < packages.Length; i++)
{
    var s = packages[i].ToString();
    if (s.Contains('7')) {
        var nearestLowerPrime = NearestLowerPrime(packages[i]);
        i += nearestLowerPrime;
    } else {
        n++;
    }
}

Console.WriteLine(n);

public int NearestLowerPrime(int n) {
    for (int i = 0; i < primes.Length; i++)
    {
        if (primes[i] > n) {
            return primes[i -1];
        }
    }

    throw new InvalidOperationException("Could not find the nearest lower prime");
}