using System;
using System.Collections.Generic;
using System.Linq;

class DeckOfCards
{
    static void Main(string[] args)
    {
        List<string> deck = Console.ReadLine().Split(',').ToList();
        int numberOfCommands = int.Parse(Console.ReadLine());
        for (int i = 0; i < deck.Count; i++)
        {
            deck[i] = deck[i].Trim();
        }
       
        for (int i = 1; i <= numberOfCommands; i++)
        {
            string[] commandInfo = Console.ReadLine().Split(',');
            string command = commandInfo[0];

            if (command == "Add")
            {
                string card = commandInfo[1].Trim();
                if (deck.Contains(card))
                {
                    Console.WriteLine("Card is already in the deck");
                }
                else
                {
                    deck.Add(card);
                    Console.WriteLine("Card successfully added");
                }
            }
            else if (command == "Remove")
            {
                string card = commandInfo[1].Trim();
                if (deck.Contains(card))
                {
                    deck.Remove(card);
                    Console.WriteLine("Card successfully removed");
                }
                else Console.WriteLine("Card not found");
            }
            else if (command == "Remove At")
            {
                int index = int.Parse(commandInfo[1].Trim());

                if (index>=0 && index< deck.Count)
                {
                    deck.RemoveAt(index);
                    Console.WriteLine("Card successfully removed");
                }
                else Console.WriteLine("Index out of range");
            }
            else if (command == "Insert")
            {
                int index = int.Parse(commandInfo[1].Trim());
                string card = commandInfo[2].Trim();
                if (index >= 0 && index < deck.Count)
                {
                    if (deck.Contains(card))
                    {
                        Console.WriteLine("Card is already added");
                    }
                    else
                    {
                        deck.Insert(index, card);
                        Console.WriteLine("Card successfully added");
                    }
                }
                else Console.WriteLine("Index out of range");
            }
        }
        Console.WriteLine(string.Join(", ", deck));
    }
}

