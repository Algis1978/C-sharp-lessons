
//__1st EXERCISE
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












