using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_number12
{

   public  class RoshamboApp

    {
        
       // public Roshambo selectedItem = 0;

        public static void Main(string[] args)
        {
           RoshamboApp roshamboAppObject1 = new RoshamboApp();
            //static Roshambo selectedItem = 0;
            Roshambo selectedItem = 0;
            Player consolePlayer1 = new ConsolePlayer();
            Roshambo player1value = 0;
           string consolePlayerName = "";
            Player jets = new TheJets();
            Player Sharks = new TheSharks();             
            string playerOption = "";            
            string continue1 = "";
            Roshambo consolePlayerValue = 0;
           

            do
            {
                Console.WriteLine("Welcome to Rock Paper Scissors!");
                Console.WriteLine($"Enter your name:  ");
                consolePlayerName = Console.ReadLine();
                Console.WriteLine("Would you like to play against Thejets or TheSharks(j/s)?");
                playerOption = Console.ReadLine();
                if (playerOption == "j")
                {                          

                      jets.setPlayerName("Thejets");
                      
                       Console.WriteLine("Rock,Paper,scissors?(R/P/S):");

                    consolePlayerValue  = roshamboAppObject1.assignRoshamboValue(Console.ReadLine());
                    player1value = jets.generateRoshambo(consolePlayerValue );
                   selectedItem=  consolePlayer1.generateRoshambo(consolePlayerValue );

                       if (  selectedItem == Roshambo.rock)
                       {
                           Console.WriteLine($"{consolePlayerName}: {selectedItem}");
                           Console.WriteLine($"{jets.getPlayerName()}:{player1value}");
                           Console.WriteLine(" Draw");
                       }
                       else if (selectedItem == Roshambo.scissor)
                       {
                           Console.WriteLine($"{consolePlayerName}:{selectedItem}");
                           Console.WriteLine($"{jets.getPlayerName()}:{player1value}");
                           Console.WriteLine($"{jets.getPlayerName()} wins");
                       }
                       else
                       {
                           Console.WriteLine($"{consolePlayerName}:{selectedItem}");
                           Console.WriteLine($"{jets.getPlayerName()}:{player1value}");
                           Console.WriteLine($" {consolePlayerName} wins!");
                       }
                   }

                       else if (playerOption == "s")
                   {
                       Sharks.setPlayerName("The Sharks");
                       player1value = Sharks.generateRoshambo(selectedItem);
                       Console.WriteLine("Rock,Paper,scissors?(R/P/S):");

                 selectedItem = roshamboAppObject1.assignRoshamboValue(Console.ReadLine());
                       if (player1value == selectedItem)
                       {
                           Console.WriteLine($"{consolePlayerName}:{selectedItem}");
                           Console.WriteLine($"{Sharks.getPlayerName()}:{player1value}");

                           Console.WriteLine(" Draw!");
                       }
                       else
                      
                       if (((selectedItem == Roshambo.rock) || (player1value == Roshambo.scissor)) || ((selectedItem == Roshambo.paper) || (player1value == Roshambo.rock)) || ((selectedItem == Roshambo.scissor) || (player1value == Roshambo.paper)))

                       {
                           Console.WriteLine($"{consolePlayerName}:{selectedItem}");
                           Console.WriteLine($"{Sharks.getPlayerName()}:{player1value}");
                           Console.WriteLine($" {consolePlayerName} wins");
                       }
                       else
                       {
                           Console.WriteLine($"{consolePlayerName}:{selectedItem}");
                           Console.WriteLine($"{Sharks.getPlayerName()}:{player1value}");
                           Console.WriteLine($"{Sharks.getPlayerName()} wins");

                       }

                   }
               Roshambo consoleValue=(consolePlayer1.generateRoshambo(selectedItem));

                Console.WriteLine($"console input {consoleValue}");
                    Console.WriteLine("play again?:");
                    continue1 = Console.ReadLine().ToLower();                
            } while (continue1 == "y");

          }    
                   
         
           public   Roshambo assignRoshamboValue(string selectedValue)
        {

            if (selectedValue == "r")
            {
                return Roshambo.rock;
            }
            else if (selectedValue == "p")

            {
                return Roshambo.paper;

            }
            else if (selectedValue == "s")

            {
                return Roshambo.scissor;
            }
            else
                return Roshambo.none;
        }


     
    }
}
