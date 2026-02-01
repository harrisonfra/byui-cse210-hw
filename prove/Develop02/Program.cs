using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "6";
        Journal journalNew = new Journal();
        Console.WriteLine(@"#     #                                           ### 
#  #  # ###### #       ####   ####  #    # ###### ### 
#  #  # #      #      #    # #    # ##  ## #      ### 
#  #  # #####  #      #      #    # # ## # #####   #  
#  #  # #      #      #      #    # #    # #          
#  #  # #      #      #    # #    # #    # #      ### 
 ## ##  ###### ######  ####   ####  #    # ###### ### ");
        Console.WriteLine("Welcome to the journal program!");
        while (input != "5")
        {
            Console.WriteLine("");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            input = Console.ReadLine();

            if (input == "1")
            {
               
                journalNew.WriteEntry();

            }
            else if (input == "2")
            {
                
                journalNew.DisplayEntries();
            }
            else if (input == "3")
            {
                journalNew.LoadJournal();
            }
            else if (input == "4")
            {
                journalNew.SaveToJournal();
            }
            else if (input == "5")
            {
                Entry myJournal = new Entry();
                myJournal.Exit();
            }
            else
            {
                Console.WriteLine("Input not recognized!");
            }


        }


    }
}