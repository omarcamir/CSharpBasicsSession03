using System;
namespace CSharpBasicsSession03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1- ToUpper
            string title = "clean code";
            string UpperTitle = title.ToUpper();

            Console.WriteLine($"title: {title} | UpperTitle: {UpperTitle}");

            #endregion

            #region 2- ReferenceEquals()
            string str1 = "Clean Code";
            string str2 = "Clean Code";

            bool isTheSameObj = object.ReferenceEquals(str1, str2);
            Console.WriteLine($"is the same obj: {isTheSameObj}");
            

            #endregion

            #region 3- StringBuilder, Append()


            #endregion

            #region 4- StringBuilder , Replace()


            #endregion

            #region 5- String Concatenation


            #endregion

            #region 6- String Interpolation


            #endregion

            #region 7- string.Format()


            #endregion

            #region 8-  if / else

            int pages = 464;
            if (pages > 300)
            {
                Console.WriteLine("Long Book");
            }
            else
            {
                Console.WriteLine("Short Book");

            }


            #endregion

            #region 9-  Logical Operator(&&)
            int BookPages = 464; 
            bool isAvailable = true;

            if (BookPages > 300 && isAvailable)
            {
                Console.WriteLine("You can borrow this book");
            }


            #endregion

            #region 10- switch

            title = "Refactoring";

            switch(title)
            {
                case "Clean Code":
                        Console.WriteLine("Great choice!");
                        break;
                case "Refactoring":
                        Console.WriteLine("Nice pick!");
                        break;
                default:
                    Console.WriteLine("Never heard of it");
                    break;

            }



            #endregion

            #region 11- the ternary operator
            int BPages = 464;
            string sizeLabel = BPages > 300 ? "Long Book" : "Short Book";

            Console.WriteLine($"sizeLabel: {sizeLabel}");



            #endregion


            #region 12- for loop

            Console.WriteLine($"\nFor Loop");
            string[] loopBooks = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            for (int i = 0; i < loopBooks.Length; i++)
            {
                Console.WriteLine($"{i + 1} . {loopBooks[i]}");
            }


            #endregion


            #region 13- while loop

            Console.WriteLine($"\nWhile Loop");


            int x = 0;

            while (x < loopBooks.Length)
            {
                Console.WriteLine($"{x + 1} . {loopBooks[x]}");
                x++;

            }


            #endregion


            #region 14- 


            #endregion


            #region 15- 


            #endregion


            #region 16- 


            #endregion


            #region 17- 


            #endregion


            #region 18- 


            #endregion


            Console.ReadKey();


        }
    }
}
