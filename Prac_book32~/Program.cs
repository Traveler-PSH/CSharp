namespace Prac_book32_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float f = 5.2f;
            double d = 10.5;
            decimal money = 200.099m;

            Console.WriteLine(f);
            Console.WriteLine(d);
            Console.WriteLine(money);

            char ch = '\u2023';
            Console.WriteLine(ch);

            string text = "\"Hello World\"";
            Console.WriteLine(text);

            String text2 = @"\tHello\nWorld";
            Console.WriteLine(text2);
        }
    }
}
