using System.ComponentModel.Design;
using System.Diagnostics;

namespace diceblackjack
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("HIII you wanted to play blackjack with dice right? well then trowe the dice by saying Trow");
            Console.WriteLine("Btw you are playing with my pc(dealer) and if he has more points then you at the end of the game, you will lose ;3");
            string playAgain = "yes".Trim().ToLower();
            while (playAgain == "yes".Trim().ToLower()) { 
                Console.WriteLine("Ah right you stop by saying Stop");
                Console.WriteLine("If you wanna play again just say yes when you are done W.W");
                Random dicePlayer = new Random();
                int randomNumber = dicePlayer.Next(1, 7);
                Random diceDealer = new Random();
                int dicePc = diceDealer.Next(1, 7);
                int dealerPoints = 0;
                int playerPoints = 0;
                string trowOrStop = Console.ReadLine().Trim().ToLower();
                while (trowOrStop == "trow".Trim().ToLower())
                {

                    if (dealerPoints >= 17)
                    {
                        randomNumber = dicePlayer.Next(1, 7);
                        playerPoints += randomNumber;
                        Console.WriteLine("You got " + randomNumber + " now you have " + playerPoints + " you can continue but you will lose if you get over 21 :3");
                        Console.WriteLine("Dealer have " + dealerPoints + " and will now stop");
                        if (dealerPoints > 21)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("You won0.0!!! thanks for playing my game =.= wanna try again?");
                            Console.ResetColor();
                            playAgain = Console.ReadLine().Trim().ToLower();
                            if (playAgain == "yes".Trim().ToLower())
                            {
                                break;
                            }
                        }
                        if (playerPoints > 21)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You lost did you really try it?" + " You want to try again or what?");
                            Console.ResetColor();
                            playAgain = Console.ReadLine().Trim().ToLower();
                            if (playAgain == "yes".Trim().ToLower())
                            { 
                                break;
                            }
                        }
                        trowOrStop = Console.ReadLine().Trim().ToLower();
                    }
                    else if (dealerPoints <= 17)
                    {
                        randomNumber = dicePlayer.Next(1, 7);
                        playerPoints += randomNumber;
                        dicePc = diceDealer.Next(1, 7);
                        dealerPoints += dicePc;
                        Console.WriteLine("You got " + randomNumber + " now you have " + playerPoints + " you can continue but you will lose if you get over 21 :3");
                        Console.WriteLine("Dealer got " + dicePc + " dealer have " + dealerPoints);
                        if (playerPoints > 21)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You lost did you really try it?" + " Well you lost wanna try again?");
                            Console.ResetColor();
                            playAgain = Console.ReadLine().Trim().ToLower();
                            if (playAgain == "yes".Trim().ToLower())
                            {
                                break;
                            }
                        }
                        trowOrStop = Console.ReadLine().Trim().ToLower();
                        }
                        if (trowOrStop == "stop".Trim().ToLower())
                        { if (dealerPoints > playerPoints)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You lost sadly the dealer gor more points then you... wanna try again? its better luck next time");
                            Console.ResetColor();
                            playAgain = Console.ReadLine().Trim().ToLower();
                            if (playAgain == "yes".Trim().ToLower())
                            {
                                break;
                            }
                        }

                        if (dealerPoints < 17)
                        {
                            dicePc = diceDealer.Next(1, 7);
                            dealerPoints += dicePc;
                            Console.WriteLine("Dealer got " + dicePc + " dealer have " + dealerPoints + " and stoped");
                        }

                        if (playerPoints <= dealerPoints && dealerPoints <= 21)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You lost sadly the dealer gor more or = points then you... wanna try again? its better luck next time");
                            Console.ResetColor();
                            playAgain = Console.ReadLine().Trim().ToLower();
                            if (playAgain == "yes".Trim().ToLower())
                            {
                                break;
                            }
                        }
                        if (playerPoints == 21 && dealerPoints >= 17 || playerPoints > dealerPoints && dealerPoints >= 17)
                        {
                            Console.ForegroundColor = ConsoleColor.Green ;
                            Console.WriteLine("You won0.0!!! thanks for playing my game =.= wanna try again?");
                            Console.ResetColor();
                            playAgain = Console.ReadLine().Trim().ToLower();
                            if (playAgain == "yes".Trim().ToLower())
                            { 
                                break; 
                            }
                        }

                    }

                }
            }
     //while loop slutar här




        }
    }
}
