//Declare random variable

Random rng = new Random();

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

Console.WriteLine("");
Console.WriteLine("Name on badge: " + fullName);
Console.WriteLine("Username: " + username);
Console.WriteLine($"Initials: {firstInitial}.{lastInitial}.");
Console.WriteLine("Letters in last name: " + nameLength);
Console.WriteLine("");

//Create locker info

int studentID = rng.Next(100000, 1000000);
Console.WriteLine("Student ID: " + studentID);
int lockerID = rng.Next(1, 501);
Console.WriteLine("Locker: " + lockerID);
Console.WriteLine("");

//Collect data for distance

Console.Write("Dorm x: ");
int dormX = Convert.ToInt32(Console.ReadLine());

Console.Write("Dorm y: ");
int dormY = Convert.ToInt32(Console.ReadLine());

Console.Write("Classroom x: ");
int classroomX = Convert.ToInt32(Console.ReadLine());

Console.Write("Classroom y: ");
int classroomY = Convert.ToInt32(Console.ReadLine());

Console.Write("What is your walking speed in feet per second? ");
double feetPerSecond = Convert.ToDouble(Console.ReadLine());

//Calculate distance and time

//distance = √( (x₂ − x₁)² + (y₂ − y₁)² )

double mathX = Math.Pow(classroomX - dormX, 2);
double mathY = Math.Pow(classroomY - dormY, 2);
double distance = Math.Sqrt(mathX + mathY);

int tripTime = Convert.ToInt32(distance / feetPerSecond);
int minutes = Convert.ToInt32(tripTime / 60);
int seconds = Convert.ToInt32(tripTime % 60);

//Print info

Console.WriteLine("Distance: " + Math.Round(distance, 1));
Console.WriteLine($"Walk time: {minutes} minutes {seconds} seconds");

//Part 4: The finished badge

int badgeID = (int)studentID % 9;

Console.WriteLine(new string('=', 34));
Console.WriteLine("ETSU STUDENT BADGE".PadLeft(26));
Console.WriteLine(new string('=', 34));

Console.WriteLine("NAME".PadRight(10) + fullName);
Console.WriteLine("USERNAME".PadRight(10) + username);
Console.WriteLine("ID".PadRight(10) + studentID);
Console.WriteLine("LOCKER".PadRight(10) + lockerID);
Console.WriteLine("WALK".PadRight(10) + minutes + "min" + seconds + "sec");

Console.WriteLine(new string('=', 34));