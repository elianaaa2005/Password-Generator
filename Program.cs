using System;
using System.Linq;

public class Program
{
    public static string GeneratePassword(int length, int complexity)
    {
        var charSets = new Dictionary<int, string>()
        {
            { 1, "abcdefghijklmnopqrstuvwxyz" },
            { 2, "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ" },
            { 3, "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789" },
            { 4, string.Concat(Enumerable.Range(32, 95).Select(i => (char)i)).Replace(" ", "") }
        };

        string charSet = charSets.ContainsKey(complexity) ? charSets[complexity] : charSets[1];

        Random random = new Random();
        string password = new string(Enumerable.Repeat(charSet, length).Select(s => s[random.Next(s.Length)]).ToArray());

        return password;
    }

    public static void Main()
    {
        Console.WriteLine("Password Generator v2.0");

        while (true)
        {
            try
            {
                Console.Write("How many characters should be in your password? (8-16 characters): ");
                int length = int.Parse(Console.ReadLine());

                if (length >= 8 && length <= 16)
                {
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine(@"Please choose the complexity of the password:
1: Only lowercase
2: Lowercase and uppercase
3: Lowercase, uppercase, and numbers
4: Lowercase, uppercase, numbers and symbols");

                            int complexity = int.Parse(Console.ReadLine());

                            if (complexity >= 1 && complexity <= 4)
                            {
                                string password = GeneratePassword(length, complexity);

                                Console.WriteLine($"Your generated password is: {password}");

                                while (true)
                                {
                                    Console.Write("Press enter or type 'close' to exit: ");
                                    string choice = Console.ReadLine().Trim().ToLower();

                                    if (choice == "close")
                                    {
                                        return;
                                    }
                                    else if (!string.IsNullOrEmpty(choice))
                                    {
                                        Console.WriteLine("Please press enter or type 'close'.");
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }

                                break;
                            }
                            else
                            {
                                Console.WriteLine("Please enter a valid number between 1 and 4.");
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Please enter a valid number between 1 and 4.");
                        }
                    }

                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid number between 8 and 16.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a valid number between 8 and 16.");
            }
        }
    }
}
