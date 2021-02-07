using System;
using System.Collections.Generic;
using System.Linq;

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
                    + "\n5. Recursive Odd"
                    + "\n6. Recursice Even"
                    + "\n7. Recursive Fibonacci"
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
                    case '5':
                        RecursiveOdd();
                        break;
                    case '6':
                        RecursiveEven();
                        break;
                    case '7':
                        RecursiveFibonacci();
                        break;
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
            Queue<string> Queue = new Queue<string>();
            bool open = true;
            char choice = ' ';
            while (open)
            {
                Console.WriteLine("\nFeel free to add or remove someone from the Queue."+
                    "\n'1' to Add someone to the Queue:"+
                    "\n'2' to Remove someone from the Queue:"+
                    "\n'3' to Quit back to main menu:");

                try
                {
                    choice = Console.ReadLine()[0];
                }
                catch (IndexOutOfRangeException)
                {
                    Console.Clear();
                    Console.WriteLine("Please make a valid selection");
                }
                switch (choice)
                {
                    case '1':
                        QueueDisplay(Queue);
                        Console.WriteLine("Who would you like to add to the queue? You can separate multiple people with a comma ',' :");
                        string newPerson = Console.ReadLine();

                        char[] separators = { ',',' ' };
                        string[] names = newPerson.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                        foreach (string name in names)
                        {
                            Queue.Enqueue(name);
                            Console.WriteLine($"\n{name} has been added to the queue.");
                        }
                        break;
                    case '2':
                        QueueDisplay(Queue);
                        Console.WriteLine("How many would you like to remove from the queue?");
                        string n = Console.ReadLine();
                        int peopleOut;
                        int.TryParse(n, out peopleOut);
                        for (int i = 0; i < peopleOut && Queue.Count > 0; i++)
                        {
                            Queue.Dequeue();
                        }
                        Console.WriteLine($"\n{peopleOut.ToString()} have made their way out of the queue.");
                        QueueDisplay(Queue);
                        break;
                    case '3':
                        open = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Please make a valid selection.");
                        break;
                }

            }
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
            Stack<string> Tower = new Stack<string>();
            bool open = true;
            char choice = ' ';

            while(open)
            {
                Console.WriteLine("Welcome to the stack. Please make a selecion. You may choose:" +
                    "\n'1' To add someone to the stack." +
                    "\n'2' To remove someone from the stack." +
                    "\n'3' Sentence reversal exercise." +
                    "\n'4' To quit back to main menu:");

             try
                {
                  choice = Console.ReadLine()[0];
                }
                catch (IndexOutOfRangeException)
                {
                    Console.Clear();
                    Console.WriteLine("Please make a valid selection");
                }
                switch (choice)
                {
                    case '1':
                        DisplayStack(Tower);
                        Console.WriteLine("\nWho would you like to add to the stack?");
                        string newThing = Console.ReadLine();

                        Tower.Push(newThing);
                        Console.WriteLine($"{newThing} was added to the bottom of the stack!");

                        break;
                    case '2':
                        DisplayStack(Tower);
                        Console.WriteLine("\nHow many people would you like to remove from the stack?");
                        int.TryParse(Console.ReadLine(), out int people);

                        for(int i = 0 ; i < people && Tower.Count > 0; i++)
                        {
                            Console.WriteLine($"{Tower.Pop()} has been removed from the stack.");
                        }
                        break;

                    //Method to reverse entered text.
                    case '3':
                        ReverseText();

                        break;
                    case '4':
                        open = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Please make a valid selection");
                        break;
                }
                    
            }

        }

        /// <summary>
        /// Method to reverse the string entered.
        /// </summary>
        private static void ReverseText()
        {
            Stack<char> Entries = new Stack<char>();

            //Converts entry to Character Stack
            Console.WriteLine("Please write some thing and I'll reverse it for you:");
            string entry = Console.ReadLine();
            char[] entryCharacters = entry.ToCharArray();
            foreach (char character in entryCharacters)
                Entries.Push(character);

            //Reverses it on display
            Console.WriteLine("\nHere's your message reversed:");
            while (Entries.Count > 0)
                Console.Write(Entries.Pop());
            Console.WriteLine("\n");
        }

        /// <summary>
        /// Examines if Paranthesis in given line are balanced.
        /// </summary>
        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */
            bool open = true;
            bool balance = true;
            Stack<char> Openers = new Stack<char>();

            while (open)
            {
                Console.WriteLine("Let me check to see if the paranthesis of your line is correct." +
                    "\nPlease enter your text:");
                string input = Console.ReadLine();
                char[] letters = input.ToCharArray();

                foreach (char letter in letters)
                {

                    if (letter.Equals('{') || letter.Equals('(') || letter.Equals('['))
                        Openers.Push(letter);

                    if (letter.Equals('}') || letter.Equals(')') || letter.Equals(']'))
                    {
                        if (letters.Length == 0)
                            balance = false;

                        else if (!MatchingBracket(Openers.Pop(), letter))
                            balance = false;
                    }
                }
                if (Openers.Count == 0)
                    balance = true;
                else
                    balance = false;

                if (balance)
                    Console.WriteLine("Success! Your line is correct!");
                else
                    Console.WriteLine("Your line is incorrect.");

                Console.WriteLine("Would you like to try again? Enter 'Q' to quit back to main menu:");
                string answer = Console.ReadLine();
                if (answer[0].Equals('Q') || answer[0].Equals('q'))
                    open = false;
            }
        }

        /// <summary>
        /// Interactive method for using RecursiveOdd method.
        /// </summary>
        private static void RecursiveOdd()
        {
            bool open = true;


            while (open)
            {

                Console.Clear();
                Console.WriteLine("Please give me a number:");
                int number = int.Parse(Console.ReadLine());
                int result = RecursiveOdd(number);
                Console.WriteLine(result.ToString());
                
                Console.WriteLine("Would you like to try again? Press 'Q' to quit");
                
                ConsoleKey key = GetKey();
                if (key.Equals(ConsoleKey.Q))
                {
                    open = false;
                }

            }
        }

        /// <summary>
        /// Method for recursively finding the nth Odd number.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private static int RecursiveOdd(int n)
        {
            if (n==0)
            { return 1; }
            return (RecursiveOdd(n - 1) + 2);
        }

        /// <summary>
        /// Interactive method for using RecursiveEven method.
        /// </summary>
        private static void RecursiveEven()
        {
            bool open = true;

            while (open)
            {
                Console.Clear();
                Console.WriteLine("Let me find the nth even number."
                                + "\nGive me any number you'd like:");
                int number = Convert.ToInt32(Console.ReadLine());
                int result = RecursiveEven(number);
                Console.WriteLine($"The {number.ToString()}th even number is {result.ToString()}");

                Console.WriteLine("Would you like to try again? Press 'Q' to quit");

                ConsoleKey key = GetKey();
                if (key.Equals(ConsoleKey.Q))
                {
                    open = false;
                }

            }
        }

        private static int RecursiveEven(int n)
        {
            if (n == 0)
                return 0;
            return (RecursiveEven(n - 1) + 2);
        }

        /// <summary>
        /// Quick method to display the current people in the Queue
        /// </summary>
        /// <param name="Queue"></param>
        private static void QueueDisplay(Queue<string> Queue)
        {
            Console.WriteLine("\nHere are the people in the Queue:" +
                                        "\n-------------------");
            foreach (string person in Queue)
            {
                Console.WriteLine(person);
            }
        }

        internal static void RecursiveFibonacci()
        {
            bool open = true;
            int number=0;
            while (open)
            {
                Console.Clear();
                Console.WriteLine("I will find the nth number in the Fibonacci Sequence using Recursion."
                                + "\nWhich number in the sequence would you like me to find:");
                try { int.TryParse(Console.ReadLine(), out number); }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("Please make a valid selection.");
                }

                int result = RecursiveFibonacci(number);
                Console.WriteLine($"The {number.ToString()}th number in the Fibonacci Sequence is: {result.ToString()}");

                Console.WriteLine("Would you like to try again? Press 'Q' to quit");

                ConsoleKey key = GetKey();
                if (key.Equals(ConsoleKey.Q))
                {
                    open = false;
                }
            }
        }

        /// <summary>
        /// Calculates Nth number of Fibonacci Sequence using Recursion.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private static int RecursiveFibonacci(int n)
        {
            if (n == 0||n==1)
                return n;
            return RecursiveFibonacci(n - 1) + RecursiveFibonacci(n - 2);
        }



        /// <summary>
        /// Quick method to return the actual key pressed.
        /// </summary>
        /// <returns></returns>
        internal static ConsoleKey GetKey()
        {
            return Console.ReadKey(intercept: false).Key;
        }

        /// <summary>
        /// Quick method to display current stack.
        /// </summary>
        /// <param name="stack"></param>
        static void DisplayStack(Stack<string> stack)
        {
            Console.WriteLine("Here is the current stack of people" +
                                        "\n-----------------------");
            foreach (string thing in stack)
                Console.WriteLine(thing);
            Console.WriteLine("----------------------");
        }

        /// <summary>
        /// Compares a list of correct matches of brackets.
        /// </summary>
        /// <param name="open"></param>
        /// <param name="close"></param>
        /// <returns></returns>
        static Boolean MatchingBracket(char open, char close)
        {
            if (open == '{' && close == '}')
                return true;
            else if (open == '(' && close == ')')
                return true;
            else if (open == '[' && close == ']')
                return true;
            else if (open == '<' && close == '>')
                return true;
            else
                return false;
        }
    }
}

