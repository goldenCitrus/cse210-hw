// using System;

class Program
{
    public static List<string> toBeSaved = new List<string>();
    static char selection;
    static void Main(string[] args)
    {
        while (selection != '5')
    {
        Console.Write("\nwhat would you like to do?\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\n\n>");
        char selection = Console.ReadKey().KeyChar;

        
        if (selection == '1')// Question is asked, and entry(along with the question) is stored to toBeSaved
        {
            QuestionGenerator question = new QuestionGenerator();
            string asked_question = question.GenerateQuestion();
            Console.WriteLine($"\n{asked_question}");
            string entry = Console.ReadLine();
            DateTime date = DateTime.Now;
            EntryStorage store = new EntryStorage();
            store._date = date;
            store._askedQuestion = asked_question;
            store._entry = entry;
            store.TempEntry();
            Console.Write("\nPress enter to return to the main menu\n>\r");
            Console.ReadLine();
        }else if (selection == '2')// The data stored in toBeSaved is displayed
        {
        foreach (var item in toBeSaved)
        {
            Console.WriteLine($"\n{item}");
        }
        Console.Write($"Press enter to return to the main menu\n>\r");
        Console.ReadLine();
        }else  if (selection == '3')// The user is prompted for a filename, and then the entered file is loaded into toBeSaved
        {
            Console.Write("\nWhat is the name of the text file you would like to open>\n>");
            string file_name = Console.ReadLine();
            LoadEntry load = new LoadEntry();
            load._fileName = file_name;
            load.EntryLoader();
        }else if (selection == '4')// The user is prompted for a filename so save ther entries in, and the entries are saved to a txt
        {
            Console.Write("\nWhat would you like to name this text file?\n>");
            string file_name = Console.ReadLine();
            SaveEntry save = new SaveEntry();
            save._fileName = file_name;
            save._textContent = toBeSaved;
            save.EntrySaver();
            
        }else if (selection == '5')// The loop breaks, and the program ends
        {
            break;
        }
    }
    }
}