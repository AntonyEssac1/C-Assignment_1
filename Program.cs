using System.Reflection.Metadata;

namespace C__Session_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            Book book1 = new Book();

            book1.title = "c# programming";
            book1.pages = 512;

            object obj = book1;
            Console.WriteLine($"The Full Namespace is [ {obj} ]");

            Console.WriteLine("_____________________________________________");

            Console.WriteLine($"The Full Namespace is {book1.ToString}");  // ToString Method 

            Console.WriteLine("_____________________________________________");

            Console.WriteLine(book1.Equals(book1)); // True 

            Console.WriteLine("_____________________________________________");

            Console.WriteLine($"The Hashcode Is ---> {book1.GetHashCode()}");

            Console.WriteLine("_____________________________________________");

            Console.WriteLine($"The Type Is ----> {book1.GetType}");
            #endregion


        }
    }
}
