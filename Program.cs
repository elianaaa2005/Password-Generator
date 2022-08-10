//Password generator rewritten in C#

using System.Text;

Console.ForegroundColor = ConsoleColor.Cyan;
int passLength;
int userDecision;
Boolean loopCode0 = true;
Boolean loopCode1 = true;

const string lower = "abcdefghijklmnopqrstuvwxyz";
const string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
const string number = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
const string special = "!@#$%^&*_-=+1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
//constants
//variables
while (loopCode0 == true)
{
    loopCode1 = true;
    Console.WriteLine(@"Password Generator
Rewritten in C#
    ");
    //title
    Console.WriteLine(@"How many characters should be in your password?
A length between 8-16 characters is recommended:");

    passLength = int.Parse(s: Console.ReadLine());


    //password length decision
    while (loopCode1 == true)
    {
        Console.WriteLine(@"
Please choose the complexity of the password.
It's recommended to have a mix of character types in your password:");
        //message before complexity option menu
        Console.WriteLine(@"1. Only lowercase characters
2. Lowercase and uppercase characters
3. Lowercase/uppercase and numeric characters
4. Lowercase/uppercase/numeric characters and symbols");
        userDecision = int.Parse(s: Console.ReadLine());



        switch (userDecision)
        {
            case 1:
                StringBuilder passBuilder0 = new StringBuilder();
                Random rnd0 = new Random();
                for (int i = 0; i < passLength; i++)
                {
                    int index = rnd0.Next(lower.Length);
                    passBuilder0.Append(lower[index]);
                }
                loopCode1 = false;
                Console.WriteLine(@"
Your password is " + passBuilder0);
                break;
            case 2:
                StringBuilder passBuilder1 = new StringBuilder();
                Random rnd1 = new Random();
                for (int i = 0; i < passLength; i++)
                {
                    int index = rnd1.Next(upper.Length);
                    passBuilder1.Append(upper[index]);
                }
                loopCode1 = false;
                Console.WriteLine(@"
Your password is " + passBuilder1);
                break;
            case 3:
                StringBuilder passBuilder2 = new StringBuilder();
                Random rnd2 = new Random();
                for (int i = 0; i < passLength; i++)
                {
                    int index = rnd2.Next(number.Length);
                    passBuilder2.Append(number[index]);
                }
                loopCode1 = false;
                Console.WriteLine(@"
Your password is " + passBuilder2);
                break;
            case 4:
                StringBuilder passBuilder3 = new StringBuilder();
                Random rnd3 = new Random();
                for (int i = 0; i < passLength; i++)
                {
                    int index = rnd3.Next(special.Length);
                    passBuilder3.Append(special[index]);
                }
                loopCode1 = false;
                Console.WriteLine(@"
Your password is " + passBuilder3);
                break;
            default:
                Console.WriteLine(@"
That wasn't a valid option, please try again");
                Console.WriteLine("Press enter to proceed.");
                Console.ReadLine();
                Console.Clear();
                break;
        }
    }

    Console.WriteLine(@"
Press enter if you want to generate another password.
Alternatively, press close to exit the program.");
    Console.ReadLine();
    Console.Clear();
}