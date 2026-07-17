using System.Drawing;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C__Session_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region

            //Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a variable of type object. Print it.


            //Book book1 = new Book();

            //book1.title = "c# programming";
            //book1.pages = 512;

            //object obj = book1;
            //Console.WriteLine($"The Full Namespace is [ {obj} ]");

            //Console.WriteLine("_____________________________________________");
            ////Using the Book class above, print the result of calling ToString(), Equals() (compare book with itself), GetHashCode(), and GetType() on book.


            //Console.WriteLine($"The Full Namespace is {book1.ToString}");  // ToString Method 

            //Console.WriteLine("_____________________________________________");

            //Console.WriteLine(book1.Equals(book1)); // True 

            //Console.WriteLine("_____________________________________________");

            //Console.WriteLine($"The Hashcode Is ---> {book1.GetHashCode()}");

            //Console.WriteLine("_____________________________________________");

            //Console.WriteLine($"The Type Is ----> {book1.GetType}");
            #endregion

            #region
            //Look at the line below.Is it a compile - time error, a runtime error, or a logical error? Fix it.
            // int pages = "464"; ------> exception Error(compile - time error)
            // Fixes:

            //int pages = 464;
            //Console.WriteLine(pages);

            //Console.WriteLine("---------------------------------------");
            #endregion

            #region
            //Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by zero", and then prints "Done" in a finally block.
            //try
            //{

            //    Console.WriteLine("Enter U First Number :");
            //    int intput1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter U Second Number :");
            //    int intput2 = int.Parse(Console.ReadLine());

            //    int result = intput1 / intput2 ;
            //    Console.WriteLine($"The Result Is {result}");
            //}
            //catch
            //{
            //    Console.WriteLine("Cannot divide by zero");
            //}
            //finally
            //{

            //    Console.WriteLine("Done");
            //}
            #endregion

            #region

            //Declare an int pages = 300; then store it in a double variable without using a cast.

            //int pages = 300;
            //double doubleDataType = pages;
            //Console.WriteLine(doubleDataType);

            //Declare a double price = 49.99; then convert it into an int using a cast.

            //double price = 49.99;
            //int inttype = (int)price;
            //Console.WriteLine(inttype);

            //Given string pagesText = "464";, convert it into an int using the Convert class.

            //string pagesText = "123";
            //int numbers = Convert.ToInt32(pagesText);
            //Console.WriteLine(numbers);

            #endregion

            #region

            //Given string yearText = "2023";, convert it using int.Parse().Then given string badText = "abc";, use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.

            //int.parse()

            //string yearText = "2023";
            //int year = int.Parse(yearText);
            //Console.WriteLine($"The Result Is {year}");

            //int.Tryparse()

            //string badText = "123";

            //int number;
            //bool success = int.TryParse(badText, out number);

            //if (success)
            //{
            //    Console.WriteLine(number);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid number");
            //}


            //Given int pages = 464;, convert it into a string using ToString() and print its type using GetType() to prove it's now a string.

            //int pages = 464;
            //string results = pages.ToString();
            //Console.WriteLine(results.GetType);

            //Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int variable, and print both.

            //int copies = 100;
            //object obg = copies;
            //Console.WriteLine(obg);   //boxing
            //Console.WriteLine("-------------------------");
            //int copies2 = (int)obg;  //unboxing

            #endregion

            #region

            //Declare an int? year = null;. Print whether it has a value, then assign it 2023 and print its value.

            //int? year = null;
            //Console.WriteLine(year);       // Nullable
            //year = 123;
            //Console.WriteLine(year);


            //Declare a string? reviewer = null;. Print whether it is null.

            //string? reviewer = null;
            //Console.WriteLine(reviewer == null);



            #endregion

        }

    }
    }

