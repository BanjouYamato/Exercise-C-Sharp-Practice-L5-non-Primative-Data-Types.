// To test out your code , comment the other parts and uncomment the part you want to test.
//To comment a part, select the part and press Ctrl + K + C
//To uncomment a part, select the part and press Ctrl + K + U
//Press Ctrl + F5 to run the code.




//Part 1
//Create a program so that it concatenates three strings and then outputs the result in uppercase.
//Hint: You can use the ToUpper() method to convert a string to uppercase.
//Hint: You can use the Console.WriteLine() method to output the result.
string stringA = "Hoang ";
string stringB = "Phuong ";
String stringC = "Nhung";
string stringD = stringA + stringB + stringC;
String stringE = stringD.ToUpper();
Console.WriteLine(stringE);
//Part 2
//Create a program so that it concatenates three strings and then outputs the result in lowercase.
//Hint: You can use the ToLower() method to convert a string to lowercase.
//Hint: You can use the Console.WriteLine() method to output the result.
string stringa = "Hoang ";
string stringb = "Phuong ";
String stringc = "Nhung";
string stringd = stringa + stringb + stringc;
String stringe = stringd.ToLower();
Console.WriteLine(stringe);
//Part 3
//Write a program to find the length of a string.
//Hint: You can use the Length property to find the length of a string.
//Hint: You can use the Console.WriteLine() method to output the result.
int stringLength = stringe.Length;
Console.WriteLine("do dai= " + stringLength);
//Part 4
//Write a program to find the index of a character in a string.
//Hint: You can use the IndexOf() method to find the index of a character in a string.
//Hint: You can use the Console.WriteLine() method to output the result.
Console.WriteLine("index of 'n': " + stringe.IndexOf('n'));
//Part 5
//Write a program to find the index of a character in a string starting from a specified position.
//Hint: You can use the IndexOf() method to find the index of a character in a string starting from a specified position.
//Hint: You can use the Console.WriteLine() method to output the result.
Console.WriteLine("index of 'n' start of 5: " + stringe.IndexOf('n', 5));
//Part 6
//Write a program to count the occurrences of a specific character in a string.
//Hint: You can use the Count() method to count the occurrences of a specific character in a string.
//Hint: You can use the Console.WriteLine() method to output the result.
int numbAppear = stringe.Count(c => c == 'n');
Console.WriteLine(numbAppear);

//Part 7
//Write a program to replace a character in a string with another character.
//Hint: You can use the Replace() method to replace a character in a string with another character.
//Hint: You can use the Console.WriteLine() method to output the result.
string stringf = stringe.Replace('n', 'N');
Console.WriteLine(stringf);
//Part 8
//Write a program to remove a character from a string.
//Hint: You can use the Remove() method to remove a character from a string.
//Hint: You can use the Console.WriteLine() method to output the result.
string stringj = stringe.Remove(1, 1);
Console.WriteLine(stringj);
//Part 9
//Write a program to replace all occurrences of a specific character in a string with another character.
//Hint: You can use the Replace() method to remove all occurrences of a specific character from a string.
//Hint: You can use the Console.WriteLine() method to output the result.
string stringh = stringe.Replace('o', 'O');
Console.WriteLine(stringh);
//Part 10
//Write a program to extract a substring from a string.
//Hint: You can use the Substring() method to extract a substring from a string.
//Hint: You can use the Console.WriteLine() method to output the result.
string stringi = stringe.Substring(6);
Console.WriteLine(stringi);
//Part 11
//Write a program to extract a substring from a string starting from a specified position.
//Hint: You can use the Substring() method to extract a substring from a string starting from a specified position.
//Hint: You can use the Console.WriteLine() method to output the result.
string stringk = stringe.Substring(6, 6);
Console.WriteLine(stringk);
//Part 12
//Write a program to remove leading and trailing whitespace from a string.
//Hint: You can use the Trim() method to remove leading and trailing whitespace from a string.
//Hint: You can use the Console.WriteLine() method to output the result.
string stringTest = "     chao em      ";
string stringFix = stringTest.Trim();
Console.WriteLine(stringTest);
Console.WriteLine(stringFix);
//Part 13 
//Write a program to parse a string to a number.
//Hint: You can use the Parse() method to parse a string to a number.
//Hint: You can use the Console.WriteLine() method to output the result.
string stringNumb = "125";
int numbTest = int.Parse(stringNumb);
Console.WriteLine(numbTest);
//Part 14
//Write a program to convert a number to a string.
//Hint: You can use the ToString() method to convert a number to a string.
//Hint: You can use the Console.WriteLine() method to output the result.
int numbToString = 1998;
string toString = numbToString.ToString();
Console.WriteLine(toString);








//////////////////Formating////////////////////





// Part 1

// You're organizing a team outing and need to print personalized event invitations.
// Develop a C# program that uses placeholders to create customized invitations.
// Replace the placeholders with the recipient's name, event date, and current time.
// Hint: Use composite formatting with placeholders to create personalized invitations.
// Test Data:
// Recipient's name: Alice
// Event date: January 15, 2025
// Expected Output:
// Hello, Alice! You're invited to our team outing on January 15, 2025. The event starts at 09:00.

Console.WriteLine("please input name: ");
string name = Console.ReadLine();
Console.WriteLine("input date: ");
string eventDate = Console.ReadLine();
Console.WriteLine("Hello, {0}! You're invited to our team outing on {1}. The event starts at 09:00", name, eventDate);






// Part 2

// Imagine you're managing an online store and need to send order confirmation emails.
// Write a C# program that utilizes placeholders to generate order confirmation emails.
// Fill in the placeholders with the customer's name, order ID, and purchase details.
// Hint: Use composite formatting with placeholders to generate order confirmation emails.
// Test Data:
// Customer's name: John Doe
// Order ID: 123456
// Purchase details: 2 x T-shirts, 3 x Jeans
// Expected Output:
// Dear John Doe, your order (ID: 123456) has been confirmed. You've purchased: 2 x T-shirts, 3 x Jeans.

Console.WriteLine("input customer name: ");
string customerName = Console.ReadLine();
Console.WriteLine("input ID: ");
string id = Console.ReadLine();
Console.WriteLine("input purchase detail: ");
string purchaseDetails = Console.ReadLine();
Console.WriteLine("Dear {0}, you order (ID: {1}) has been confirmed. You've purchased: {2}", customerName, id, purchaseDetails);







// Part 3

// Picture yourself developing a task management application and need to display task reminders.
// Create a C# program that employs placeholders to format task reminder messages.
// Populate the placeholders with the task name, due date, and priority level.
// Hint: Use composite formatting with placeholders to format task reminder messages.
// Test Data:
// Task name: Complete Project Proposal
// Due date: May 10, 2025
// Priority level: High
// Expected Output:
// Reminder: Complete Project Proposal is due on May 10, 2025. Priority: High.

Console.WriteLine("input task name: ");
string taskName = Console.ReadLine();
Console.WriteLine("input due date: ");
string dueDate = Console.ReadLine();
Console.WriteLine("input prioty level: ");
string priotyLevel = Console.ReadLine();
Console.WriteLine("Reminder: Complete {0} is due on {1}. Prioty: {2}", taskName, dueDate, priotyLevel);







// Part 4

// You're working on a scheduling application and need to generate event reminders.
// Develop a C# program that utilizes placeholders to format event reminder notifications.
// Fill in the placeholders with the event title, location, and start time.
// Hint: Use composite formatting with placeholders to format event reminder notifications.
// Test Data:
// Event title: Team Meeting
// Location: Conference Room A
// Start time: 10:00 AM
// Expected Output:
// Reminder: Team Meeting at Conference Room A starts at 10:00 AM.


Console.WriteLine("input event title: ");
string title = Console.ReadLine();
Console.WriteLine("input location: ");
string location = Console.ReadLine();
Console.WriteLine("input start time: ");
string startTime = Console.ReadLine();
Console.WriteLine("Reminder: {0} at {1} starts at {2}", title, location, startTime);









// Part 5

// Imagine you're designing a travel app and need to provide flight departure information.
// Write a C# program that employs placeholders to format flight departure notifications.
// Populate the placeholders with the flight number, departure airport, and scheduled time.
// Hint: Use composite formatting with placeholders to format flight departure notifications.
// Test Data:
// Flight number: ABC123
// Departure airport: JFK International Airport
// Scheduled time: 08:30 AM
// Expected Output:
// Flight ABC123 departing from JFK International Airport is scheduled for 08:30 AM.

Console.WriteLine("input filght number: ");
string flightNumb = Console.ReadLine();
Console.WriteLine("input deprture airport: ");
string depart = Console.ReadLine();
Console.WriteLine("input scheduled time: ");
string schedule = Console.ReadLine();
Console.WriteLine("Flight {0} departing from {1} is scheduled for {2}", flightNumb, depart, schedule);












// Part 6

// You're developing a messaging application and want to greet the user.
// Write a C# program that asks the user to enter their name.
// Then, use interpolation to display a personalized greeting message.
// Hint: Use the Console.ReadLine() method to get user input and string interpolation to format the message.
// Test Data:
// Enter your name: Alice
// Expected Output:
// Hello, Alice! Welcome to our messaging app.


Console.WriteLine("input user name: ");
string userName = Console.ReadLine();
Console.WriteLine("Hello, {0}! Welcome to our messaging app.", userName);









// Part 7

// You're organizing a fantasy-themed event and need to print custom badges for the participants.
// Develop a C# program that prompts the user to enter their character's name and class.
// Then, concatenate the name and class, and print the result.
// Hint: Use the + operator to concatenate strings and the Console.WriteLine() method to print the result.
// Test Data:
// Character's name: Legolas
// Character's class: Archer
// Expected Output:
// Custom Badge: Legolas the Archer

Console.WriteLine("input character name: ");
string characterName = Console.ReadLine();
Console.WriteLine("input character class: ");
string characterClass = Console.ReadLine();
Console.WriteLine("Custom Badge: {0} the {1}", characterName, characterClass);










// Part 8

// Picture yourself managing a music playlist and need to display the total duration of a song.
// Write a C# program that calculates and formats the total duration of a song in minutes and seconds.
// Prompt the user to enter the song's duration in seconds.
// Then, calculate the minutes and seconds and display the formatted duration.
// Hint: Use integer division and modulus to separate minutes and seconds, and composite formatting to display them.
// Test Data:
// Enter the song's duration in seconds: 245
// Expected Output:
// Song Duration: 4 minutes 5 seconds

Console.WriteLine("input song duration");
string songDur = Console.ReadLine();
int songNumb = int.Parse(songDur);
int minuteNumb = songNumb / 60;
int secondNumb = songNumb % 60;
Console.WriteLine("song duration : {0} minutes {1} seconds", minuteNumb, secondNumb);






// Part 9

// Imagine you're developing a recipe app and want to display the serving size.
// Create a C# program that formats and displays the serving size of a recipe.
// Prompt the user to enter the number of servings.
// Then, display the serving size aligned to the right with a width of 5 characters.
// Hint: Use composite formatting with alignment to display the serving size.
// Test Data:
// Enter the number of servings: 8
// Expected Output:
// Serving Size:     8

Console.WriteLine("please input number: ");
string input = Console.ReadLine();
Console.WriteLine(input.PadLeft(5));








// Part 10

// You're designing a finance application and need to show the current account balance.
// Develop a C# program that formats and displays the account balance.
// Prompt the user to enter the account balance.
// Then, display the balance aligned to the right with two decimal places.
// Hint: Use composite formatting with alignment and precision to display the account balance.
// Test Data:
// Enter the account balance: 1050.75
// Expected Output:
// Account Balance: 1050.75

Console.WriteLine("input accout balance: ");
string acb = Console.ReadLine();
Console.WriteLine(string.Format("Account Balance: ", acb.PadLeft(5)));







// Part 11

// You're building a movie ticket booking system and need to present the ticket price.
// Write a C# program that calculates and formats the ticket price with discounts.
// Prompt the user to enter the ticket price and discount percentage.
// Then, calculate the discounted price and display it aligned to the right with two decimal places.
// Hint: Use composite formatting with alignment and precision to display the discounted price.
// Test Data:
// Enter the ticket price: 25.50
// Enter the discount percentage: 15
// Expected Output:
// Discounted Price: 21.68

Console.WriteLine("input ticket price: ");
float ticketPrice = float.Parse(Console.ReadLine());
Console.WriteLine("input discount percentage: ");
float percent = float.Parse(Console.ReadLine());
float realPrice = ticketPrice - ticketPrice * percent / 100;
string price = realPrice.ToString();
Console.WriteLine("Discounted Price: " + price.PadLeft(5));







// Part 12

// Picture yourself developing a gaming platform and need to display the player's score.
// Create a C# program that formats and displays the player's score.
// Prompt the user to enter the player's score.
// Then, display the score aligned to the right with a width of 8 characters.
// Hint: Use composite formatting with alignment to display the player's score.
// Test Data:
// Enter the player's score: 10325
// Expected Output:
// Player's Score:   10325

Console.WriteLine("input score: ");
int score = int.Parse(Console.ReadLine());
Console.WriteLine("Player's Score: {0,4}", score);
Console.ReadKey();






// Part 13

// You're working on a data analysis tool and need to present the statistical results.
// Develop a C# program that formats and displays the average value of a dataset.
// Prompt the user to enter a series of numbers separated by spaces.
// Then, calculate the average value and display it aligned to the right with two decimal places.
// Hint: Use composite formatting with alignment and precision to display the average value.
// Test Data:
// Enter a series of numbers: 10 15 20 25 30
// Expected Output:
// Average Value: 20.00


Console.WriteLine("input number series (seperate by space): ");
string inputNumb = Console.ReadLine();
string[] stringToNumb = inputNumb.Split(' ');
double tong = 0;
foreach (string s in stringToNumb)
{
    double numbChang = double.Parse(s);
    tong += numbChang;
}
Console.WriteLine("average = {0}", (tong / stringToNumb.Length));







// Part 14

// Imagine you're designing a weather app and need to show the temperature forecast.
// Write a C# program that calculates and formats the average temperature.
// Prompt the user to enter the temperatures for three days separated by spaces.
// Then, calculate the average temperature and display it aligned to the right with one decimal place.
// Hint: Use composite formatting with alignment and precision to display the average temperature.
// Test Data:
// Enter temperatures for 3 days: 25.5 28.7 22.3
// Expected Output:
// Average Temperature: 25.5

Console.WriteLine("input temp in 3 days: ");
string temp = Console.ReadLine();
string[] tempToNumb = temp.Split(' ');
double tong1 = 0;
foreach (string tempText in tempToNumb)
{
    double tempNumb = double.Parse(tempText);
    tong1 += tempNumb;
}
double tempAve = tong1 / tempToNumb.Length;
string finalResult = string.Format($"Average Temperature: {tempAve,10:f1}");
Console.WriteLine(finalResult);









// Part 15

// You're building a fitness tracker and need to present the daily step count.
// Create a C# program that formats and displays the total steps for a day.
// Prompt the user to enter the steps taken.
// Then, display the step count aligned to the right with a width of 6 characters.
// Hint: Use composite formatting with alignment to display the step count.
// Test Data:
// Enter the steps taken: 12345
// Expected Output:
// Step Count:  12345

Console.WriteLine("input count foot step: ");
int footStep = int.Parse(Console.ReadLine());
string footStepCheck = string.Format($"Step Count: {footStep,6}");



