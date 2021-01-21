using System;

namespace TakingInitials
{
    class Program
    {
        static void Main(string[] args)
        {
            //string to store the full name
            string fullName;

            string name;
            char initial;

            //readimg user input
            Console.Write("Enter full name with spaces: ");
            fullName = Console.ReadLine();

            //check whether the name is empty
            if(fullName != null && fullName != "")
            {
                //an array to store the words seperately
                string[] nameByWords = fullName.Split();

                Console.Write("Name with initials: ");

                //taking the initials seperately
                for (int i = 0; i < nameByWords.Length - 1; i++)
                {
                    name = nameByWords[i];

                    initial = name[0];
                    initial = Char.ToUpper(initial);

                    //writing the initials
                    Console.Write(initial + ". ");
                }

                //writing the last name
                Console.WriteLine(nameByWords[nameByWords.Length - 1]);
            } 
            else
            {
                Console.WriteLine("Name cannot be empty!!!");
            }

        }
    }
}
