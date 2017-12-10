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
            AppDescription();
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

                Console.WriteLine("\tA) Who wants to be a millonare - Easy");
                Console.WriteLine("\tB) Who Wants to be a Millionare - Medium");
                Console.WriteLine("\tC) Who Wants to be a Millionare - Hard");
                Console.WriteLine("\tQ) Quit");
                Console.Write("Enter Choice:");
                menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "A":
                    case "a":
                        WhoWantsToBeAMillionareEasy();
                        break;

                    case "B":
                    case "b":
                        PlayWhoWamtsToBeAMillionareMedium();
                        break;

                    case "C":
                    case "c":
                        PlayWhoWantsToBeAMillionareHArd();
                        break;

                    case "D":
                    case "d":

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
            SoundPlayer WhoWantsToBeAMillionareMusic = new SoundPlayer(@"media/scary-suspense.wav");

            WhoWantsToBeAMillionareMusic.Play();

            WhoWantsToBeAMillionareMusic.Dispose();




        }


        static void WhoWantsToBeAMillionareEasy()
        {
            bool hintAvailable = true;
            bool eliminateAnswersAvailable = true;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Gray;

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


            DisplayHeader("Who Wants to be a Millionare");
            Console.WriteLine();
            Console.WriteLine("Welcome to Who wants to be a Millionare");
            Console.WriteLine();
            Console.WriteLine("Difficulty: Easy");
            Console.WriteLine();
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();
            DisplayContinuePrompt();


            //
            // Question 1
            //


            Console.Clear();
            Console.WriteLine($"{name}: $0");
            Console.WriteLine();
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
            Console.WriteLine($"{name}: $100");
            Console.WriteLine();
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
                int bank =  Question2;
                Console.WriteLine($"You are correct. You now have ${bank} dollars.");
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
                    int bank = Question2;
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
            Console.WriteLine($"{name}: $200");
            Console.WriteLine();
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
                Console.WriteLine("You now have $300 dollars in the bank! Press any key to move on to question 4");
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
            Console.WriteLine("4. What are the side lengths of a sqaure?");
            Console.Write("A. The Height is always larger the the width");
            Console.Write("\t   B. Equal");
            Console.Write("\t   C. The width is larger then the height");
            Console.Write("\t   D. What is a square?");
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
                int bank = Question4;
                Console.WriteLine($"That is correct. You now have ${bank} dollars. Press any key to continue to question 5");
                Console.ReadKey();

            }

            else if (userResponse == "H")
            {
                Console.WriteLine("If a sqaure has a width of 6, the height is 6.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "B")
                {
                    Console.Clear();
                    int bank =  Question4;
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
                Console.WriteLine("C and D are not correct.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "B")
                {
                    Console.Clear();
                    int bank =  Question4;
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
            Console.WriteLine("5. What is the name of the movie about The Titanic?");
            Console.Write("A. The Ship");
            Console.Write("\t   B. The Long Way Back");
            Console.Write("\t   C. Titanic");
            Console.Write("\t   D. That Dang Iceberg");
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
                int bank =  500;
                Console.WriteLine($"That is correct. You now have ${bank} dollars. Press any key to continue to question 5");
                Console.ReadKey();

            }

            else if (userResponse == "H")
            {
                Console.WriteLine("The name of the movie is the same of the ship.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "C")
                {
                    Console.Clear();
                    int bank = Question5;
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
                Console.WriteLine("A and B are incorrect");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "C")
                {
                    Console.Clear();
                    int bank =  Question5;
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
            Console.WriteLine($"{name}: $500");
            Console.WriteLine();
            Console.WriteLine("6. What is the thing in the sky that heats the Earth?");
            Console.Write("A. The sun");
            Console.Write("\t   B. The stars");
            Console.Write("\t   C. The moon");
            Console.Write("\t   D. A space heater (pun intended)");
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
                int bank = Question6;
                Console.WriteLine($"That is correct. You now have ${bank} dollars. Press any key to continue to question 5");
                Console.ReadKey();

            }

            else if (userResponse == "H")
            {
                Console.WriteLine("To look at this for longer than a minute, can be permanently blinding.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "A")
                {
                    Console.Clear();
                    int bank = Question6;
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
                    int bank = Question6;
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
            Console.WriteLine($"{name}: $600");
            Console.WriteLine();
            Console.WriteLine("7. This sport is played with 4 bases, a bat, a glove, and a ball.");
            Console.Write("A. Football");
            Console.Write("\t   B. Baseball");
            Console.Write("\t   C. Basketball");
            Console.Write("\t   D. Soccer");
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
                int bank =  Question7;
                Console.WriteLine($"That is correct. You now have ${bank} dollars. Press any key to continue to question 5");
                Console.ReadKey();

            }

            else if (userResponse == "H")
            {
                Console.WriteLine("The answer has had people play it like Babe Ruth, Lou Gehrig, Nolan Ryan, and Ken Griffey Jr.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "B")
                {
                    Console.Clear();
                    int bank =  Question7;
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
                    int bank = Question7;
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
            Console.WriteLine($"{name}: $700");
            Console.WriteLine();
            Console.WriteLine("8. This marked the founding of the United States");
            Console.Write("A. Declaration of Independence");
            Console.Write("\t   B. 16th Amendment");
            Console.Write("\t   C. Emancipation Proclamation");
            Console.Write("\t   D. 15th Amendment");
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
                int bank =  800;
                Console.WriteLine($"That is correct. You now have ${bank} dollars. Press any key to continue to question 5");
                Console.ReadKey();

            }

            else if (userResponse == "H")
            {
                Console.WriteLine("This has the word that means to be responsible for ones self in it.");
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
            Console.WriteLine($"{name}: $800");
            Console.WriteLine();
            Console.WriteLine("9. What is the name of the band that was made up of men like John Lennon and Ringo Starr?");
            Console.Write("A. The Red Eyed Peas");
            Console.Write("\t   B. Chicago");
            Console.Write("\t   C. The Beatles");
            Console.Write("\t   D. Cream");
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
                int bank = 900;
                Console.WriteLine($"That is correct. You now have $900 dollars. Press any key to continue to question 5");
                Console.ReadKey();

            }

            else if (userResponse == "H")
            {
                Console.WriteLine("One hit song for this group was titled: Here Comes the Sun.");
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
            Console.WriteLine($"{name}: $900");
            Console.WriteLine();
            Console.WriteLine("10. What is a synonym for the word discombobulated?");
            Console.Write("A. Rebooted");
            Console.Write("\t   B. Discomfort");
            Console.Write("\t   C. Happy");
            Console.Write("\t   D. Annoyed");
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
                int bank = 1000;
                Console.WriteLine($"That is correct. You now have $1,000 dollars. Press any key to continue to question 11");
                Console.ReadKey();

            }

            else if (userResponse == "H")
            {
                Console.WriteLine("This word hints towards being in a sense of uncomfort.");
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
            Console.WriteLine($"{name}: $1,000");
            Console.WriteLine();
            Console.WriteLine("11. What is the fourth letter in the backwards aplhabet?");
            Console.Write("A. Y");
            Console.Write("\t   B. D");
            Console.Write("\t   C. J");
            Console.Write("\t   D. W");
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

                Console.WriteLine($"That is correct. You now have $10,000 dollars. Press any key to continue to question 12");
                Console.ReadKey();

            }

            else if (userResponse == "H")
            {
                Console.WriteLine("This is first letter in the word that means melted candle.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "D")
                {
                    Console.Clear();
                    Console.WriteLine("That is correct. You have $10,000 dollars in the bank.");
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
                    Console.WriteLine("That is correct. You have $10,000 dollars in the bank.");
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
            Console.WriteLine($"{name}: $10,000");
            Console.WriteLine();
            Console.WriteLine("12. This book called: fifty shades of _____ was an absolute hit in the Us?");
            Console.Write("A. Red");
            Console.Write("\t   B. Brown ");
            Console.Write("\t   C. Grey");
            Console.Write("\t   D. Green");
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
                int bank = 50000;
                Console.WriteLine($"That is correct. You now have ${bank} dollars. Press any key to continue to question 5");
                Console.ReadKey();

            }

            else if (userResponse == "H")
            {
                Console.WriteLine("This color resembles the color of the moon as we see it.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "C")
                {
                    Console.Clear();
                    Console.WriteLine("That is correct. You have $50,000 dollars in the bank.");
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
                    Console.WriteLine("That is correct. You have $50,000 dollars in the bank.");
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
            Console.WriteLine($"{name}: $50,000");
            Console.WriteLine();
            Console.WriteLine("13. Who was our first president?");
            Console.Write("A. Taft");
            Console.Write("\t   B. Livingston");
            Console.Write("\t   C. Lincoln");
            Console.Write("\t   D. Washington");
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
                int bank =  100000;
                Console.WriteLine($"That is correct. You now have ${bank} dollars. Press any key to continue to question 5");
                Console.ReadKey();

            }

            else if (userResponse == "H")
            {
                Console.WriteLine("He is known for his teeth made of wood.");
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
                    Console.WriteLine("That is correct. You have $100,000 dollars in the bank.");
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
            Console.WriteLine($"{name}: $100,000");
            Console.WriteLine();
            Console.WriteLine("14. What season resembles cold and icy precipitation?");
            Console.Write("A. Fall");
            Console.Write("\t   B. Summer");
            Console.Write("\t   C. Spring");
            Console.Write("\t   D. Winter");
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
                int bank = 500000;
                Console.WriteLine($"That is correct. You now have ${bank} dollars. Press any key to continue to question 5");
                Console.ReadKey();

            }

            else if (userResponse == "H")
            {
                Console.WriteLine("This is the season we have when christmas rolls around.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "D")
                {
                    Console.Clear();
                    Console.WriteLine("That is correct. You have $500,000 dollars in the bank.");
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
                    Console.WriteLine("That is correct. You have $500,000 dollars in the bank.");
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
            Console.WriteLine($"{name}: $500,000");
            Console.WriteLine();
            Console.WriteLine("15. What mood color resembles anger");
            Console.Write("A. Brown");
            Console.Write("\t   B. Orange");
            Console.Write("\t   C. Red");
            Console.Write("\t   D. Black");
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

                int bank =  Question15;
                Console.WriteLine($"That is correct. You now have ${bank} dollars. YOU HAVE WON THE GAME");
                Console.ReadKey();


            }

            else if (userResponse == "H")
            {
                Console.WriteLine("We see this color accompanied with green during christmas.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "C")
                {
                    Console.Clear();
                    Console.WriteLine("That is correct. You have Won the game. Thanks for playing");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to the main menu.");
                    Console.ReadKey();
                    DisplayMainMenu();
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
                    Console.WriteLine("That is correct. You have won the game!!!!!!!!!!!!!!");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue to the menu");
                    Console.ReadKey();
                    DisplayMainMenu();
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

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = ConsoleColor.Gray;



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

            DisplayHeader("Who Wants to be a Millionare");
            Console.WriteLine();
            Console.WriteLine("Welcome to Who wants to be a Millionare");
            Console.WriteLine();
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Difficulty: Medium");
            DisplayContinuePrompt();


            //
            // Question 1
            //

            Console.Clear();
            Console.WriteLine($"{name}: $0");
            Console.WriteLine();
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
            Console.WriteLine($"{name}: $100");
            Console.WriteLine();
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
                Console.WriteLine("You are correct. You now have $200 dollars.");
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
            Console.WriteLine($"{name}: $200");
            Console.WriteLine();
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
            Console.WriteLine($"{name}: $300");
            Console.WriteLine();
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
                int bank =  Question4;
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
                    int bank =  Question4;
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
                    int bank = Question4;
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
            Console.WriteLine($"{name}: $400");
            Console.WriteLine();
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
                int bank =  500;
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
                    int bank =  Question5;
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
                    int bank = Question5;
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
            Console.WriteLine($"{name}: $500");
            Console.WriteLine();
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
                int bank =  Question6;
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
                    int bank =  Question6;
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
                    int bank = Question6;
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
            Console.WriteLine($"{name}: $600");
            Console.WriteLine();
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
                int bank =  Question7;
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
                    int bank = Question7;
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
                    int bank = Question7;
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
            Console.WriteLine($"{name}: $700");
            Console.WriteLine();
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
                int bank =  800;
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
            Console.WriteLine($"{name}: $800");
            Console.WriteLine();
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
                int bank = 900;
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
            Console.WriteLine($"{name}: $900");
            Console.WriteLine();
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
                int bank = 1000;
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
            Console.WriteLine($"{name}: $1,000");
            Console.WriteLine();
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

                Console.WriteLine($"That is correct. You now have $10,000 dollars. Press any key to continue to question 12");
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
                    Console.WriteLine("That is correct. You have $10,000 dollars in the bank.");
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
                    Console.WriteLine("That is correct. You have $10,000 dollars in the bank.");
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
            Console.WriteLine($"{name}: $10,000");
            Console.WriteLine();
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
                int bank = 50000;
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
                    Console.WriteLine("That is correct. You have $50,000 dollars in the bank.");
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
                    Console.WriteLine("That is correct. You have $50,000 dollars in the bank.");
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
            Console.WriteLine($"{name}: $50,000");
            Console.WriteLine();
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
                int bank =  100000;
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
                    Console.WriteLine("That is correct. You have 100,000 dollars in the bank.");
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
                    Console.WriteLine("That is correct. You have $100,000 dollars in the bank.");
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
            Console.WriteLine($"{name}: $500,000");
            Console.WriteLine();
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
                int bank = 500000;
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
                    Console.WriteLine("That is correct. You have $500,000 dollars in the bank.");
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
                    Console.WriteLine("That is correct. You have $500,000 dollars in the bank.");
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
            Console.WriteLine($"{name}: $500,000");
            Console.WriteLine();
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

                int bank =  Question15;
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
                    Console.WriteLine("That is correct. You have $1,000,000 dollars in the bank. You have won!!!!");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue ");
                    Console.ReadKey();
                    DisplayMainMenu();
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
                    Console.WriteLine("That is correct. You have $1,000,000 dollars in the bank. You have won the game.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    DisplayMainMenu();
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



        static void PlayWhoWantsToBeAMillionareHArd()
        {
            bool hintAvailable = true;
            bool eliminateAnswersAvailable = true;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Gray;


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

            Console.WriteLine();
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine();

            DisplayHeader("Who Wants to be a Millionare");
            Console.WriteLine();
            Console.WriteLine($"Welcome {name} to Who wants to be a Millionare");
            Console.WriteLine();
            Console.WriteLine("Difficulty: Hard");
            DisplayContinuePrompt();



            //
            // Question 1
            //

            
            Console.Clear();
            Console.WriteLine($"{name}: 0 points");
            Console.WriteLine();
            Console.WriteLine("1. What are corporations called that control the entire market leaving no room for small businesses?");
            Console.Write("A. Corporation");
            Console.Write("\t   B. Partnership");
            Console.Write("\t   C. Monopoly");
            Console.Write("\t   D. Small Business");
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
                Console.WriteLine("The answer is a board game in which you fight to earn properties");
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
                Console.WriteLine("I'm sorry, that answer is incorrect. The correct answer was C.");
                Console.WriteLine();
                Console.WriteLine("Game Over!");
                DisplayContinuePrompt();
                DisplayMainMenu();


            }




            //
            // Question 2
            //

            Console.Clear();
            Console.WriteLine($"{name}: $100");
            Console.WriteLine();
            Console.WriteLine("2. Which type of a burn is more severe?");
            Console.Write("A. First");
            Console.Write("\t   B. Second");
            Console.Write("\t   C. Third");
            Console.Write("\t   D. Fourth");
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
                int bank = Question2;
                Console.WriteLine($"You are correct. You have $200 dollars in the bank.");
                Console.WriteLine();
                Console.WriteLine("Press any key to continue on to question 3.");
                Console.ReadKey();
            }

            else if (userResponse == "H")
            {
                Console.WriteLine("The higher the scale of the burn is, the worse it is.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "D")
                {
                    Console.Clear();
                    int bank =   Question2;
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
            Console.WriteLine($"{name}: $200");
            Console.WriteLine();
            Console.WriteLine("3. All things are part of a horses anatomy except");
            Console.Write("A. Mane");
            Console.Write("\t   B. Bine");
            Console.Write("\t   C. Frog");
            Console.Write("\t   D. Hoof");
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
                Console.WriteLine("You now have $300 dollars in the bank! Press any key to move on to question 4");
                Console.ReadKey();

            }

            else if (userResponse == "H")
            {
                Console.WriteLine("The Frog is part of a horses anatomy");
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
            Console.WriteLine($"{name}: $300");
            Console.WriteLine();
            Console.WriteLine("4. If a rectangle has base of 15 and a height of 13, what is the area?");
            Console.Write("A. 182");
            Console.Write("\t   B. 195");
            Console.Write("\t   C. 187");
            Console.Write("\t   D. 180");
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
                int bank = Question4;
                Console.WriteLine($"That is correct. You now have ${bank} dollars. Press any key to continue to question 5");
                Console.ReadKey();

            }

            else if (userResponse == "H")
            {
                Console.WriteLine("multiply 15 by 13.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "B")
                {
                    Console.Clear();
                    int bank = Question4;
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
                Console.WriteLine("C and D are not correct.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "B")
                {
                    Console.Clear();
                    int bank = Question4;
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
            Console.WriteLine($"{name}: $400");
            Console.WriteLine();
            Console.WriteLine("5. Freeport international airport is in which country?");
            Console.Write("A. Germany");
            Console.Write("\t   B. The Phillipines");
            Console.Write("\t   C. The Bahamas");
            Console.Write("\t   D. Iceland");
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
                int bank =  500;
                Console.WriteLine($"That is correct. You now have ${bank} dollars. Press any key to continue to question 5");
                Console.ReadKey();

            }

            else if (userResponse == "H")
            {
                Console.WriteLine("Think of which of these places speak primarily english.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "C")
                {
                    Console.Clear();
                    int bank = Question5;
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
                Console.WriteLine("A and B are incorrect");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "C")
                {
                    Console.Clear();
                    int bank = Question5;
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
            Console.WriteLine($"{name}: $500");
            Console.WriteLine();
            Console.WriteLine("6. Who is in charge of security at an airport");
            Console.Write("A. TSA");
            Console.Write("\t   B. NRA");
            Console.Write("\t   C. IRA");
            Console.Write("\t   D. FBI");
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
                int bank = Question6;
                Console.WriteLine($"That is correct. You now have ${bank} dollars. Press any key to continue to question 5");
                Console.ReadKey();

            }

            else if (userResponse == "H")
            {
                Console.WriteLine("The answer starts with a T");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "A")
                {
                    Console.Clear();
                    int bank = Question6;
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
                    int bank =  Question6;
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
            Console.WriteLine($"{name}: $600");
            Console.WriteLine();
            Console.WriteLine("7. Who was the first artist to enter the US album chart at #1?");
            Console.Write("A. John Lennon");
            Console.Write("\t   B. Elton John");
            Console.Write("\t   C. Frank Sinatra");
            Console.Write("\t   D. Johny Cash");
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
                int bank =  Question7;
                Console.WriteLine($"That is correct. You now have ${bank} dollars. Press any key to continue to question 5");
                Console.ReadKey();

            }

            else if (userResponse == "H")
            {
                Console.WriteLine("This man is British and was originally born in London.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "B")
                {
                    Console.Clear();
                    int bank =  Question7;
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
                    int bank = Question7;
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
            Console.WriteLine($"{name}: $700");
            Console.WriteLine();
            Console.WriteLine("8. Who invented the method of AC electricity");
            Console.Write("A. Thomas Edison");
            Console.Write("\t   B. John Smoltz");
            Console.Write("\t   C. Nikola Tesla");
            Console.Write("\t   D. Peter Gallaway");
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
                int bank =  800;
                Console.WriteLine($"That is correct. You now have ${bank} dollars. Press any key to continue to question 5");
                Console.ReadKey();

            }

            else if (userResponse == "H")
            {
                Console.WriteLine("His last name happens to be the name of one of the most trusted self driving car companies");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "C")
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


                if (userResponse == "C")
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
            Console.WriteLine($"{name}: $800");
            Console.WriteLine();
            Console.WriteLine("9. What temperature in celcius, is considered freezing?");
            Console.Write("A. 32 degrees");
            Console.Write("\t   B. -5 degrees");
            Console.Write("\t   C. 0 Degrees");
            Console.Write("\t   D. 12 degrees");
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
                int bank =900;
                Console.WriteLine($"That is correct. You now have $900 dollars. Press any key to continue to question 5");
                Console.ReadKey();

            }

            else if (userResponse == "H")
            {
                Console.WriteLine("If it were 0 celcius out, it would be 32 degrees farenheit");
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
            Console.WriteLine($"{name}: $900");
            Console.WriteLine();
            Console.WriteLine("10. What foreign government contributed the most money in relief efforts towards the victims of the 1906 San Fransico Earthquake?");
            Console.Write("A. China");
            Console.Write("\t   B. Japan");
            Console.Write("\t   C. Luxembourg");
            Console.Write("\t   D. Italy");
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
                int bank = 1000;
                Console.WriteLine($"That is correct. You have $1,000 dollars in the bank. Press any key to continue to question 11");
                Console.ReadKey();

            }

            else if (userResponse == "H")
            {
                Console.WriteLine("This country is known for its city of Tokyo");
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
            Console.WriteLine($"{name}: $1,000");
            Console.WriteLine();
            Console.WriteLine("11. Which US state is the only to produce coffee?");
            Console.Write("A. Wisconsin");
            Console.Write("\t   B. Missouri");
            Console.Write("\t   C. Illinois");
            Console.Write("\t   D. Hawaii");
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
                int bank =  Question11;
                Console.WriteLine($"That is correct. You now have ${bank} dollars. Press any key to continue to question 12");
                Console.ReadKey();

            }

            else if (userResponse == "H")
            {
                Console.WriteLine("This is the aloha state.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "D")
                {
                    Console.Clear();
                    Console.WriteLine("That is correct. You have $10,000 dollars in the bank.");
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
                    Console.WriteLine("That is correct. You have $10,000 dollars in the bank.");
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
            Console.WriteLine($"{name}: $10,000");
            Console.WriteLine();
            Console.WriteLine("12. Who directed the blockbusting movie Alien?");
            Console.Write("A. Steven Spielberg");
            Console.Write("\t   B. Richy Harrison");
            Console.Write("\t   C. Riddley Scott");
            Console.Write("\t   D. George Redmonds");
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
                int bank = 50000 ;
                Console.WriteLine($"That is correct. You now have ${bank} dollars. Press any key to continue to question 5");
                Console.ReadKey();

            }

            else if (userResponse == "H")
            {
                Console.WriteLine("He also directed Gladiator.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "C")
                {
                    Console.Clear();
                    Console.WriteLine("That is correct. You have $50,000 dollars in the bank.");
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
                    Console.WriteLine("That is correct. You have $50,000 dollars in the bank.");
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
            Console.WriteLine("13. At the beginning of the 1990's, what country had the most camels?");
            Console.Write("A. Egypt");
            Console.Write("\t   B. Saudi Arabia");
            Console.Write("\t   C. Libya");
            Console.Write("\t   D. Somalia");
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
                int bank =  100000;
                Console.WriteLine($"That is correct. You now have ${bank} dollars. Press any key to continue to question 5");
                Console.ReadKey();

            }

            else if (userResponse == "H")
            {
                Console.WriteLine("This country is known for its broad history of pirating.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "D")
                {
                    Console.Clear();
                    Console.WriteLine("That is correct. You have 100,000 dollars in the bank.");
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
                    Console.WriteLine("That is correct. You have $100,000 dollars in the bank.");
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
            Console.WriteLine("14. Freddy Mercury died in what year?");
            Console.Write("A. 1992");
            Console.Write("\t   B. 1990");
            Console.Write("\t   C. 1989");
            Console.Write("\t   D. 1991");
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
                int bank =  500000;
                Console.WriteLine($"That is correct. You now have ${bank} dollars. Press any key to continue to question 5");
                Console.ReadKey();

            }

            else if (userResponse == "H")
            {
                Console.WriteLine("This year was when Rod Carew was elected into the hall of fame.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "D")
                {
                    Console.Clear();
                    Console.WriteLine("That is correct. You have $500,000 dollars in the bank.");
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
                    Console.WriteLine("That is correct. You have $500,000 dollars in the bank.");
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
            Console.WriteLine("15. Sleep apnea does what?");
            Console.Write("A. Cause loss of memory");
            Console.Write("\t   B. Causes speech impedement");
            Console.WriteLine("\t\t   C. Causes pause in breathing during sleep");
            Console.Write("\t\t   D. Causes instant sleep");
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

                int bank = Question15;
                Console.WriteLine($"That is correct. You now have ${bank} dollars. YOU HAVE WON THE GAME");
                Console.ReadKey();


            }

            else if (userResponse == "H")
            {
                Console.WriteLine("It has to do with sleep.");
                Console.WriteLine();
                Console.WriteLine("Please enter answer:");
                userResponse = Console.ReadLine().ToUpper();


                if (userResponse == "C")
                {
                    Console.Clear();
                    Console.WriteLine("That is correct. You have won the game and $1,000,000 dollars. Thanks for playing");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue on to the main menu.");
                    Console.ReadKey();
                    DisplayMainMenu();
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
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.Blue;

                    Console.Clear();
                    Console.WriteLine("That is correct. You have won the game!!!!!!!!!!!!!!");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue to the menu");
                    Console.ReadKey();
                    DisplayMainMenu();
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
            Console.WriteLine("\t\tThank you for playing Who Wants to be a Millionare.");
            Console.WriteLine();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

    }

}


