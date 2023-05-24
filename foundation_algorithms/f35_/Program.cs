
using System.Net.WebSockets;

namespace f35_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////F35: 29 dan 55 gacha bo'lgan sonlar ichidan 6 ga bo'linmaydiganlarini ekranga chiqaring.
            ////CONTINUE bilan ishlansin
            //Console.WriteLine("Sonlarni kriitng: ");
            ////int a = int.Parse(Console.ReadLine());
            //for (int i = 25; i <= 55; i++)
            //{
            //    if (i % 6 != 0)
            //    {
            //        Console.WriteLine(i);
            //        continue;
            //    }
            //}



            ////F36:42 dan 77 gacha bo'lgan sonlar ichidan 3 ga ham 5 ham bo'linmaydiganlari
            ////ekranga chiqarilsin.CONTINUE bilan ishlansin
            //for (int i = 42; i <=77; i++)
            //{
            //    if(i%3 !=0 && i%5 != 0)
            //    {
            //        Console.WriteLine(i);
            //        continue;
            //    }
            //}


            ////F38: 15 dan 22 gacha bo'lgan sonlarni ekranga chiqaring.
            ////Shu sonlarni toqlari o'z holicha ekranga chiqarilsin, va juftlari manfiy bo'lsin.
            //for (int i = 15; i <= 22; i++)
            //{
            //    if(i%2 ==0)
            //    {
            //        Console.WriteLine((-1) * i);
            //    }
            //    else
            //        Console.WriteLine(i);
            //}


            ////F41:Foydalanuvchi n son kiritadi. -n dan n gacha bo'lgan sonlarni ekranga chiqaring.
            ////Agar 0 kiritilsa, 0 ni o'zi chiqsin Masalan:
            //Console.WriteLine("Son kriting: ");
            //int number = int.Parse(Console.ReadLine());

            //for (int i = -number; i <= number; i++)
            //{
            //    Console.WriteLine(i);
            //}


            ////F42:Foydalanuvchi a va b sonlarini kiritadi.
            ////Shu sonlarning kattasidan kichigacha bo'lgan sonlarni ekranga chiqaring
            //Console.WriteLine("Sonlarni kriting: ");
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //if (a > b)
            //{
            //    for (int i = b; i <= a; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //else
            //    if (a < b)
            //{
            //    for (int i = a; i <= b; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            ////F43:Ekranga "O'yinni davom ettirasizmi: [h/y]" degan yozuv chiqsin.
            ////Agar foydalanuvchi h ni bossa, xuddi avvalgi ish bajarilsin
            ////(yani avvalgi savolni yana ekranga chiqarib, jarayon takrorlansin).
            ////Agar Foydalanuvchi y ni bossa dastur tugatilsin

            //Console.WriteLine("O'yinni davom e'ttirasizmi: ");
            //char harf = char.Parse(Console.ReadLine());
            //if (harf == 'h' || harf == 'H')
            //{
            //    Console.WriteLine("O'yinni davom e'ttirasizmi: ");
            //}
            //else
            //    if (harf == 'y' || harf == 'Y')
            //{
            //    Console.WriteLine("Tugaadi: ");
            //}


            ////F44:Foydalanuvchi 2 ta natural son kiritadi. Bu sonlar to'rtburchakning eni
            ////va bo'yi xisoblanadi. Shu to'rtburchakni ekranga chiqaring. Example rasmda berilgan
            //Console.WriteLine("Shakil tomonini kiriting: ");
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= a; i++)
            //{
            //    Console.Write("\n");
            //    for (int j = 1; j <= b; j++)
            //    {
            //        if (i <= 1 || j >= b || j <= 1 || j >= a)
            //        {
            //            Console.Write("*");
            //        }
            //        else Console.Write(" ");
            //    }
            //}



            /*//pattern
            int n = 10;
            for (int i = 0; i <= n; i++)
            {
                Console.Write("\n");
                for (int j = i; j <= n; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; ++j)
                {
                    Console.Write("1 ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();*/

            int n = 10;
            double x = 2.00000;
            if (n == 0)
                Console.WriteLine(1);

            if (n < 0)
            {
                x = 1 / x;
                n = -n;
            }

            double result = 1;
            while (n > 0)
            {
                if (n % 2 == 1)
                    result *= x;

                x *= x;
                n /= 2;
            }
            Console.WriteLine(result);

        }
    }
}