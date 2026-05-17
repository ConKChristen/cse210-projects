using System;
using System.IO; 

class Program
{
    static int GetMenuChoice()
    {
        Console.WriteLine("Please choose one of the following:");
        Console.WriteLine("1.) Write");
        Console.WriteLine("2.) Display");
        Console.WriteLine("3.) Load");
        Console.WriteLine("4.) Save");
        Console.WriteLine("5.) Quit");
        Console.Write("Please enter the number you want to do: ");

        int input = int.Parse(Console.ReadLine());
        return input;
    }

    static void Main(string[] args)
    {
        bool exit = false;

        Journal myJournal = new Journal(); 

        while (exit == false)
        {
            int input = GetMenuChoice();

            if (input == 1)
            {
                // This should call the JournalEntry class

                JournalEntry myJournalEntry = new JournalEntry();
                myJournalEntry.CreateJournalEntry();
                myJournal.AddJournalEntry(myJournalEntry);
            }
            
            else if (input == 2)
            {
                // This should call the Journal class and display all journal entries, their prompts, and their date
                Console.WriteLine("");
                myJournal.DisplayJournal();
                Console.WriteLine("");
            }

            else if (input == 3)
            {
                // This should ask the user what filename they would like to load in
                Console.Write("Enter a filename to load from: ");
                string loadfile = Console.ReadLine();

                myJournal.LoadJournal(loadfile);
            }

            else if (input == 4)
            {
                // This will ask the user what filename they would like to save the list to
                Console.Write("Enter a filename to save to: ");
                string filename = Console.ReadLine();

                myJournal.SaveJournal(filename);
            }

            else if (input == 5)
            {
                Console.Write("Thank you. Have a nice day");
                exit = true;
            }   
        }
    }
}