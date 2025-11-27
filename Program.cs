namespace WhileNesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //tuleb kasutada while ja omakorda while sisse panna
            //while nesting
            //while kordab ennast 5 korda
            Console.WriteLine("While nesting");

            int a = 1;

            while (a <= 1251235345)
            {

                int b = 1;
                while (b <= 1124123453)

                {
                    Console.Write(b + " ");
                    b++;
                }
                Console.WriteLine();
                a++;
            }
        }
    }
}
