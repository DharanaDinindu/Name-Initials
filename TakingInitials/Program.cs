using System;

namespace TakingInitials
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName = "";
            convertName(fullName);
        }

        public static void convertName(string fullName) 
        {
            //readimg user input
            Console.Write("Enter full name with spaces: ");
            fullName = Console.ReadLine();

            if (fullName != null && fullName != "")
            {
                seperateInitials(fullName);
            }
            else
            {
                Console.WriteLine("Name cannot be empty!!!");
            }
        }

        public static void seperateInitials(string fullName)
        {
            string name;
            char initial;
            string nameWithInt;
            string lastName;

            //an array to store the words seperately
            string[] nameByWords = fullName.Split();

            Console.Write("Name with initials: ");

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

            printNameWithInitials(nameWithInt);
        }

        public static void printNameWithInitials(string nameWithInt)
        {
            Console.WriteLine(nameWithInt);
        }
    }
}
