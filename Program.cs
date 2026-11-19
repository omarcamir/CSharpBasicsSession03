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

        }
    }
}
