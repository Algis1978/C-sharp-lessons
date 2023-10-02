
//__1st EXERCISE
// Code project 1 - write code that validates integer input
// Here are the conditions that your first coding project must implement:

// Your solution must include either a do-while or while iteration.

// Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.

// Inside the iteration block:

// Your solution must use a Console.ReadLine() statement to obtain input from the user.
// Your solution must ensure that the input is a valid representation of an integer.
// If the integer value isn't between 5 and 10, your code must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.
// Your solution must ensure that the integer value is between 5 and 10 before exiting the iteration.

int validInteger = 0;
bool falseValue = true;
//Body
Console.WriteLine("Enter number between 5 and 10");
do 
{
string? userInteger = Console.ReadLine();
falseValue = int.TryParse(userInteger, out validInteger);
if (validInteger>5&&validInteger<10)
{Console.WriteLine ($"Your input value ({validInteger}) has been accepted"); break;}
else {
if (userInteger == "end")
{Console.WriteLine ($"You have stopped program");
break;}
Console.WriteLine ($"Sorry, you entered an invalid number, please try again, or enter 'end' to stop.");
falseValue=true;}
}
while (falseValue);

//Output
if (validInteger<5&&validInteger>10)
Console.WriteLine ($"Your input value ({validInteger}) has been accepted");

//__2nd EXERCISE
// Code project 2 - write code that validates string input
// Here are the conditions that your second coding project must implement:

// Your solution must include either a do-while or while iteration.

// Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for one of three role names: Administrator, Manager, or User.

// Inside the iteration block:

// Your solution must use a Console.ReadLine() statement to obtain input from the user.
// Your solution must ensure that the value entered matches one of the three role options.
// Your solution should use the Trim() method on the input value to ignore leading and training space characters.
// Your solution should use the ToLower() method on the input value to ignore case.
// If the value entered isn't a match for one of the role options, your code must use a Console.WriteLine() statement to prompt the user for a valid entry.

string validInput="";
string? userInput;
bool rightOption = true;
Console.WriteLine ($"Enter your role name (Administrator, Manager, or User)");
do
{
userInput = Console.ReadLine();
userInput = userInput.Trim();
validInput = userInput.ToLower();
if (validInput == "end") break;
if (validInput=="manager"||validInput=="administrator"||validInput=="user")
{
Console.WriteLine ($"Your input value ({validInput}) has been accepted.");
break;
} 
else 
Console.WriteLine ($"The role name that you entered, \"{validInput}\" is not valid. Enter your role name (Administrator, Manager, or User.");
Console.WriteLine($"Enter \"end\" to terminate.");
}
while (rightOption);

//__3d EXERCISE
// Code project 3 - Write code that processes the contents of a string array
// Here are the conditions that your third coding project must implement:

// your solution must use the following string array to represent the input to your coding logic:

// string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
// Your solution must declare an integer variable named periodLocation that can be used to hold the location of the period character within a string.

// Your solution must include an outer foreach or for loop that can be used to process each string element in the array. The string variable that you'll process inside the loops should be named myString.

// In the outer loop, your solution must use the IndexOf() method of the String class to get the location of the first period character in the myString variable. The method call should be similar 
// to: myString.IndexOf("."). If there's no period character in the string, a value of -1 will be returned.

// Your solution must include an inner do-while or while loop that can be used to process the myString variable.

// In the inner loop, your solution must extract and display (write to the console) each sentence that is contained in each of the strings that are processed.

// In the inner loop, your solution must not display the period character.

// In the inner loop, your solution must use the Remove(), Substring(), and TrimStart() methods to process the string information.

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad.", "I like all three of the menu choices." };
//body
for (int i = 0; i <myStrings.Length; i++)
{
    string item = myStrings[i];
    int periodPos = item.IndexOf(".");
    string sentence = "";
    while (periodPos != -1) 
    {
        sentence = item.Remove(periodPos);
        sentence = sentence.TrimStart();
        Console.WriteLine (sentence);
        item = item.Remove(0, periodPos+1);
        periodPos = item.IndexOf(".");
    }
}












