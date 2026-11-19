namespace CSharpBasicsSession03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ToUpper
            string title = "clean code";
            string UpperTitle = title.ToUpper();

            Console.WriteLine($"title: {title} | UpperTitle: {UpperTitle}");

            #endregion

            #region ReferenceEquals()
            string str1 = "Clean Code";
            string str2 = "Clean Code";

            bool isTheSameObj = object.ReferenceEquals(str1, str2);
            Console.WriteLine($"is the same obj: {isTheSameObj}");
            Console.ReadKey();

            #endregion

        }
    }
}
