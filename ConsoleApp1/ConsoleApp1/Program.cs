
/// DIRECTIVES -  They tell the compiler that our program uses a certain namespace.
using System; //methods that allow us to interact with our users
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// NAMESPACE - a grouping of related code elements

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////////////////////////////////////// TYPES OF DATA

            byte smallNumber = 0; // int numbers from 0 - 255, used for machines with lim memory space

            // SINCE double is default type, float and decimal need suffix to explicitely tell the compiler to change the number to a float

            float pointyNumber = 1.33535f; /*uses 8bytes of storage and has precision of 7 digits.
                                           * 1.23456789 (10 digits), the number will be rounded off to 1.234568 (7 digits).
                                           */
            double pointierNumber = 3.444444; // precision of about 15 digits. WIDER ACCURACY. default.
            decimal smallPointyNumber = 1.44444444m; //has a smaller range than float and double. However, it has a much greater precision of approximately 28-29 digits

            // precision                                range
            // float - double - decimal                 decimal - float - double

            //////////////// ARRAYS

            int[] ages = { 23, 55, 11, 37, 44 }; //declaring and initializing

            int[] newAges = new int[5]; // declaring using the NEW operator
            newAges = new[] { 11, 22, 33, 44, 55 };

            /* properties and methods (use () + Array )
             * Length = number of items
             * Copy() = copy contents of one array into another
             * Sort() =  is ascending order
             */

            ////////////////////////////////////////////////////////////////////////////// STRINGS

            string text = "";
            text = "hello, i'm a string!";

            /* properties and methods
             * Length = # of characters
             * Substring (), 
             * Equals() = to compare if two strings are identical
             * Split() = complicated....ye
             */

            //////////////////////////////////////////////////////////// LISTS - stores values like an array, but elements can be added or removed at will
            ///

            List<int> myList = new List<int> { 11, 33, 5, 2, 1 };

            //properties and methods

            //Add
            myList.Add(223);
            //Count, to count number of elements
            //Insert, to add member at specific position.
            myList.Insert(3, 44); // position | element
            //Remove, receives element.
            myList.Remove(223);
            //RemoveAt, at specific loction
            //Contains, to check if list contains certain member, returns BOOLEAN |
            myList.Contains(13);
            //Clear


            ///////////////////////////////// VALUE TYPE
            ///    is a variable that stores its own data

            ///////////////////////////////// REFERENCE TYPE
            ///    doesn't store its own data, but tells the compiler where to find the actual data

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            ///////// DISPLAYING MESSAGES TO USERS

            //difference between WriteLine() and Write() is that that first moves the cursor down to the new line
            //difference between ReadLine and Read, is that the first reads whole line, the other just first character

            string userInput = Console.ReadLine();
            Console.WriteLine(userInput);

            //// convert string to number --- ToDecimal, ToSingle, ToDouble

            string userInput1 = Console.ReadLine();
            int newUserInput = Convert.ToInt32 (userInput1);
            Console.WriteLine(newUserInput);

            /////////////////////////////////////////////////////// CONTROL FLOW STATEMENTS ;; --------
            ///


            /*  INLINE IF :D   - if you want to assign a value to a variable depending on result of condition
             *  
             *                  condition   ?   value if true      :       value if false      ;                  
            */

            int ifLine = 10 > 3 ? 13 : 2;
            Console.WriteLine(ifLine);

            /*  FOREACH LOOPS :D - when working with arrays and lists, when you wanna get info without modifying
             * 
             * 
             */

            char[] greeting = { 'h', 'e' ,'y' };

            foreach (char i in greeting)
                Console.Write(i);

            /*  TRY CATCH FINALLY :o 
             * controls how the program proceeds when there's an error
             * 
             * you can have more than one catch, finally is optional
             * 
             * try
             * { do something  }
             * catch(type of error)
             * { do something else when error occurs }
             * finally
             * { do regardless of whether try or catch condition is met }
             */
            int choice = 0;
            int[] numbers = { 10, 11, 12, 13, 14, 15 };
            Console.Write("Please enter the index of the array: ");

            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("numbers[{0}] = {1}", choice, numbers[choice]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Error: Index should be from 0 to 5.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: You did not enter an integer.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            ReadLine();

        }
    }
}
