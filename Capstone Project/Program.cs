using System;
using System.Media;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinchAPI;

namespace Capstone_Project
{
    class Program
    {

        static void Main(string[] args)
        {
            DisplayMainMenu();
        }
        //
        // Capstone Project
        //
        // Framework
        //
        // This is my interpretion of the game Who Wants to be a Millionare.
        // I went with 15 questions for my first game and had 2 lifelines 
        // available to the user. I plan on adding 2 more versions each varying in difficulty 
        // which I can use and enum for.
        //
        // Colin Campbell
        //
        // 11/28/2017
        //



        /// <summary>
        /// display menu
        /// </summary>
        static void DisplayMainMenu()
        {
            string menuChoice;
            bool exiting = false;


            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            while (!exiting)
            {
                DisplayHeader("Main Menu");

                Console.WriteLine("\tA) Description of the application");
                Console.WriteLine("\tB) Who Wants to be a Millionare - Easy");
                Console.WriteLine("\tC) Who Wants to be a Millionare - Medium" );
                Console.WriteLine("\tD) Who Wants to be a Millionare - Hard");
                Console.WriteLine("\tQ) Quit");
                Console.Write("Enter Choice:");
                menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "A":
                    case "a":
                        AppDescription();
                        break;

                    case "B":
                    case "b":
                        WhoWantsToBeAMillionareEasy();
                        break;

                    case "C":
                    case "c":
                        PlayWhoWamtsToBeAMillionareMedium();
                        break;


                    case "Q":
                    case "q":
                        exiting = true;
                        break;

                    default:

                        break;
                }
            }

        }

        static void AppDescription()
        {

            //
            // Explain the rules of the game
            //
            Console.Clear();
            Console.WriteLine("Welcome to the game of Who Wants to be a Millionare");
            Console.WriteLine();
            Console.WriteLine("This game will be a test of about your knowledge of things such as phrases, grammar, history, and everything else.");
            Console.WriteLine();
            Console.WriteLine("The rules of the game will go as followed: there will be 15 questions. Each question will be ranging in difficulty. The farther you make it, the more difficult it will get. You will be given 2 lifelines in the game. One will give you a hint where the other will eliminate two wrong answers");
            Console.WriteLine();
            Console.WriteLine("Be aware, if you answer incorrectly to any question, the game will be over and you will lose all your money.");
            DisplayContinuePrompt();


            //
            // Show rewarding system
            //

            Console.Clear();
            Console.WriteLine("The scoring will go as followed");
            Console.WriteLine();
            Console.WriteLine("Question 1: $100 dollars");

            Console.WriteLine("Question 2: $200 dollars");

            Console.WriteLine("Question 3: $300 dollars");

            Console.WriteLine("Question 4: $400 dollars");

            Console.WriteLine("Question 5: $500 dollars");

            Console.WriteLine("Question 6: $600 dollars");

            Console.WriteLine("Question 7: $700 dollars");

            Console.WriteLine("Question 8: $800 dollars");

            Console.WriteLine("Question 9: $900 dollars");

            Console.WriteLine("Question 10: $1000 dollars");

            Console.WriteLine("Question 11: $10,000 dollars");

            Console.WriteLine("Question 12: $50,000 dollars");

            Console.WriteLine("Question 13: $100,000 dollars");

            Console.WriteLine("Question 14: $500,000 dollars");

            Console.WriteLine("Question 15: $1,000,000 dollars");
            Console.WriteLine();

            Console.WriteLine("You will be need to select what difficulty you would like to play in the next screen");
            DisplayContinuePrompt();
            DisplayMainMenu();
            
           

        }





        static void PlayMusic()
        {
            SoundPlayer WhoWantsToBeAMillionareMusic = new SoundPlayer(@"Media/");
        }


        static void WhoWantsToBeAMillionareEasy()
        {
            bool hintAvailable = true;
            bool eliminateAnswersAvailable = true;



            int Question1 = 100;
            int Question2 = 200;
            int Question3 = 300;
            int Question4 = 400;
            int Question5 = 500;
            int Question6 = 600;
            int Question7 = 700;
            int Question8 = 800;
            int Question9 = 900;
            int Question10 = 1000;
            int Question11 = 10000;
            int Question12 = 50000;
            int Question13 = 100000;
            int Question14 = 500000;
            int Question15 = 1000000;

            //
            // Question 1
            //


            Console.Clear();
            Console.WriteLine("1. How do we measure temperature in the United States?");
            Console.Write("A. Celcius");
            Console.Write("\t   B. Meters");
            Console.Write("\t   C. Farenheit");
            Console.Write("\t   D. Quadrants");
            Console.WriteLine();

            if (hintAvailable && eliminateAnswersAvailable)
            {
                Console.WriteLine("Press H to use your hint or E to elimate two answers");
            }

            else
            {
                Console.WriteLine("There are no hints available");
            }


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please enter answer:");
            string userResponse = Console.ReadLine().ToUpper();

            if (userResponse == "C")
            {
                int bank = Question1;
                Console.Clear();
                Console.WriteLine($"That is correct. You have {bank} dollars in the bank.");
                Console.WriteLine();
                Console.WriteLine("Press any key to continue on to question 2");
                Console.ReadKey();
            }

            else if (userResponse == "H")
            {
                hintAvailable = false;
                Console.WriteLine("The answer has to do with things being fair");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "C")
                {
                    Console.Clear();
                    Console.WriteLine("That is correct. You have $100 dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 2");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was C, The National Hockey League.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                hintAvailable = false;

            }

            else if (userResponse == "E")
            {
                eliminateAnswersAvailable = false;
                Console.WriteLine("Answer A and D are both false.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "C")
                {
                    int bank = Question1;
                    Console.Clear();
                    Console.WriteLine($"That is correct. You have {bank} dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 2");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was C.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }


            }

            else
            {

                Console.Clear();
                Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was C, The National Hockey League.");
                Console.WriteLine();
                Console.WriteLine("Game Over!");
                DisplayContinuePrompt();
                DisplayMainMenu();


            }




            //
            // Question 2
            //

            Console.Clear();
            Console.WriteLine("2. If you have 5 cars and take away three, but then add 4, how many cars are there?");
            Console.Write("A. 3");
            Console.Write("\t   B. 2");
            Console.Write("\t   C. 5");
            Console.Write("\t   D. 6");
            Console.WriteLine();

            if (hintAvailable)
            {
                Console.WriteLine("Press H to use your hint");
            }

            if (eliminateAnswersAvailable)
            {
                Console.WriteLine("Press E to eliminate two answers!");
            }
            else
            {
                Console.WriteLine("There are no hints left");
            }

            Console.WriteLine();
            Console.WriteLine("Please enter answer:");
            userResponse = Console.ReadLine().ToUpper();


            if (userResponse == "D")
            {
                Console.Clear();
                int bank = Question1 + Question2;
                Console.WriteLine($"You are correct. Adding $200 dollars to the bank. You now have ${bank} dollars.");
                Console.WriteLine();
                Console.WriteLine("Press any key to continue on to question 3.");
                Console.ReadKey();
            }

            else if (userResponse == "H")
            {
                Console.WriteLine("The answer comes after 5 but before 7(look at all the answers that consist of this)");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "D")
                {
                    Console.Clear();
                    int bank = Question1 + Question2;
                    Console.WriteLine($"That is correct. You have ${bank} dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 3");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was D.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                hintAvailable = false;
            }

            else if (userResponse == "E")
            {
                Console.WriteLine("A and B are incorrect");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "D")
                {
                    Console.Clear();
                    Console.WriteLine("That is correct. You have $300 dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 3");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was D.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                eliminateAnswersAvailable = false;
            }


            else
            {
                Console.Clear();
                Console.WriteLine("I'm sorry, that answer was not correct. The correct answer was D.");
                Console.WriteLine();
                Console.WriteLine("Game Over");
                DisplayContinuePrompt();
                DisplayMainMenu();


            }

            //
            // Question 3
            //

            Console.Clear();
            Console.WriteLine("3. Finish this phrase: Turn that frown ________");
            Console.Write("A. all around");
            Console.Write("\t   B. upside down");
            Console.Write("\t   C. right around");
            Console.Write("\t   D. up and down");
            Console.WriteLine();
            if (hintAvailable)
            {
                Console.WriteLine("Press H to use your hint");
            }
            if (eliminateAnswersAvailable)
            {
                Console.WriteLine("Press E to eliminate two answers");
            }
            else
            {

            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please enter answer:");
            userResponse = Console.ReadLine().ToUpper();


            if (userResponse == "B")
            {
                Console.Clear();
                Console.WriteLine("Correct.");
                Console.WriteLine();
                Console.WriteLine("You now have $600 dollars in the bank! Press any key to move on to question 4");
                Console.ReadKey();

            }

            else if (userResponse == "H")
            {
                Console.WriteLine("It's the opposite up downside up.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "B")
                {
                    Console.Clear();
                    Console.WriteLine("That is correct. You have $600 dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 4");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was B.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                hintAvailable = false;
            }

            else if (userResponse == "E")
            {
                Console.WriteLine("A and D are incorrect.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "B")
                {
                    Console.Clear();
                    Console.WriteLine("That is correct. You have $300 dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 3");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was B.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                eliminateAnswersAvailable = false;
            }

            else
            {
                Console.WriteLine("Incorrect. Game Over!");
                DisplayContinuePrompt();
                DisplayMainMenu();
            }

            //
            // Question 4
            //
            Console.Clear();
            Console.WriteLine("4. What is the square root of 64?");
            Console.Write("A. 24");
            Console.Write("\t   B. 8");
            Console.Write("\t   C. 4");
            Console.Write("\t   D. 2");
            Console.WriteLine();
            if (hintAvailable)
            {
                Console.WriteLine("Press H to use your hint");
            }
            if (eliminateAnswersAvailable)
            {
                Console.WriteLine("Press E to eliminate two answers");
            }
            else
            {

            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please enter answer:");
            userResponse = Console.ReadLine().ToUpper();


            if (userResponse == "B")
            {
                int bank = Question1 + Question2 + Question3 + Question4;
                Console.WriteLine($"That is correct. You now have ${bank} dollars. Press any key to continue to question 5");
                Console.ReadKey();

            }

            else if (userResponse == "H")
            {
                Console.WriteLine("The answer looks like an 0 on top of an 0");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "B")
                {
                    Console.Clear();
                    int bank = Question1 + Question2 + Question3 + Question4;
                    Console.WriteLine($"That is correct. You have {bank} dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 5");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was B.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                hintAvailable = false;
            }

            else if (userResponse == "E")
            {
                Console.WriteLine("4 and 2 are not correct answers");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "B")
                {
                    Console.Clear();
                    int bank = Question1 + Question2 + Question3 + Question4;
                    Console.WriteLine($"That is correct. You have {bank} dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 5");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was B.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                eliminateAnswersAvailable = false;
            }

            else
            {
                Console.WriteLine("That answer was incorrect. I'm sorry, game over.");
                DisplayContinuePrompt();
                DisplayMainMenu();
            }


            //
            // Question 5
            //

            Console.Clear();
            Console.WriteLine("5. After the bombing of Pearl Harbor, the US declared war on which country");
            Console.Write("A. Russia");
            Console.Write("\t   B. Iran");
            Console.Write("\t   C. Japan");
            Console.Write("\t   D. North Korea");
            Console.WriteLine();

            if (hintAvailable)
            {
                Console.WriteLine("Press H to use your hint");
            }
            if (eliminateAnswersAvailable)
            {
                Console.WriteLine("Press E to eliminate two answers");
            }
            else
            {

            }

            Console.WriteLine();
            Console.WriteLine("Please enter answer:");
            userResponse = Console.ReadLine().ToUpper();


            if (userResponse == "C")
            {
                int bank = 100 + 200 + 300 + 400 + 500;
                Console.WriteLine($"That is correct. You now have ${bank} dollars. Press any key to continue to question 5");
                Console.ReadKey();

            }

            else if (userResponse == "H")
            {
                Console.WriteLine("The countries flag has a big red dot in the middle.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "C")
                {
                    Console.Clear();
                    int bank = Question1 + Question2 + Question3 + Question4 + Question5;
                    Console.WriteLine($"That is correct. You have ${bank} dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 6");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was C.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                hintAvailable = false;
            }

            else if (userResponse == "E")
            {
                Console.WriteLine("A and C are incorrect.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "C")
                {
                    Console.Clear();
                    int bank = Question1 + Question2 + Question3 + Question4 + Question5;
                    Console.WriteLine($"That is correct. You have ${bank} dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 6");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was C.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                eliminateAnswersAvailable = false;
            }

            else
            {
                Console.WriteLine("That answer was incorrect. I'm sorry, the game is over.");
                DisplayContinuePrompt();
                DisplayMainMenu();
            }

            //
            // Question 6
            //

            Console.Clear();
            Console.WriteLine("6. What is Michigan's capital?");
            Console.Write("A. Lansing");
            Console.Write("\t   B. Detroit");
            Console.Write("\t   C. Wyoming");
            Console.Write("\t   D. St. Paul");
            Console.WriteLine();

            if (hintAvailable)
            {
                Console.WriteLine("Press H to use your hint");
            }
            if (eliminateAnswersAvailable)
            {
                Console.WriteLine("Press E to eliminate two answers");
            }
            else
            {

            }

            Console.WriteLine();
            Console.WriteLine("Please enter answer:");
            userResponse = Console.ReadLine().ToUpper();


            if (userResponse == "A")
            {
                int bank = Question1 + Question2 + Question3 + Question4 + Question5 + Question6;
                Console.WriteLine($"That is correct. You now have ${bank} dollars. Press any key to continue to question 5");
                Console.ReadKey();

            }

            else if (userResponse == "H")
            {
                Console.WriteLine("The answer is the home of the Michigan State Spartans");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "A")
                {
                    Console.Clear();
                    int bank = Question1 + Question2 + Question3 + Question4 + Question5 + Question6;
                    Console.WriteLine($"That is correct. You have ${bank} dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 7");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was A.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                hintAvailable = false;
            }

            else if (userResponse == "E")
            {
                Console.WriteLine("C and D are incorrect.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "A")
                {
                    Console.Clear();
                    int bank = Question1 + Question2 + Question3 + Question4 + Question5 + Question6;
                    Console.WriteLine($"That is correct. You have ${bank} dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 6");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was A.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                eliminateAnswersAvailable = false;
            }

            else
            {
                Console.WriteLine("That answer was incorrect. I'm sorry, the game is over.");
                DisplayContinuePrompt();
                DisplayMainMenu();
            }


            //
            // Question 7
            //

            Console.Clear();
            Console.WriteLine("7. How many stripes are there on the American flag?");
            Console.Write("A. 50");
            Console.Write("\t   B. 13");
            Console.Write("\t   C. 14");
            Console.Write("\t   D. 15");
            Console.WriteLine();

            if (hintAvailable)
            {
                Console.WriteLine("Press H to use your hint");
            }
            if (eliminateAnswersAvailable)
            {
                Console.WriteLine("Press E to eliminate two answers");
            }
            else
            {

            }

            Console.WriteLine();
            Console.WriteLine("Please enter answer:");
            userResponse = Console.ReadLine().ToUpper();


            if (userResponse == "B")
            {
                int bank = 100 + 200 + 300 + 400 + 500 + Question6 + Question7;
                Console.WriteLine($"That is correct. You now have ${bank} dollars. Press any key to continue to question 5");
                Console.ReadKey();

            }

            else if (userResponse == "H")
            {
                Console.WriteLine("This is the number of colonies America had when first lived in.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "B")
                {
                    Console.Clear();
                    int bank = Question1 + Question2 + Question3 + Question4 + Question5 + Question6 + Question7;
                    Console.WriteLine("That is correct. You have $700 dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 8");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was B.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                hintAvailable = false;
            }

            else if (userResponse == "E")
            {
                Console.WriteLine("A and C are incorrect.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "B")
                {
                    Console.Clear();
                    int bank = Question1 + Question2 + Question3 + Question4 + Question5 + Question6 + Question7;
                    Console.WriteLine($"That is correct. You have ${bank} dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 7");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was B.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                eliminateAnswersAvailable = false;
            }

            else
            {
                Console.WriteLine("That answer was incorrect. I'm sorry, the game is over.");
                DisplayContinuePrompt();
                DisplayMainMenu();
            }


            //
            // Question 8
            //

            Console.Clear();
            Console.WriteLine("8. What is the longest river in America?");
            Console.Write("A. Mississippi");
            Console.Write("\t   B. Louisiana");
            Console.Write("\t   C. Flushing");
            Console.Write("\t   D. Colorado");
            Console.WriteLine();

            if (hintAvailable)
            {
                Console.WriteLine("Press H to use your hint");
            }
            if (eliminateAnswersAvailable)
            {
                Console.WriteLine("Press E to eliminate two answers");
            }
            else
            {

            }

            Console.WriteLine();
            Console.WriteLine("Please enter answer:");
            userResponse = Console.ReadLine().ToUpper();


            if (userResponse == "A")
            {
                int bank = 100 + 200 + 300 + 400 + 500 + 700 + 800;
                Console.WriteLine($"That is correct. You now have ${bank} dollars. Press any key to continue to question 5");
                Console.ReadKey();

            }

            else if (userResponse == "H")
            {
                Console.WriteLine("This may be the hardest to spell out of your choices");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "A")
                {
                    Console.Clear();
                    Console.WriteLine("That is correct. You have $800 dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 9");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was A.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                hintAvailable = false;
            }

            else if (userResponse == "E")
            {
                Console.WriteLine("B and C are incorrect.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "A")
                {
                    Console.Clear();
                    Console.WriteLine("That is correct. You have $800 dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 8");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was A.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                eliminateAnswersAvailable = false;
            }

            else
            {
                Console.WriteLine("That answer was incorrect. I'm sorry, the game is over.");
                DisplayContinuePrompt();
                DisplayMainMenu();
            }
            //
            // Question 9
            //

            Console.Clear();
            Console.WriteLine("9. This war was not known for a single shot being fired?");
            Console.Write("A. Korean war");
            Console.Write("\t   B. Civil war");
            Console.Write("\t   C. Cold war");
            Console.Write("\t   D. Afghanistan war");
            Console.WriteLine();

            if (hintAvailable)
            {
                Console.WriteLine("Press H to use your hint");
            }
            if (eliminateAnswersAvailable)
            {
                Console.WriteLine("Press E to eliminate two answers");
            }
            else
            {

            }

            Console.WriteLine();
            Console.WriteLine("Please enter answer:");
            userResponse = Console.ReadLine().ToUpper();


            if (userResponse == "C")
            {
                int bank = 100 + 200 + 300 + 400 + 500;
                Console.WriteLine($"That is correct. You now have $900 dollars. Press any key to continue to question 5");
                Console.ReadKey();

            }

            else if (userResponse == "H")
            {
                Console.WriteLine("We were rivals with the Soviets in this instance.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "C")
                {
                    Console.Clear();
                    Console.WriteLine("That is correct. You have $900 dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 10");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was C.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                hintAvailable = false;
            }

            else if (userResponse == "E")
            {
                Console.WriteLine("A and D are incorrect.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "C")
                {
                    Console.Clear();
                    Console.WriteLine("That is correct. You have $900 dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 10");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was C.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                eliminateAnswersAvailable = false;
            }

            else
            {
                Console.WriteLine("That answer was incorrect. I'm sorry, the game is over.");
                DisplayContinuePrompt();
                DisplayMainMenu();
            }

            //
            // Question 10
            //

            Console.Clear();
            Console.WriteLine("10. Who was the last president to be assasinated?");
            Console.Write("A. Abrahman Lincoln");
            Console.Write("\t   B. John F. Kennedy");
            Console.Write("\t   C. William Taft");
            Console.Write("\t   D. Richard Nixon");
            Console.WriteLine();

            if (hintAvailable)
            {
                Console.WriteLine("Press H to use your hint");
            }
            if (eliminateAnswersAvailable)
            {
                Console.WriteLine("Press E to eliminate two answers");
            }
            else
            {

            }

            Console.WriteLine();
            Console.WriteLine("Please enter answer:");
            userResponse = Console.ReadLine().ToUpper();


            if (userResponse == "B")
            {
                int bank = 100 + 200 + 300 + 400 + 500;
                Console.WriteLine($"That is correct. You now have $1,000 dollars. Press any key to continue to question 11");
                Console.ReadKey();

            }

            else if (userResponse == "H")
            {
                Console.WriteLine("A man named Lee Harvey Oswald had links to this.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "B")
                {
                    Console.Clear();
                    Console.WriteLine("That is correct. You have $1,000 dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 11");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was B.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                hintAvailable = false;
            }

            else if (userResponse == "E")
            {
                Console.WriteLine("A and C are incorrect.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "B")
                {
                    Console.Clear();
                    Console.WriteLine("That is correct. You have $1,000 dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 11");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was B.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                eliminateAnswersAvailable = false;
            }

            else
            {
                Console.WriteLine("That answer was incorrect. I'm sorry, the game is over.");
                DisplayContinuePrompt();
                DisplayMainMenu();
            }
            //
            // Question 11
            //

            Console.Clear();
            Console.WriteLine("11. What were the names of the two cities which the US dropped an atomic bomb on during WW2?");
            Console.Write("A. Hiroshima and Mashuyama");
            Console.Write("\t   B. Tokyo and Chailay");
            Console.Write("\t   C. Nagasaki and Tokyo");
            Console.Write("\t   D. Hiroshima and Nagasaki");
            Console.WriteLine();

            if (hintAvailable)
            {
                Console.WriteLine("Press H to use your hint");
            }
            if (eliminateAnswersAvailable)
            {
                Console.WriteLine("Press E to eliminate two answers");
            }
            else
            {

            }

            Console.WriteLine();
            Console.WriteLine("Please enter answer:");
            userResponse = Console.ReadLine().ToUpper();


            if (userResponse == "D")
            {

                Console.WriteLine($"That is correct. You now have $11,000 dollars. Press any key to continue to question 12");
                Console.ReadKey();

            }

            else if (userResponse == "H")
            {
                Console.WriteLine("A correct city is Nagasaki");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "D")
                {
                    Console.Clear();
                    Console.WriteLine("That is correct. You have $11,000 dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 12");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was D.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                hintAvailable = false;
            }

            else if (userResponse == "E")
            {
                Console.WriteLine("A and C are incorrect.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "D")
                {
                    Console.Clear();
                    Console.WriteLine("That is correct. You have $11,000 dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 12");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was D.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                eliminateAnswersAvailable = false;
            }

            else
            {
                Console.WriteLine("That answer was incorrect. I'm sorry, the game is over.");
                DisplayContinuePrompt();
                DisplayMainMenu();
            }

            //
            // Question 12
            //

            Console.Clear();
            Console.WriteLine("12. This European recovery plan placed in 1940 was known as the");
            Console.Write("A. Taft plan");
            Console.Write("\t   B. Wilson plan");
            Console.Write("\t   C. Marshall plan");
            Console.Write("\t   D. Roosevelt plan");
            Console.WriteLine();

            if (hintAvailable)
            {
                Console.WriteLine("Press H to use your hint");
            }
            if (eliminateAnswersAvailable)
            {
                Console.WriteLine("Press E to eliminate two answers");
            }
            else
            {

            }

            Console.WriteLine();
            Console.WriteLine("Please enter answer:");
            userResponse = Console.ReadLine().ToUpper();


            if (userResponse == "C")
            {
                int bank = 1000 + 10000 + 20000 + 50000;
                Console.WriteLine($"That is correct. You now have ${bank} dollars. Press any key to continue to question 5");
                Console.ReadKey();

            }

            else if (userResponse == "H")
            {
                Console.WriteLine("His first name is George");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "C")
                {
                    Console.Clear();
                    Console.WriteLine("That is correct. You have $80,100 dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 13");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was C.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                hintAvailable = false;
            }

            else if (userResponse == "E")
            {
                Console.WriteLine("A and B are incorrect.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "C")
                {
                    Console.Clear();
                    Console.WriteLine("That is correct. You have $80,100 dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 13");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was C.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                eliminateAnswersAvailable = false;
            }

            else
            {
                Console.WriteLine("That answer was incorrect. I'm sorry, the game is over.");
                DisplayContinuePrompt();
                DisplayMainMenu();
            }

            //
            // Question 13
            //

            Console.Clear();
            Console.WriteLine("13. On the periodic table, Na stands for what?");
            Console.Write("A. Not available");
            Console.Write("\t   B. Narcine");
            Console.Write("\t   C. Natride");
            Console.Write("\t   D. Sodium");
            Console.WriteLine();

            if (hintAvailable)
            {
                Console.WriteLine("Press H to use your hint");
            }
            if (eliminateAnswersAvailable)
            {
                Console.WriteLine("Press E to eliminate two answers");
            }
            else
            {

            }

            Console.WriteLine();
            Console.WriteLine("Please enter answer:");
            userResponse = Console.ReadLine().ToUpper();


            if (userResponse == "D")
            {
                int bank = 1000 + 10000 + 20000 + 50000 + 100000;
                Console.WriteLine($"That is correct. You now have ${bank} dollars. Press any key to continue to question 5");
                Console.ReadKey();

            }

            else if (userResponse == "H")
            {
                Console.WriteLine("This is a soft silver metal from the alkaline family");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "D")
                {
                    Console.Clear();
                    Console.WriteLine("That is correct. You have 180,100 dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 14");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was D.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                hintAvailable = false;
            }

            else if (userResponse == "E")
            {
                Console.WriteLine("A and C are incorrect.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "D")
                {
                    Console.Clear();
                    Console.WriteLine("That is correct. You have $180,100 dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 14");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was D.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                eliminateAnswersAvailable = false;
            }

            else
            {
                Console.WriteLine("That answer was incorrect. I'm sorry, the game is over.");
                DisplayContinuePrompt();
                DisplayMainMenu();
            }

            //
            // Question 14
            //

            Console.Clear();
            Console.WriteLine("14. Who found Death Row label with Marion Knight?");
            Console.Write("A. Billy Idol");
            Console.Write("\t   B. Eminem");
            Console.Write("\t   C. Tupac");
            Console.Write("\t   D. Dr.Dre");
            Console.WriteLine();

            if (hintAvailable)
            {
                Console.WriteLine("Press E to use your hint");
            }
            if (eliminateAnswersAvailable)
            {
                Console.WriteLine("Press E to eliminate two answers");
            }
            else
            {

            }

            Console.WriteLine();
            Console.WriteLine("Please enter answer:");
            userResponse = Console.ReadLine().ToUpper();


            if (userResponse == "D")
            {
                int bank = 1000 + 10000 + 20000 + 50000 + 100000 + 500000;
                Console.WriteLine($"That is correct. You now have ${bank} dollars. Press any key to continue to question 5");
                Console.ReadKey();

            }

            else if (userResponse == "H")
            {
                Console.WriteLine("He is known for him famous headphones");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "D")
                {
                    Console.Clear();
                    Console.WriteLine("That is correct. You have $500 dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 15");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was D.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                hintAvailable = false;
            }

            else if (userResponse == "E")
            {
                Console.WriteLine("B and C are incorrect.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "D")
                {
                    Console.Clear();
                    Console.WriteLine("That is correct. You have $500 dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 15");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was D.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                eliminateAnswersAvailable = false;
            }

            else
            {
                Console.WriteLine("That answer was incorrect. I'm sorry, the game is over.");
                DisplayContinuePrompt();
                DisplayMainMenu();
            }


            //
            // Question 15
            //

            Console.Clear();
            Console.WriteLine("15. After the bombing of Pearl Harbor, the US declared war on which country");
            Console.Write("A. Russia");
            Console.Write("\t   B. Iran");
            Console.Write("\t   C. Japan");
            Console.Write("\t   D. North Korea");
            Console.WriteLine();

            if (hintAvailable)
            {
                Console.WriteLine("Press E to use your hint");
            }
            if (eliminateAnswersAvailable)
            {
                Console.WriteLine("Press E to eliminate two answers");
            }
            else
            {

            }

            Console.WriteLine();
            Console.WriteLine("Please enter answer:");
            userResponse = Console.ReadLine().ToUpper();


            if (userResponse == "C")
            {

                int bank = Question1 + Question2 + Question3 + Question4 + Question5 + Question6 + Question7 + Question8 + Question9 + Question10 + Question11 + Question12 + Question13 + Question14 + Question15;
                Console.WriteLine($"That is correct. You now have ${bank} dollars. YOU HAVE WON THE GAME");
                Console.ReadKey();


            }

            else if (userResponse == "H")
            {
                Console.WriteLine("The countries flag has a big red dot in the middle.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "C")
                {
                    Console.Clear();
                    Console.WriteLine("That is correct. You have $500 dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 6");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was C.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                hintAvailable = false;
            }

            else if (userResponse == "E")
            {
                Console.WriteLine("A and C are incorrect.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "C")
                {
                    Console.Clear();
                    Console.WriteLine("That is correct. You have $500 dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 6");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was C.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                eliminateAnswersAvailable = false;
            }

            else
            {
                Console.WriteLine("That answer was incorrect. I'm sorry, the game is over.");
                DisplayContinuePrompt();
                DisplayMainMenu();
            }



        }








        static void PlayWhoWamtsToBeAMillionareMedium()
        {
            bool hintAvailable = true;
            bool eliminateAnswersAvailable = true;


          

            int Question1 = 100;
            int Question2 = 200;
            int Question3 = 300;
            int Question4 = 400;
            int Question5 = 500;
            int Question6 = 600;
            int Question7 = 700;
            int Question8 = 800;
            int Question9 = 900;
            int Question10 = 1000;
            int Question11 = 10000;
            int Question12 = 50000;
            int Question13 = 100000;
            int Question14 = 500000;
            int Question15 = 1000000;

            //
            // Question 1
            //

            Console.Clear();
            Console.WriteLine("1. What does the NHL stand for in the United States?");
            Console.Write("A. National Hair League");
            Console.Write("\t   B. Natural Hemisphere Logics");
            Console.Write("\t   C. National Hockey League");
            Console.Write("\t   D. Natural Hurricane Location");
            Console.WriteLine();

            if (hintAvailable && eliminateAnswersAvailable)
            {
                Console.WriteLine("Press H to use your hint or E to elimate two answers");
            }

            else
            {
                Console.WriteLine("There are no hints available");
            }


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please enter answer:");
            string userResponse = Console.ReadLine().ToUpper();

            if (userResponse == "C")
            {
                int bank = Question1;
                Console.Clear();
                Console.WriteLine($"That is correct. You have {bank} dollars in the bank.");
                Console.WriteLine();
                Console.WriteLine("Press any key to continue on to question 2");
                Console.ReadKey();
            }

            else if (userResponse == "H")
            {
                hintAvailable = false;
                Console.WriteLine("The answer relates to sports");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "C")
                {
                    Console.Clear();
                    Console.WriteLine("That is correct. You have $100 dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 2");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was C, The National Hockey League.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                hintAvailable = false;

            }

            else if (userResponse == "E")
            {
                eliminateAnswersAvailable = false;
                Console.WriteLine("Answer A and D are both false.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "C")
                {
                    int bank = Question1;
                    Console.Clear();
                    Console.WriteLine($"That is correct. You have {bank} dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 2");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was C.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }


            }

            else
            {

                Console.Clear();
                Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was C, The National Hockey League.");
                Console.WriteLine();
                Console.WriteLine("Game Over!");
                DisplayContinuePrompt();
                DisplayMainMenu();


            }




            //
            // Question 2
            //

            Console.Clear();
            Console.WriteLine("2. Which state is known as the volunteer state?");
            Console.Write("A. Kentucky");
            Console.Write("\t   B. Wisconsin");
            Console.Write("\t   C. South Carolina");
            Console.Write("\t   D. Tennessee");
            Console.WriteLine();

            if (hintAvailable)
            {
                Console.WriteLine("Press H to use your hint");
            }

            if (eliminateAnswersAvailable)
            {
                Console.WriteLine("Press E to eliminate two answers!");
            }
            else
            {
                Console.WriteLine("There are no hints left");
            }

            Console.WriteLine();
            Console.WriteLine("Please enter answer:");
            userResponse = Console.ReadLine().ToUpper();


            if (userResponse == "D")
            {
                Console.Clear();
                Console.WriteLine("You are correct. Adding $200 dollars to the bank. You now have $300 dollars.");
                Console.WriteLine();
                Console.WriteLine("Press any key to continue on to question 3.");
                Console.ReadKey();
            }

            else if (userResponse == "H")
            {
                Console.WriteLine("The correct answer is the only Ten I see");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "D")
                {
                    Console.Clear();
                    Console.WriteLine("That is correct. You have $200 dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 3");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was D.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                hintAvailable = false;
            }

            else if (userResponse == "E")
            {
                Console.WriteLine("Wisconin and Kentucky are both incorrect");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "D")
                {
                    Console.Clear();
                    Console.WriteLine("That is correct. You have $200 dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 3");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was D.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                eliminateAnswersAvailable = false;
            }


            else
            {
                Console.Clear();
                Console.WriteLine("I'm sorry, that answer was not correct. The correct answer was D, Tennessee");
                Console.WriteLine();
                Console.WriteLine("Game Over");
                DisplayContinuePrompt();
                DisplayMainMenu();


            }

            //
            // Question 3
            //

            Console.Clear();
            Console.WriteLine("3. Which shoe company did Michael Jordan famously promote?");
            Console.Write("A. Reebok");
            Console.Write("\t   B. Nike");
            Console.Write("\t   C. Adidas");
            Console.Write("\t   D. Under Armour");
            Console.WriteLine();
            if (hintAvailable)
            {
                Console.WriteLine("Press H to use your hint");
            }
            if (eliminateAnswersAvailable)
            {
                Console.WriteLine("Press E to eliminate two answers");
            }
            else
            {

            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please enter answer:");
            userResponse = Console.ReadLine().ToUpper();


            if (userResponse == "B")
            {
                Console.Clear();
                Console.WriteLine("Correct. Jordan endorsed nike in 1984");
                Console.WriteLine();
                Console.WriteLine("You now have $600 dollars in the bank! Press any key to move on to question 4");
                Console.ReadKey();

            }

            else if (userResponse == "H")
            {
                Console.WriteLine("This shoe brand has swoosh as its icon");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "B")
                {
                    Console.Clear();
                    Console.WriteLine("That is correct. You have $300 dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 4");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was B.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                hintAvailable = false;
            }

            else if (userResponse == "E")
            {
                Console.WriteLine("Under Armor and Reebok are not correct answers.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "B")
                {
                    Console.Clear();
                    Console.WriteLine("That is correct. You have $300 dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 3");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was B.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                eliminateAnswersAvailable = false;
            }

            else
            {
                Console.WriteLine("Incorrect. Game Over!");
                DisplayContinuePrompt();
                DisplayMainMenu();
            }

            //
            // Question 4
            //
            Console.Clear();
            Console.WriteLine("4. What is the square root of 64?");
            Console.Write("A. 24");
            Console.Write("\t   B. 8");
            Console.Write("\t   C. 4");
            Console.Write("\t   D. 2");
            Console.WriteLine();
            if (hintAvailable)
            {
                Console.WriteLine("Press H to use your hint");
            }
            if (eliminateAnswersAvailable)
            {
                Console.WriteLine("Press E to eliminate two answers");
            }
            else
            {

            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please enter answer:");
            userResponse = Console.ReadLine().ToUpper();


            if (userResponse == "B")
            {
                int bank = Question1 + Question2 + Question3 + Question4;
                Console.WriteLine($"That is correct. You now have ${bank} dollars. Press any key to continue to question 5");
                Console.ReadKey();

            }

            else if (userResponse == "H")
            {
                Console.WriteLine("The answer looks like an 0 on top of an 0");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "B")
                {
                    Console.Clear();
                    int bank = Question1 + Question2 + Question3 + Question4;
                    Console.WriteLine($"That is correct. You have {bank} dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 5");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was B.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                hintAvailable = false;
            }

            else if (userResponse == "E")
            {
                Console.WriteLine("4 and 2 are not correct answers");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "B")
                {
                    Console.Clear();
                    int bank = Question1 + Question2 + Question3 + Question4;
                    Console.WriteLine($"That is correct. You have {bank} dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 5");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was B.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                eliminateAnswersAvailable = false;
            }

            else
            {
                Console.WriteLine("That answer was incorrect. I'm sorry, game over.");
                DisplayContinuePrompt();
                DisplayMainMenu();
            }


            //
            // Question 5
            //

            Console.Clear();
            Console.WriteLine("5. After the bombing of Pearl Harbor, the US declared war on which country");
            Console.Write("A. Russia");
            Console.Write("\t   B. Iran");
            Console.Write("\t   C. Japan");
            Console.Write("\t   D. North Korea");
            Console.WriteLine();

            if (hintAvailable)
            {
                Console.WriteLine("Press H to use your hint");
            }
            if (eliminateAnswersAvailable)
            {
                Console.WriteLine("Press E to eliminate two answers");
            }
            else
            {

            }

            Console.WriteLine();
            Console.WriteLine("Please enter answer:");
            userResponse = Console.ReadLine().ToUpper();


            if (userResponse == "C")
            {
                int bank = 100 + 200 + 300 + 400 + 500;
                Console.WriteLine($"That is correct. You now have ${bank} dollars. Press any key to continue to question 5");
                Console.ReadKey();

            }

            else if (userResponse == "H")
            {
                Console.WriteLine("The countries flag has a big red dot in the middle.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "C")
                {
                    Console.Clear();
                    int bank = Question1 + Question2 + Question3 + Question4 + Question5;
                    Console.WriteLine($"That is correct. You have ${bank} dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 6");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was C.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                hintAvailable = false;
            }

            else if (userResponse == "E")
            {
                Console.WriteLine("A and C are incorrect.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "C")
                {
                    Console.Clear();
                    int bank = Question1 + Question2 + Question3 + Question4 + Question5;
                    Console.WriteLine($"That is correct. You have ${bank} dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 6");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was C.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                eliminateAnswersAvailable = false;
            }

            else
            {
                Console.WriteLine("That answer was incorrect. I'm sorry, the game is over.");
                DisplayContinuePrompt();
                DisplayMainMenu();
            }

            //
            // Question 6
            //

            Console.Clear();
            Console.WriteLine("6. What is Michigan's capital?");
            Console.Write("A. Lansing");
            Console.Write("\t   B. Detroit");
            Console.Write("\t   C. Wyoming");
            Console.Write("\t   D. St. Paul");
            Console.WriteLine();

            if (hintAvailable)
            {
                Console.WriteLine("Press H to use your hint");
            }
            if (eliminateAnswersAvailable)
            {
                Console.WriteLine("Press E to eliminate two answers");
            }
            else
            {

            }

            Console.WriteLine();
            Console.WriteLine("Please enter answer:");
            userResponse = Console.ReadLine().ToUpper();


            if (userResponse == "A")
            {
                int bank = Question1 + Question2 + Question3 + Question4 + Question5 + Question6;
                Console.WriteLine($"That is correct. You now have ${bank} dollars. Press any key to continue to question 5");
                Console.ReadKey();

            }

            else if (userResponse == "H")
            {
                Console.WriteLine("The answer is the home of the Michigan State Spartans");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "A")
                {
                    Console.Clear();
                    int bank = Question1 + Question2 + Question3 + Question4 + Question5 + Question6;
                    Console.WriteLine($"That is correct. You have ${bank} dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 7");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was A.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                hintAvailable = false;
            }

            else if (userResponse == "E")
            {
                Console.WriteLine("C and D are incorrect.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "A")
                {
                    Console.Clear();
                    int bank = Question1 + Question2 + Question3 + Question4 + Question5 + Question6;
                    Console.WriteLine($"That is correct. You have ${bank} dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 6");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was A.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                eliminateAnswersAvailable = false;
            }

            else
            {
                Console.WriteLine("That answer was incorrect. I'm sorry, the game is over.");
                DisplayContinuePrompt();
                DisplayMainMenu();
            }


            //
            // Question 7
            //

            Console.Clear();
            Console.WriteLine("7. How many stripes are there on the American flag?");
            Console.Write("A. 50");
            Console.Write("\t   B. 13");
            Console.Write("\t   C. 14");
            Console.Write("\t   D. 15");
            Console.WriteLine();

            if (hintAvailable)
            {
                Console.WriteLine("Press H to use your hint");
            }
            if (eliminateAnswersAvailable)
            {
                Console.WriteLine("Press E to eliminate two answers");
            }
            else
            {

            }

            Console.WriteLine();
            Console.WriteLine("Please enter answer:");
            userResponse = Console.ReadLine().ToUpper();


            if (userResponse == "B")
            {
                int bank = 100 + 200 + 300 + 400 + 500 + Question6 + Question7;
                Console.WriteLine($"That is correct. You now have ${bank} dollars. Press any key to continue to question 5");
                Console.ReadKey();

            }

            else if (userResponse == "H")
            {
                Console.WriteLine("This is the number of colonies America had when first lived in.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "B")
                {
                    Console.Clear();
                    int bank = Question1 + Question2 + Question3 + Question4 + Question5 + Question6 + Question7;
                    Console.WriteLine("That is correct. You have $700 dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 8");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was B.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                hintAvailable = false;
            }

            else if (userResponse == "E")
            {
                Console.WriteLine("A and C are incorrect.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "B")
                {
                    Console.Clear();
                    int bank = Question1 + Question2 + Question3 + Question4 + Question5 + Question6 + Question7;
                    Console.WriteLine($"That is correct. You have ${bank} dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 7");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was B.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                eliminateAnswersAvailable = false;
            }

            else
            {
                Console.WriteLine("That answer was incorrect. I'm sorry, the game is over.");
                DisplayContinuePrompt();
                DisplayMainMenu();
            }


            //
            // Question 8
            //

            Console.Clear();
            Console.WriteLine("8. What is the longest river in America?");
            Console.Write("A. Mississippi");
            Console.Write("\t   B. Louisiana");
            Console.Write("\t   C. Flushing");
            Console.Write("\t   D. Colorado");
            Console.WriteLine();

            if (hintAvailable)
            {
                Console.WriteLine("Press H to use your hint");
            }
            if (eliminateAnswersAvailable)
            {
                Console.WriteLine("Press E to eliminate two answers");
            }
            else
            {

            }

            Console.WriteLine();
            Console.WriteLine("Please enter answer:");
            userResponse = Console.ReadLine().ToUpper();


            if (userResponse == "A")
            {
                int bank = 100 + 200 + 300 + 400 + 500 + 700 + 800;
                Console.WriteLine($"That is correct. You now have ${bank} dollars. Press any key to continue to question 5");
                Console.ReadKey();

            }

            else if (userResponse == "H")
            {
                Console.WriteLine("This may be the hardest to spell out of your choices");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "A")
                {
                    Console.Clear();
                    Console.WriteLine("That is correct. You have $800 dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 9");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was A.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                hintAvailable = false;
            }

            else if (userResponse == "E")
            {
                Console.WriteLine("B and C are incorrect.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "A")
                {
                    Console.Clear();
                    Console.WriteLine("That is correct. You have $800 dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 8");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was A.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                eliminateAnswersAvailable = false;
            }

            else
            {
                Console.WriteLine("That answer was incorrect. I'm sorry, the game is over.");
                DisplayContinuePrompt();
                DisplayMainMenu();
            }
            //
            // Question 9
            //

            Console.Clear();
            Console.WriteLine("9. This war was not known for a single shot being fired?");
            Console.Write("A. Korean war");
            Console.Write("\t   B. Civil war");
            Console.Write("\t   C. Cold war");
            Console.Write("\t   D. Afghanistan war");
            Console.WriteLine();

            if (hintAvailable)
            {
                Console.WriteLine("Press H to use your hint");
            }
            if (eliminateAnswersAvailable)
            {
                Console.WriteLine("Press E to eliminate two answers");
            }
            else
            {

            }

            Console.WriteLine();
            Console.WriteLine("Please enter answer:");
            userResponse = Console.ReadLine().ToUpper();


            if (userResponse == "C")
            {
                int bank = 100 + 200 + 300 + 400 + 500;
                Console.WriteLine($"That is correct. You now have $900 dollars. Press any key to continue to question 5");
                Console.ReadKey();

            }

            else if (userResponse == "H")
            {
                Console.WriteLine("We were rivals with the Soviets in this instance.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "C")
                {
                    Console.Clear();
                    Console.WriteLine("That is correct. You have $900 dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 10");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was C.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                hintAvailable = false;
            }

            else if (userResponse == "E")
            {
                Console.WriteLine("A and D are incorrect.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "C")
                {
                    Console.Clear();
                    Console.WriteLine("That is correct. You have $900 dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 10");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was C.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                eliminateAnswersAvailable = false;
            }

            else
            {
                Console.WriteLine("That answer was incorrect. I'm sorry, the game is over.");
                DisplayContinuePrompt();
                DisplayMainMenu();
            }

            //
            // Question 10
            //

            Console.Clear();
            Console.WriteLine("10. Who was the last president to be assasinated?");
            Console.Write("A. Abrahman Lincoln");
            Console.Write("\t   B. John F. Kennedy");
            Console.Write("\t   C. William Taft");
            Console.Write("\t   D. Richard Nixon");
            Console.WriteLine();

            if (hintAvailable)
            {
                Console.WriteLine("Press H to use your hint");
            }
            if (eliminateAnswersAvailable)
            {
                Console.WriteLine("Press E to eliminate two answers");
            }
            else
            {

            }

            Console.WriteLine();
            Console.WriteLine("Please enter answer:");
            userResponse = Console.ReadLine().ToUpper();


            if (userResponse == "B")
            {
                int bank = 100 + 200 + 300 + 400 + 500;
                Console.WriteLine($"That is correct. You now have $1,000 dollars. Press any key to continue to question 11");
                Console.ReadKey();

            }

            else if (userResponse == "H")
            {
                Console.WriteLine("A man named Lee Harvey Oswald had links to this.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "B")
                {
                    Console.Clear();
                    Console.WriteLine("That is correct. You have $1,000 dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 11");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was B.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                hintAvailable = false;
            }

            else if (userResponse == "E")
            {
                Console.WriteLine("A and C are incorrect.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "B")
                {
                    Console.Clear();
                    Console.WriteLine("That is correct. You have $1,000 dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 11");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was B.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                eliminateAnswersAvailable = false;
            }

            else
            {
                Console.WriteLine("That answer was incorrect. I'm sorry, the game is over.");
                DisplayContinuePrompt();
                DisplayMainMenu();
            }
            //
            // Question 11
            //

            Console.Clear();
            Console.WriteLine("11. What were the names of the two cities which the US dropped an atomic bomb on during WW2?");
            Console.Write("A. Hiroshima and Mashuyama");
            Console.Write("\t   B. Tokyo and Chailay");
            Console.Write("\t   C. Nagasaki and Tokyo");
            Console.Write("\t   D. Hiroshima and Nagasaki");
            Console.WriteLine();

            if (hintAvailable)
            {
                Console.WriteLine("Press H to use your hint");
            }
            if (eliminateAnswersAvailable)
            {
                Console.WriteLine("Press E to eliminate two answers");
            }
            else
            {

            }

            Console.WriteLine();
            Console.WriteLine("Please enter answer:");
            userResponse = Console.ReadLine().ToUpper();


            if (userResponse == "D")
            {

                Console.WriteLine($"That is correct. You now have $11,000 dollars. Press any key to continue to question 12");
                Console.ReadKey();

            }

            else if (userResponse == "H")
            {
                Console.WriteLine("A correct city is Nagasaki");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "D")
                {
                    Console.Clear();
                    Console.WriteLine("That is correct. You have $11,000 dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 12");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was D.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                hintAvailable = false;
            }

            else if (userResponse == "E")
            {
                Console.WriteLine("A and C are incorrect.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "D")
                {
                    Console.Clear();
                    Console.WriteLine("That is correct. You have $11,000 dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 12");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was D.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                eliminateAnswersAvailable = false;
            }

            else
            {
                Console.WriteLine("That answer was incorrect. I'm sorry, the game is over.");
                DisplayContinuePrompt();
                DisplayMainMenu();
            }

            //
            // Question 12
            //

            Console.Clear();
            Console.WriteLine("12. This European recovery plan placed in 1940 was known as the");
            Console.Write("A. Taft plan");
            Console.Write("\t   B. Wilson plan");
            Console.Write("\t   C. Marshall plan");
            Console.Write("\t   D. Roosevelt plan");
            Console.WriteLine();

            if (hintAvailable)
            {
                Console.WriteLine("Press H to use your hint");
            }
            if (eliminateAnswersAvailable)
            {
                Console.WriteLine("Press E to eliminate two answers");
            }
            else
            {

            }

            Console.WriteLine();
            Console.WriteLine("Please enter answer:");
            userResponse = Console.ReadLine().ToUpper();


            if (userResponse == "C")
            {
                int bank = 1000 + 10000 + 20000 + 50000;
                Console.WriteLine($"That is correct. You now have ${bank} dollars. Press any key to continue to question 5");
                Console.ReadKey();

            }

            else if (userResponse == "H")
            {
                Console.WriteLine("His first name is George");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "C")
                {
                    Console.Clear();
                    Console.WriteLine("That is correct. You have $80,100 dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 13");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was C.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                hintAvailable = false;
            }

            else if (userResponse == "E")
            {
                Console.WriteLine("A and B are incorrect.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "C")
                {
                    Console.Clear();
                    Console.WriteLine("That is correct. You have $80,100 dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 13");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was C.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                eliminateAnswersAvailable = false;
            }

            else
            {
                Console.WriteLine("That answer was incorrect. I'm sorry, the game is over.");
                DisplayContinuePrompt();
                DisplayMainMenu();
            }

            //
            // Question 13
            //

            Console.Clear();
            Console.WriteLine("13. On the periodic table, Na stands for what?");
            Console.Write("A. Not available");
            Console.Write("\t   B. Narcine");
            Console.Write("\t   C. Natride");
            Console.Write("\t   D. Sodium");
            Console.WriteLine();

            if (hintAvailable)
            {
                Console.WriteLine("Press H to use your hint");
            }
            if (eliminateAnswersAvailable)
            {
                Console.WriteLine("Press E to eliminate two answers");
            }
            else
            {

            }

            Console.WriteLine();
            Console.WriteLine("Please enter answer:");
            userResponse = Console.ReadLine().ToUpper();


            if (userResponse == "D")
            {
                int bank = 1000 + 10000 + 20000 + 50000 + 100000;
                Console.WriteLine($"That is correct. You now have ${bank} dollars. Press any key to continue to question 5");
                Console.ReadKey();

            }

            else if (userResponse == "H")
            {
                Console.WriteLine("This is a soft silver metal from the alkaline family");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "D")
                {
                    Console.Clear();
                    Console.WriteLine("That is correct. You have 180,100 dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 14");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was D.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                hintAvailable = false;
            }

            else if (userResponse == "E")
            {
                Console.WriteLine("A and C are incorrect.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "D")
                {
                    Console.Clear();
                    Console.WriteLine("That is correct. You have $180,100 dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 14");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was D.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                eliminateAnswersAvailable = false;
            }

            else
            {
                Console.WriteLine("That answer was incorrect. I'm sorry, the game is over.");
                DisplayContinuePrompt();
                DisplayMainMenu();
            }

            //
            // Question 14
            //

            Console.Clear();
            Console.WriteLine("14. Who found Death Row label with Marion Knight?");
            Console.Write("A. Billy Idol");
            Console.Write("\t   B. Eminem");
            Console.Write("\t   C. Tupac");
            Console.Write("\t   D. Dr.Dre");
            Console.WriteLine();

            if (hintAvailable)
            {
                Console.WriteLine("Press E to use your hint");
            }
            if (eliminateAnswersAvailable)
            {
                Console.WriteLine("Press E to eliminate two answers");
            }
            else
            {

            }

            Console.WriteLine();
            Console.WriteLine("Please enter answer:");
            userResponse = Console.ReadLine().ToUpper();


            if (userResponse == "D")
            {
                int bank = 1000 + 10000 + 20000 + 50000 + 100000 + 500000;
                Console.WriteLine($"That is correct. You now have ${bank} dollars. Press any key to continue to question 5");
                Console.ReadKey();

            }

            else if (userResponse == "H")
            {
                Console.WriteLine("He is known for him famous headphones");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "D")
                {
                    Console.Clear();
                    Console.WriteLine("That is correct. You have $500 dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 15");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was D.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                hintAvailable = false;
            }

            else if (userResponse == "E")
            {
                Console.WriteLine("B and C are incorrect.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "D")
                {
                    Console.Clear();
                    Console.WriteLine("That is correct. You have $500 dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 15");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was D.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                eliminateAnswersAvailable = false;
            }

            else
            {
                Console.WriteLine("That answer was incorrect. I'm sorry, the game is over.");
                DisplayContinuePrompt();
                DisplayMainMenu();
            }


            //
            // Question 15
            //

            Console.Clear();
            Console.WriteLine("15. After the bombing of Pearl Harbor, the US declared war on which country");
            Console.Write("A. Russia");
            Console.Write("\t   B. Iran");
            Console.Write("\t   C. Japan");
            Console.Write("\t   D. North Korea");
            Console.WriteLine();

            if (hintAvailable)
            {
                Console.WriteLine("Press E to use your hint");
            }
            if (eliminateAnswersAvailable)
            {
                Console.WriteLine("Press E to eliminate two answers");
            }
            else
            {

            }

            Console.WriteLine();
            Console.WriteLine("Please enter answer:");
            userResponse = Console.ReadLine().ToUpper();


            if (userResponse == "C")
            {

                int bank = Question1 + Question2 + Question3 + Question4 + Question5 + Question6 + Question7 + Question8 + Question9 + Question10 + Question11 + Question12 + Question13 + Question14 + Question15;
                Console.WriteLine($"That is correct. You now have ${bank} dollars. YOU HAVE WON THE GAME");
                Console.ReadKey();


            }

            else if (userResponse == "H")
            {
                Console.WriteLine("The countries flag has a big red dot in the middle.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "C")
                {
                    Console.Clear();
                    Console.WriteLine("That is correct. You have $500 dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 6");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was C.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                hintAvailable = false;
            }

            else if (userResponse == "E")
            {
                Console.WriteLine("A and C are incorrect.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "C")
                {
                    Console.Clear();
                    Console.WriteLine("That is correct. You have $500 dollars in the bank.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to question 6");
                    Console.ReadKey();
                }

                else
                {

                    Console.Clear();
                    Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was C.");
                    Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    DisplayContinuePrompt();
                    DisplayMainMenu();


                }
                eliminateAnswersAvailable = false;
            }

            else
            {
                Console.WriteLine("That answer was incorrect. I'm sorry, the game is over.");
                DisplayContinuePrompt();
                DisplayMainMenu();
            }



        }


        /// <summary>
        /// display header
        /// </summary>
        static void DisplayHeader(string headerTitle)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t" + headerTitle);
            Console.WriteLine();
        }

        /// <summary>
        /// display continue prompt
        /// </summary>
        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        /// <summary>
        /// display closing screen
        /// </summary>
        static void DisplayClosingScreen()
        {
            Console.Clear();



            Console.WriteLine();
            Console.WriteLine("\t\tThank you for playing");
            Console.WriteLine();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
