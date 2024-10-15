//Part 1
//Create a list of 5 names and then print them out to the console.
//Hint: You can use the Add() method to add items to the list and then use a foreach loop to print them out to the console.
Console.WriteLine("----Part 1----");
List<string> playerName = new();
playerName.Add("Asmodeus");
playerName.Add("ReiJi");
playerName.Add("Penaldo");
playerName.Add("Mohamed Satij");
playerName.Add("SeiMaiNem");
foreach (var name in playerName)
{
    Console.WriteLine(name);
}

//Part 2
//Using the list of names and find the name in the 3rd position and print it out to the console.
//Hint: You can use the index of the list to find the name in the 3rd position.
Console.WriteLine();
Console.WriteLine("----Part 2----");
Console.WriteLine("The name in the 3rd position is " + playerName[2]);
//Part 3
//Using the list of names, remove the name in the 2nd position and then print the list out to the console.
//Hint: You can use the RemoveAt() method to remove an item from the list.
Console.WriteLine();
Console.WriteLine("----Part 3----");
Console.WriteLine("The list of names after removing the 2nd position:");
playerName.RemoveAt(1);
foreach (var name in playerName)
{
    Console.WriteLine(name);
}
//Part 4
//Using the list of names, add a new name to the list and then print the list out to the console.
//Hint: You can use the Add() method to add a new name to the list.
Console.WriteLine();
Console.WriteLine("----Part 4----");
Console.WriteLine("The list of names after adding the new name:");
playerName.Add("Be Xuan Mike Lon Ton");
foreach (var name in playerName)
{
    Console.WriteLine(name);
}
//Part 5
//Using the list of names , find the length of the list and print it out to the console.
//Hint: You can use the Count property to find the length of the list.
Console.WriteLine();
Console.WriteLine("----Part 5----");
Console.WriteLine("The length of the list is " + playerName.Count);
//Part 6
//Using the list of names , check if a name exists in the list and print out if it exists or not.
//Hint: You can use the Contains() method to check if a name exists in the list.
Console.WriteLine();
Console.WriteLine("----Part 6----");
Console.WriteLine("Alexander in Player Name list is " + playerName.Contains("Alexander"));
//Part 7
//Using the list of names, find the index of a name in the list and print it out to the console.
//Hint: You can use the IndexOf() method to find the index of a name in the list.
Console.WriteLine();
Console.WriteLine("----Part 7----");
Console.WriteLine("Mohamed Satij is in the index {0} of the list", playerName.IndexOf("Mohamed Satij"));
//Part 8
//Using the list of names, insert a new name at the 3rd position and print the list out to the console.
//Hint: You can use the Insert() method to insert a new name at a specific position in the list.
Console.WriteLine();
Console.WriteLine("----Part 8----");
Console.WriteLine("After inserting the new name in the 3rd position, the new list is:");
playerName.Insert(2, "Do Nam Trung");
foreach (var name in playerName)
{
    Console.WriteLine(name);
}
//Part 9
//Using the list of names, sort the list and print it out to the console.
//Hint: You can use the Sort() method to sort the list.
Console.WriteLine();
Console.WriteLine("----Part 9----");
Console.WriteLine("The new list after sorting:");
playerName.Sort();
foreach (var name in playerName)
{
    Console.WriteLine(name);
}
//Part 10
//Using the list of names , use findlastindex() method to find the last index of a name in the list and print it out to the console.
//Hint: You can use the FindLastIndex() method to find the last index of a name in the list.
Console.WriteLine();
Console.WriteLine("----Part 10----");
Console.WriteLine("The last index of a name in the list is " + playerName.FindLastIndex(x => true));
//Part 11
//Using the list of names, clear the list and print the list out to the console.
//Hint: You can use the Clear() method to clear the list.
Console.WriteLine();
Console.WriteLine("----Part 11----");
Console.WriteLine("The new list after clear:");
playerName.Clear();
foreach (var name in playerName)
{
    Console.WriteLine(name);
}
//Part 12
//Create a new list of strings and integers and print them out to the console.
//Hint: You can use the Add() method to add items to the list and then use a foreach loop to print them out to the console.
Console.WriteLine();
Console.WriteLine("----Part 12----");
Console.WriteLine("The new list:");
playerName.Add("Neymar");
playerName.Add("Bale");
playerName.Add("Satij");
playerName.Add("VapCoHoiPen");
playerName.Add("Jackson");
foreach (var name in playerName)
{
    Console.WriteLine(name);
}
Console.ReadKey();



