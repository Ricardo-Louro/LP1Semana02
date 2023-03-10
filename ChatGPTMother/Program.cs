using System;

namespace ChatGPTMother
{
    /// <summary>
    /// Program will receive inputs from the player and reply accordingly.
    /// The program will loop this until given an instruction to EXIT.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //Initiate variables
            bool loop = true;
            string response;

            //Initiate loop
            while(loop)
            {
                //Prompt the player to provide an input
                Console.WriteLine("What is your question? ");

                //Receive the player's input and store it
                string question = Console.ReadLine();

                //Switch expression to evaluate the player's input and reply
                //accordingly or terminate the loop
                switch (question)
                {
                    //Check question
                    case "How are you?":
                        //Assign the correct reply
                        response = "I'm fine, thank you";
                        //Exit the switch expression
                        break;

                    //Check question
                    case "What's your name?":
                        //Assign the correct reply
                        response = "Mother";
                        //Exit the switch expression
                        break;
                    //Check question
                    case "What's your mission?":
                        //Assign the correct reply
                        response = "Destroy mankind!";
                        //Exit switch expression
                        break;

                    //Check question
                    case "What's your favourite food?":
                        //Assign the correct reply
                        response = "Pizza!";
                        //Exit switch expression
                        break;

                    //Check question
                    case "EXIT":
                        //Change variable so that the loop will terminate
                        loop = false;
                        //Assign the correct reply
                        response = "Understood!";
                        //Exit switch expression
                        break;

                    //If no option matched the question
                    default:
                        //Assign the correct reply
                        response = "Whoops... Can't understand that!";
                        //Exit switch expression
                        break;
                }

                //Print the reply
                Console.WriteLine(response);
                //Print empty line to prevent a block of text
                Console.WriteLine();
            }
        }
    }
}
