// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

string firstFriend = "Maria";
string secondFriend = "Sophia";
Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");
Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
string greeting = "      Hello World!       ";
Console.WriteLine($"[{greeting}]");

string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");

string song = "Hi Hello, How are you";
Console.WriteLine(song.Contains("Hello"));
Console.WriteLine(song.Contains("greetings"));

int a = 9;
int b = 10;
int c = 3;
int d = (a + b) / c;
int e = (a + b) % c;
Console.WriteLine($"quotient: {d}");
Console.WriteLine($"remainder: {e}");

int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}");

var names = new List<string> { "Amit", "Sonu", "Prajjawal" };
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}

names.Remove("Prajjawal");

for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine($"Hello {names[i].ToUpper()}");
}

var fibonacciNumbers = new List<int> { 1, 1 }; // Starting the list off with the basics

var current = fibonacciNumbers[fibonacciNumbers.Count - 1]; // Take the last number in the list
var previous = fibonacciNumbers[fibonacciNumbers.Count - 2]; // Take the second to last number in the list

fibonacciNumbers.Add(current + previous); // Add the previous numbers together, and attach the sum to the end of the list

foreach (var item in fibonacciNumbers) // Print out the list
    Console.WriteLine(item);
