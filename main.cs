using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Enter your message:");
        string userMessage = Console.ReadLine();

        if (IsMessageShortEnough(userMessage))
        {
            Console.WriteLine("Posted");
        }
        else
        {
            Console.WriteLine("Rejected");
        }
    }

    static bool IsMessageShortEnough(string message)
    {
        const int maxCharacters = 140;
        return message.Length <= maxCharacters;
  }
}