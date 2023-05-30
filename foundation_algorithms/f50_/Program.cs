namespace f39_;

public class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.Write("\n");
            for (int j = 1; j <= 10; j++)
            {
                int a = 1;
                if (i>=j)
                {
                    Console.Write("", a++);
                }
                else
                    Console.Write(" ");
            }
            Console.Write("\n");
        }
    }
}
