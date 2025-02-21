﻿
//**Arrays unlike lists have a fixed size and cannot be changed once they are created.**//


//---------------------------------------------------------------------
// Part 1: Printing Array Elements
// Create an array of 5 countries and then print them out to the console.
// Hint: Use a foreach loop to print the array elements.

// Array names = new string[5] { "John", "Jane", "Jack", "Jill", "James" };
// foreach (string name in names)
// {
//     Console.WriteLine(name);
// }
Console.WriteLine("----Part 1----");
Console.WriteLine();
string[] Countries = new string[5] { "Japan", "Korea", "England", "America", "China" };
foreach (string country in Countries)
    Console.WriteLine(country);
//---------------------------------------------------------------------
// Part 2: Accessing Array Elements by Index
// Using the array of countries, find the name in the 3rd position and print it out to the console.
// Hint: Use the index of the array to access the name in the 3rd position.
Console.WriteLine();
Console.WriteLine("----Part 2----");
Console.WriteLine();
Console.WriteLine("The name in the 3rd position is " + Countries[2]);
//---------------------------------------------------------------------
// Part 3: Removing an Element from the Array
// Using the array of countries, remove the name in the 2nd position and then print the array out to the console.
// Hint: Use the RemoveAt() method to remove an item from the array.
Console.WriteLine();
Console.WriteLine("----Part 3----");
Console.WriteLine();
string[] newCountries = new string[Countries.Length - 1];
for (int i = 0, j = 0; i < Countries.Length; i++)
{
    if (i == 1)
        continue;
    newCountries[j] = Countries[i];
    j++;
}
foreach (string country in newCountries)
    { Console.WriteLine(country); }
//---------------------------------------------------------------------
// Part 4: Replacing an Element in the Array
// Using the array of countries, replace the name in the 3rd position with a new name and then print the array out to the console.
// Hint: Use the index of the array to replace the name in the 3rd position with a new name.
Console.WriteLine();
Console.WriteLine("----Part 4----");
Console.WriteLine();
newCountries[2] = "Taiwan";
foreach (string country in newCountries)
    { Console.WriteLine(country); }
//---------------------------------------------------------------------
// Part 5: Finding the Length of the Array
// Using the array of countries, find the length of the array and print it out to the console.
// Hint: Use the Length property to find the length of the array.
Console.WriteLine();
Console.WriteLine("----Part 5----");
Console.WriteLine();
Console.WriteLine("The length of the array is " + newCountries.Length);
//---------------------------------------------------------------------
// Part 6: Checking if an Element Exists in the Array
// Using the array of countries, check if a name exists in the array and print out if it exists or not.
// Hint: Use the Contains() method to check if a name exists in the array.
Console.WriteLine();
Console.WriteLine("----Part 6----");
Console.WriteLine();
Console.WriteLine("Korea exists in the array is " + newCountries.Contains("Korea"));
//---------------------------------------------------------------------
// Part 7: Finding the Index of an Element in the Array
// Using the array of countries, find the index of a name in the array and print it out to the console.
// Hint: Use the IndexOf() method to find the index of a name in the array.
Console.WriteLine();
Console.WriteLine("----Part 7----");
Console.WriteLine();
int indexToFind = Array.IndexOf(newCountries, "Japan");
Console.WriteLine("the index of Japan in the array is " + indexToFind);
Console.ReadKey();

