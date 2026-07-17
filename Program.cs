using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;

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


        }
    }
}
