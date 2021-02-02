using System;
using System.Collections.Generic;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {      
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        /// 

        //F.1) Stacken är ordentligt ordnade i minnet i en "First in Last out" -ordning.
        //     Det är effektivt organiserat och data kastas när operationen är klar. 
        //     Heapen är en mindre organiserad cache av data, med referens för att hitta 
        //     allt snabbt. Den använder mer minne, men är mer flexibel.
        //F.2) Value Types är data som lagras direkt i minnet. Reference Types är pointers 
        //     som riktar sig till data.
        //F.3) Den första exampel här x och y som två variabler till två olika datapunkter.
        //     Först tilldelas y till x, sedan tilldelas y ett annat Value. X förblir tilldelat
        //     samma Value. 
        //     Den andra exampel här både x och y blir objekt som refererar till samma data.
        //     När data modifieras med y referensar x till samma modifiereade data.
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        //F.2) Listans kapacitet ökar när antalet fyllda utrymmen matchar
                        //     den aktuella kapaciteten för utrymmen.
                        //F.3) Listans kapacitet ökar först till fyra och fördubblas varje gång.
                        //F.4) Eftersom listan vill säkerställa att det finns tillräckligt med 
                        //     minne för objekten flyttas den automatiskt till en array med dubblet
                        //     så stor storlek.
                        //F.5) Listans kapacitet minskar inte när element tas bort ur listan.
                        //F.6) När du vet exakt hur många items du har, är det då fördelaktigt att
                        //     använda en Array instället för en lista.
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            //List<string> theList = new List<string>();
            //string input = Console.ReadLine();
            //char nav = input[0];
            //string value = input.substring(1);

            //switch(nav){...}

            List<string> thisList = new List<string>();
            bool open = true;

            while (open)//Allows method to repeat until closed with '0'
            {
                Console.WriteLine("Make an addition or subtraction to the list" +
                                    " beginning with either '+' or '-' [Enter 0 to exit]: ");
                string input = Console.ReadLine();
                string value = input.Substring(1);
                char nav = input[0];

                switch (nav)
                {
                    case '+':
                        try
                        {
                            thisList.Add(value);
                        }
                        catch (Exception)
                        {
                            Console.Clear();
                            Console.WriteLine("Invalid input. Please try again.");
                        }

                            Console.WriteLine($"The list has added {value} and has now grown by: " +
                                thisList.Capacity.ToString());
                            Console.WriteLine("List count: "+ thisList.Count.ToString());
                            Console.WriteLine("List capacity: "+ thisList.Capacity.ToString());
                        break;
                    case '-':
                        try
                        {
                           if( thisList.Remove(value))
                            {
                            Console.WriteLine($"The list has removed {value} and has now reduced to: " +
                                thisList.Capacity.ToString());
                            }
                           else
                                Console.WriteLine("Unable to remove from List.");
                        }
                        catch (Exception)
                        {
                            Console.Clear();
                            Console.WriteLine("Please try again.");
                        }
                            Console.WriteLine("List count: " + thisList.Count.ToString());
                            Console.WriteLine("List capacity: " + thisList.Capacity.ToString());
                        break;
                    case '0':
                        open = false;
                        break;
                    default:
                        Console.WriteLine("Please start your message with a '+' or '-'");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

        }

    }
}

