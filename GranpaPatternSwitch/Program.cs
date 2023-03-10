using System;

namespace GranpaPatternSwitch
{
    /// <summary>
    /// Receive questions and reply with a response based on the question
    /// </summary>
    class Program
    {
        private static void Main(string[] args)
        {
            //Prompt the player to provide his question
            Console.WriteLine("Place your question? ");

            //Receive and store the player's input
            string question = Console.ReadLine();

            //Begin the switch instruction to receive the question
            // and output the response
            string response = question switch
            {
                "How are you?" => "I'm fine, thank you",
                "What's your name?" => "Gran'pa",
                "What's your mission?" => "Destroy mankind!",
                _ => "You got me, I'm not THAT smart!",
            };

            //Print the response
            Console.WriteLine(response);
        }
    }
}
