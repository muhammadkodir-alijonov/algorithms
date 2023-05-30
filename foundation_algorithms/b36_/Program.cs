using System;
using System.Data;

namespace c9_f33;
public class Program
{
    static void Main(string[] args)
    {
        /*//c9: Foydalanuvchi harf kiritadi. Agar shu harf 
        //-kichik bo'lsa "kichik harf"
        //- katta bo'lsa "katta harf"

        char harf = char.Parse(Console.ReadLine());

        if (char.IsLower(harf))
        {
            Console.WriteLine("kichik harf");
        }
        else if (char.IsUpper(harf))
        {
            Console.WriteLine("katta harf");
        }
        else
        {
            Console.WriteLine("Bu belgi harf emas");
        }*/


        /*//d2: 20 dan 420 gacha bo'lgan sonlar ichida 5 ga bo'linadigan
        //lekin 10 ga bo'linmaydigan sonlar ekranga chiqaring:
        int son = 20;

        while (son <= 420)
        {
            if (son % 5 == 0 && son % 10 != 0)
            {
                Console.WriteLine(son);
            }
            son++;
        }*/


        /*//d?: n son kritilsin va shu n gacha bo'lgon sonlar kvadrati chiqazilsin:
        Console.WriteLine("Son kriitng:");
        int son = int.Parse(Console.ReadLine());
        for (int i = 1; i <= son; i++)
        {
            Console.WriteLine(i*i);
        }*/


        /*//d12:Foydalanuvchi butun son kiritadi(musbat ham manfiy ham bo'lishi mumkin).
        //Shu son nechta raqamdan tashkil topganligini ekranga chiqaring
        // 1-chi usul
        Console.Write("Butun son kiriting: ");
        int number = int.Parse(Console.ReadLine());
        string numberString = number.ToString();
        Console.WriteLine("Son {0} raqamdan tashkil topgan", numberString.Length);*/

        /*//D13: Foydalanuvchi a va b sonlarning kiritadi(b har doim a dan katta kiritiladi).
        //a dan b gacha bo'lgan sonlar yig'indisini toping
        Console.WriteLine("sonlarni kiriting");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int sum = 0;
        if (a < b)
        {
          while(a<=b)
            {
                sum += a;
                a++;
            }
            Console.WriteLine(sum);
        }*/


        /*//D14:Foydalanuvchi nomanfiy son kiritadi. Shu sonning raqamlari yig'indisini toping.

        Console.WriteLine("Son kriitng: ");
        int son = int.Parse(Console.ReadLine());
        int sum = 0;
        while(son != 0)
        {
            sum = sum + son % 10;
            son/=10;
        }
        Console.WriteLine(sum);*/


        //Foydalanuvchi nomanfiy son kiritadi. Shu sonning (chapdan) 1chi
        //raqamini ekranga chiqaring.
        // 1-chi usul:
        //Console.WriteLine("Son kritng: ");
        //int son = int.Parse(Console.ReadLine());
        //string sonString = son.ToString();
        //Console.WriteLine(sonString.First());


        /*//D17:Foydalanuvchi natural son kiritadi.
        //Shu sonning birinchi va oxirgi raqamlari ni taqqoslab kattasini ekranga chiqaring.

        Console.WriteLine("Son kriting: ");
        int son = int.Parse(Console.ReadLine());
        int ohirgiRaqam = 0;
        ohirgiRaqam = ohirgiRaqam + son % 10;
        while(son > 0)
        {
            son /= 10;
        }
        if (son > ohirgiRaqam) Console.WriteLine(son);
        else Console.WriteLine(ohirgiRaqam);*/


        /*//D18:Foydalanuvchi a(butun son) va b(natural son) sonlarni kiritadi.
        //(a - b) dan(a + b) gacha bo'lgan barcha sonlarni ekranga chiqaring.

        Console.WriteLine("Sonlarni kriting: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = a - b;
        int d = a + b;
        for (int i = c; i <= d; i++)
        {
            Console.WriteLine(i);
        }*/


        /*//D19: Foydalanuvchi n natural son kiritadi.
        //1 dan n gacha bo'lgan sonlarning ko'paytmasini toping (ya'ni n! ni toping)

        Console.WriteLine("Sonlarni kriting: ");
        int n = int.Parse(Console.ReadLine());
        int c =1;
        int son = 1;
        while (son<=n)
        {
            c *= son;
            son++;
        }
        Console.WriteLine(c);*/


        /*//D20: Foydalanuvchi butun son kiritadi (manfiy ham bo'lishi mumkin).
        //Shu sonni teskari tartibda o'ziga o'zlashtiring.
        Console.WriteLine("Son kriting: ");
        int son  = int.Parse(Console.ReadLine());
        int number = 0;
        while(son != 0)
        {
            number = number * 10 + son % 10;
            son /= 10;
        }
        Console.WriteLine(number);*/


        /*//D22:Foydalanuvchi natural son kiritadi. Shu sonning natural bo'luvchilarini toping:
        Console.Write("Natural sonni kiriting: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Natural bo'luvchilar:");
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                Console.WriteLine(i);
            }
        }*/


        /*//Foydalanuvchi kiritgan natural sonni tub ekanligini aniqlang.
        //Note: bo'luvchisi 2 ta bo'lgan sonlar tub sonlar deyiladi.
        Console.Write("Natural sonni kiriting: ");
        int number = int.Parse(Console.ReadLine());
            //if(number /number == 1 && number / 1 ==)
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(false);
                }
                else { Console.WriteLine(true); }
            }*/

        /*//D24:Foydalanuvchi nomanfiy son kiritadi. Shu sonda har
        //bitta raqam necha martadan ishtirok etganini ekranga chiqaring
        Console.Write("Natural sonni kiriting: ");
        int number = int.Parse(Console.ReadLine());
        if (number == 0)
        {
            Console.WriteLine(1);
        }

        int count = 0;

        while (number != 0)
        {
            count++;
            number /= 10;
        }
        Console.WriteLine(count);*/


        //D26:Foydalanuvchi butun son kiritadi. Shu sonning birinchi va oxirgi raqamini almashtirib qo'ying
        //int number = int.Parse(Console.ReadLine());

        //int lastDigit = number % 10;
        //int firstDigit = number;

        //int numberOfDigits = (int)Math.Floor(Math.Log10(number)) + 1;
        //int divisor = (int)Math.Pow(10, numberOfDigits - 1);

        //firstDigit /= divisor;

        //number %= divisor;
        //number /= 10;

        //int newNumber = lastDigit * divisor + number * 10 + firstDigit;

        //Console.WriteLine("Natija: " + newNumber);


        /*// D28:
        int n = int.Parse(Console.ReadLine());
        int count = 0;
        int number = 2;

        while (count < n)
        {
            bool isPrime = true;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                count++;
                if (count == n)
                {
                    Console.WriteLine(number);
                    break;
                }
            }

            number++;
        }*/


        ////E1: 15 dan 25 gaacha bo'lgan sonlarni chiqazing do while bilan:
        //Console.WriteLine("Sonlarni kriting: ");
        //int number1 = int.Parse(Console.ReadLine());
        //int number2 = int.Parse(Console.ReadLine());
        //do
        //{
        //    Console.WriteLine(number1++);
        //}
        //while (number1 <= number2);



        ////E1: 50 dan 100 gaacha bo'lgan sonlarni chiqazing do while bilan:
        //Console.WriteLine("Sonlarni kriting: ");
        //int number1 = int.Parse(Console.ReadLine());
        //int number2 = int.Parse(Console.ReadLine());
        //do
        //{
        //    Console.WriteLine(number1);
        //    number1 += 2;

        //}
        //while (number1 <= number2);


        ////E3: 78 dan 32 gacha bo'lgan sonlarni ekranga chiqaring (kamayish tartibida).
        //Console.WriteLine("Sonlarni kriting: ");
        //int number1 = int.Parse(Console.ReadLine());
        //int number2 = int.Parse(Console.ReadLine());
        //do
        //{
        //    Console.WriteLine(number1);
        //    number1--;

        //}
        //while (number1 >= number2);


        ////e5: a dan b gacha bo'lgan sonlarni toqlarini chiqaring:
        //Console.WriteLine("Sonlarni kriting: ");
        //int a = int.Parse(Console.ReadLine());
        //int b = int.Parse(Console.ReadLine());
        //do
        //{
        //    if (!(a % 2 == 0)) Console.WriteLine(a);
        //    a++;
        //}
        //while (a <= b);


        ////F29: 2 dan 19 gacha bo'lgan sonlar ichidan 3 ga bo'linadiganlari ko'paytmasini toping:
        //Console.WriteLine("Sonlarni kriting: ");
        //int a = int.Parse(Console.ReadLine());
        //int b = int.Parse(Console.ReadLine());
        //int sum = 1;
        //while (a <= b)
        //{
        //    if(a%3 ==0)
        //    {
        //        sum *= a;
        //    }
        //    a++;   
        //}
        //Console.WriteLine(sum);


        ////F30:Foydalanuvchi a son kiritadi. Shu sonni 2 baravarigacha bo'lgan
        ////sonlarni ekranga chiqaring.
        //Console.WriteLine("Son kriting: ");
        //int number = int.Parse(Console.ReadLine());
        //int i = number;
        ////for (int i = number; i <= 2*number; i++)
        ////{
        ////    Console.WriteLine(i);
        ////}
        //while (i <= 2 * number)
        //{
        //    Console.WriteLine(i);
        //    i++;
        //}


        ////F33:Foydalanuvchi 2 ta son kiritadi.Shu sonlarning ayirmasidan modul oling.
        //Console.WriteLine("Sonlarni kriitng: ");
        //int a = int.Parse(Console.ReadLine());
        //int b = int.Parse(Console.ReadLine());
        //Console.WriteLine(Math.Abs(a-b));


        

    }
}