using System;
using System.Collections;
class MainClass {

 public static void Main (string[] args) {

   Random myrand = new Random();
   
   string[] suites = {"Clubs","Diamonds","Hearts","Spades"};
   string[] values = {"A","2","3","4","5","6","7","8","9","10","J","Q","K"};

  /* nested loop that populates "Deck" ArrayList with instances of PlayingCard for each suite and value combination */
  
  ArrayList Deck = new ArrayList();
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 13; j++)
        {
          PlayingCard woop = new PlayingCard(suites[i],values[j]);
          Deck.Add(woop);
        }
        
    /* populates an array with a hand of unique PlayingCards and prints the hand */

    }
    int[] hand = new int[]{0,0,0,0,0};
    hand[0] = myrand.Next(51);
    for (int i =1; i < 5; i++)
    {
        int pos=myrand.Next(51);
        if (pos != hand[0] && pos != hand[1] && pos != hand[2] && pos != hand[3] && pos != hand[4])
        {
          hand[i] = pos;
        }
      }
    for (int i = 0; i < 5; i++)
    {
      Console.WriteLine(Deck[hand[i]].ToString());
    }
    }
  }
