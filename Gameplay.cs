using System;
using System.Collections.Generic;

namespace Project
{
public class Gameplay
{
    public static void place_bet(Chip chips)
    {
        
        while (true)
        {
            Console.WriteLine("Enter the amount of bet placed");

            int betAmount=Convert.ToInt32(Console.ReadLine());
            chips.setBet(betAmount);
            if(chips.getBet()>chips.getTotal())
            {
                Console.WriteLine("not enough money");
                continue;
            }
            else
            {
                break;
            }

           
            
        }
    }

    public static void hit(Hand hand,Deck deck,Dictionary<string, int> values)
    {
        Card single_card=deck.deal();
        hand.add_card(single_card,values);
        hand.adjust_ace();
    }

    public static bool hit_stand(Hand player,Deck deck,bool playing,Dictionary<string, int> values)
    {
        
        while (true)
        {

            Console.WriteLine("Enter h for hit and s for Stand \n");
            
            string d = Console.ReadLine();

            if (d[0]=='h')
            {
                hit(player,deck,values);
                return playing;
            }

            else if (d[0]=='s')
            {
                Console.WriteLine("Player Stands Dealer's Turn");
                playing=false;
                return playing;
            }
            else
            {
                Console.WriteLine("Invalid choice");
                continue;
            }
        }
    }

    public static void player_busts(Chip chips)
    { Console.WriteLine("Player Busts! ");
        chips.lose_bet();
    }

    public static void player_wins(Chip chips)
    {Console.WriteLine("Player Wins! ");
        chips.win_bet();
    }

    public static void dealer_busts(Chip chips)
    {Console.WriteLine("Dealer  Busts!");
        chips.win_bet();
    }

    public static void dealer_wins(Chip chips)
    {Console.WriteLine("Dealer Wins ");
        chips.lose_bet();
    }

    public static void push()
    {Console.WriteLine("\nIt's a tie!PUSH \n");}

    public static void show_some(Hand player,Hand dealer)
    {   Console.WriteLine("\nPlayer's hands");
        var enu = player.getCards();
        foreach (var one in enu) 
            Console.WriteLine(one.ToString());

        Console.WriteLine("\ndealer's hands");
        Console.WriteLine("one card hidden!");
        Console.WriteLine(dealer.getCards()[1].ToString());
    }

    public static void show_all(Hand player,Hand dealer)
    {
        Console.WriteLine("\nPlayer's hands");
        var enu2 = player.getCards();
        foreach (var one in enu2) 
            Console.WriteLine(one.ToString());


        Console.WriteLine("\ndealer's hands");
        var enu1 = dealer.getCards();
        foreach (var one in enu1) {
            Console.WriteLine(one.ToString());
    }
        }

}
}