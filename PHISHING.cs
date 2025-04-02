using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POEP1
{
    internal class PHISHING

    {

        static void Main(string[] args)
        {
            const int maxMessages = 100
            string[] userMesages = new string[maxMessages];
            string[] botResponse = new string[maxMessages];
            int messageCount = 0;

            Console.WriteLine("MatrixAI: Hello there! I'm your chatbot. Type 'exit' to quit");

            while (true)
            {
                Console.Write("You: ");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "exit")
                {
                    Console.WriteLine("MatrixAI: Goodbye ;)");
                    break;
                }

                userMesages[messageCount] = userInput;

                string botResponses = GenerateResponse(userInput);
                botResponses[messageCount] = botResponse;
                messageCount = 0;

                Console.WriteLine("MatrixAI: " + botResponse);
                messageCount++;

                if (messageCount >= maxMessages)
                {
                    Console.WriteLine("MatrixAI: Limited memory. Clearing history.");
                    messageCount = 0;
                }
            }
        }

        static string GenerateResponse(string input)
        {
            if (input.Contains)
        }