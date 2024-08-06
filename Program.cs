namespace Snake_and_Ladder_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("               Snake and Ladder Game                 ");
            Console.WriteLine("-----------------------------------------------------");

            string player1Name;
            string player2Name;

            Console.Write("Enter the player 1 name:");
            player1Name=Console.ReadLine();
            Console.Write("Enter the player 2 name:");
            player2Name = Console.ReadLine();

            //if striker = 1 --> player 1
            //if striker = 1 --> player 2

            int Striker = 1;

            int player1Total = 0;
            int player2Total = 0;
            string playerName;
            int playerTotal=0;

            char roll;

            //create snakes and ladders
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

            // Add key-value pairs to the dictionary
            keyValuePairs.Add(2, 23);
            keyValuePairs.Add(8, 34);
            keyValuePairs.Add(20, 77);
            keyValuePairs.Add(29, 9);
            keyValuePairs.Add(32, 68);
            keyValuePairs.Add(38, 15);
            keyValuePairs.Add(41, 79);
            keyValuePairs.Add(47, 5);
            keyValuePairs.Add(53, 33);
            keyValuePairs.Add(62, 37);
            keyValuePairs.Add(74, 88);
            keyValuePairs.Add(82, 100);
            keyValuePairs.Add(85, 95);
            keyValuePairs.Add(86, 54);
            keyValuePairs.Add(92, 70);
            keyValuePairs.Add(97, 25);

            int checker = 0;

            // snakes and ladders

            do
            {
                if (Striker == 1)
                {
                    playerName = player1Name;
                    player2Total = playerTotal;
                    playerTotal = player1Total;
                    Striker = 2;
                }
                else
                {
                    playerName = player2Name;
                    player1Total = playerTotal;
                    playerTotal = player2Total;
                    Striker = 1;
                }
                Console.WriteLine("");
                Console.Write(playerName + " , Please roll the dice : (Press \"r\")");
                do
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey(); // Reads a single key
                    roll = keyInfo.KeyChar;
                } while (roll == 'r');
                //Int16.Parse(Console.ReadLine())
                
                Random random = new Random();
                int diceValue = random.Next(1, 7);
                Console.WriteLine("Dice value is : " + diceValue);

                    playerTotal = playerTotal + diceValue;

                foreach (var kvp in keyValuePairs)
                {
                    if (kvp.Key==playerTotal)
                    {
                        checker = 1;
                        int tempTotal = playerTotal;
                        playerTotal = kvp.Value;
                        if (playerTotal > tempTotal)
                        {
                            Console.WriteLine(playerName+" , you reach a ladder. Your new position is "+playerTotal);
                        }
                        else
                        {
                            Console.WriteLine(playerName + " , you reach a Snake . Your new position is " + playerTotal);
                        }
                        break;
                    }
                }
                if (checker == 0)
                {
                    Console.WriteLine(playerName + " your new position is " + playerTotal);
                }
                else
                {
                    checker = 0;
                }
                

            } while (!(playerTotal >= 100));

            Console.WriteLine(playerName + "is the WINNER ");
        }
    }
}
