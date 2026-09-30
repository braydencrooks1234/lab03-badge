// Collect The Data
Console.Write("What is your first and last name? ");
string fullName = Console.ReadLine();

//create new variables with info given 

fullName = fullName.Trim();
int spacePosition = fullName.IndexOf(" ");
string firstName = fullName.Substring(0, spacePosition);
string lastName = fullName.Substring(spacePosition + 1);
char firstInitial = Convert.ToChar(firstName.Substring(0, 1));
char lastInitial = Convert.ToChar(lastName.Substring(0, 1));
firstInitial = char.ToUpper(firstInitial);
lastInitial = char.ToUpper(lastInitial);
string username = Convert.ToString(firstInitial) + lastName;
username = username.ToLower();
int nameLength = lastName.Length;
fullName = fullName.ToUpper();

//print out info

Console.WriteLine("Name on badge: " + fullName);
Console.WriteLine("Username: " + username);
Console.WriteLine($"Initials: {firstInitial}.{lastInitial}.");
Console.WriteLine("Letters in last name: " + nameLength);