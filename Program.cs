using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace cricket;

class Program
{

    struct Player // Creating player sturcture
    {
        public string Name;
        public int Score;

        public Player(string name, int score) //Initialize Values
        {
            Name = name;
            Score = score;
        }
        public override string ToString() //Overiding string printout
        {
            return $"Name: {Name}, Score: {Score}";
        }
    }
    static Player[] player = new Player[11]; //Initializing a Team player array


    static void getInfo() //Get Neccessary Info about Players
    {
        for (int i = 0; i < 11; i++) // Loop through amount of players
        {
            Console.Write($"Player {i + 1} - Enter Name: ");
            string playerName = Console.ReadLine();

            while (checkName(playerName) == false) // loops until player name is not ""
            {
                Console.WriteLine("Invalid name. Please enter a name.");
                Console.Write($"Player {i + 1} - Enter Name: ");
                playerName = Console.ReadLine();
            }
            player[i].Name = playerName; //SETTING THE NAME OF PLAYERS
            do //Loops until the score entered is valid 
            {
                Console.Write("Enter Score: ");
                string playerScoreString = Console.ReadLine();
                if (int.TryParse(playerScoreString, out int score))
                {
                    if (score >= 0 && score <= 500)
                    {
                        player[i].Score = score; // SETTING THE SCORE OF PLAYERS
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid score. Please enter a score between 0 and 500");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid score. Please enter a score between 0 and 500");
                }
            } while (true);
        }
    }
    static bool checkName(string name) //Just checks to see if the inputted name is "" or not
    {
        if (name == "")
        {
            return false;
        }
        return true;
    }


    static void sortByName() //Bubble sorts through the list of players by Name from Bubble sort program (Descending)
    {
        int playerArrayLength = player.Length;

        for (int p = 0; p <= playerArrayLength - 2; p++) // Outer loop for passes
        {
            for (int i = 0; i <= playerArrayLength - 2; i++) // Inner loop for comparison and swapping
            {
                if (player[i].Name.CompareTo(player[i + 1].Name) > 0) // Check if the current name is before the next
                {
                    // Swap the items
                    Player temp = player[i];
                    player[i] = player[i + 1]; // Swapping Names
                    player[i + 1] = temp;
                }
            }
        }
    }

    static void sortByScore() // Bubble sorts through the list of players by score from bubble sort program (Descending)
    {
        int playerArrayLength = player.Length;

        for (int p = 0; p <= playerArrayLength - 2; p++) // Outer loop for passes
        {
            for (int i = 0; i <= playerArrayLength - 2; i++) // Inner loop for comparison and swapping
            {
                if (player[i].Score < player[i + 1].Score) // Checking if the current score is less than the next
                {
                    // Swap the items
                    Player temp = player[i];
                    player[i] = player[i + 1]; // Swapping scores
                    player[i + 1] = temp;
                }
            }
        }
    }
    static void printPlayers() // Method for printing each player on the team 
    {
        foreach (Player player in player)
        {
            Console.WriteLine(player);
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Cricket Score Program!");
        getInfo();
        Console.Write("Do you want to sort by name or by scores? (enter N or S): ");

        do // Loops until a valid Choice for sorting is entered.
        {
            string sortingChoice = Console.ReadLine();
            if (sortingChoice == "N" || sortingChoice == "n")
            {
                Console.WriteLine("Sorted by name:");
                sortByName();
                printPlayers();
                break;
            }
            else if (sortingChoice == "S" || sortingChoice == "s")
            {
                Console.WriteLine("Sorted by score:");
                sortByScore();
                printPlayers();
                break;
            }
            else
            {
                Console.WriteLine("Invalid Choice, (enter N or S): ");
            }
        } while (true);
    }
}
