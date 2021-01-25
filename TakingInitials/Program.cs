using System;

namespace TakingInitials
{
    public class Program
    {
        static void Main(string[] args)
        {
            string fullName = GetFullNameFromConsole();
            string nameWithInitials = GetNameWithInitials(fullName);
            DisplayAnswer(nameWithInitials);
        }

        public static string GetFullNameFromConsole() 
        {
            //reading user input
            Console.Write("Enter full name with spaces: ");
            string fullName = Console.ReadLine();
            return fullName;
        }

        public static string GetNameWithInitials(string fullName)
        {
            string name;
            char initial;
            string nameWithInt;
            string lastName;

            //an array to store the words seperately
            string[] nameByWords = fullName.Split();

            Console.Write("Name with initials: ");

            if(nameByWords.Length > 1)
            {
                string initials = "";

                //taking the initials seperately
                for (int i = 0; i < nameByWords.Length - 1; i++)
                {
                    name = nameByWords[i];

                    initial = name[0];
                    initial = Char.ToUpper(initial);

                    initials += initial.ToString() + ". ";
                }

                lastName = nameByWords[nameByWords.Length - 1];

                nameWithInt = initials + lastName;
            }
             else
            {
                nameWithInt = nameByWords[0];
            }

            return nameWithInt;
        }

        public static void DisplayAnswer(string nameWithInt)
        {
            Console.WriteLine(nameWithInt);
        }
    }
}
