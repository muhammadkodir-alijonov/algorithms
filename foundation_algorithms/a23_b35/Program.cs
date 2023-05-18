using System;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Xml;

namespace a24_a34;

public class Program
{
    static void Main(string[] args)
    {
        /*//a23: Foydalanuvchi "nechi oy" o'tganini kiritadi. Siz esa yil bo'lishga yetmay qolgan oylar sonini toping
        Console.WriteLine("Oy raqamini kiriting :");
        int oy = Convert.ToInt32(Console.ReadLine());
        int qolgan_oy, yill;
        yill = oy / 12 + 1;
        qolgan_oy = 12 - (oy % 12);
        Console.WriteLine("qolgan oy : "+ qolgan_oy +" Yill: " + yill);*/



        /*//a24: A24:Agar men o'ng tomonga 360 gradus burilsam yana dastlabki holatga kelib qolaman. Agar, 400 gradus burilsam, dastlabki holatimga ko'ra 40 gradus burilgan bo'laman.
        //Endi masala: Foydalanuvchi necha gradus burilganini kiritadi.Siz esa uning dastlabki turgan holatiga nisbatadan necha gradus burilganini toping.

        Console.WriteLine("Nech gardusga buruldingiz: ");
        int burulingan_gradurs = int.Parse(Console.ReadLine());
        int gradus;
        if (burulingan_gradurs < 360) Console.WriteLine($"Siz {burulingan_gradurs} gradusga buruldingiz");
        else
            if (burulingan_gradurs == 360) Console.WriteLine("Siz datlabki nuqtaga keldingiz");
        else
            if (burulingan_gradurs > 360)
        {
            gradus = burulingan_gradurs%360;
            Console.WriteLine($"siz dastlabki nuqtadan {gradus} ga buruldingiz");
        }
        Main(args);*/



        //a25: Foydalanuvchi 3 xonali son kiritadi. Shu sonni teskari tartibda o'ziga o'zlashtiring
        // 1-chi usul:
        /*Console.WriteLine("Sonni kiriting:");
        string son = Console.ReadLine();
        char[] chars = son.ToCharArray();
        Array.Reverse(chars);
        string teskariSon = new string(chars);
        Console.WriteLine("Teskari tartibdagi son: {0}", teskariSon);*/
        //2-chi usuli.
        /*Console.WriteLine("Son kriting: ");
        int son = int.Parse(Console.ReadLine());
        int sum=0, qoldiq;
        while (son != 0)
        {
            qoldiq = son % 10;
            sum = sum * 10 + qoldiq;
            son /=10;
        }
        Console.WriteLine(sum);*/


        /*//B1: Foydalanuvchi 3 ta son kiritadi. Agar shu sonlar uchburchakning tomonlari bo'la olsa "Bunday uchburchak mavjud"
        //degan yozuvni ekranga chiqaring, aks holda "bunday uchburchak yo'q" degan yozuvni ekranga chiqaring. 
        Console.WriteLine("Uchburchak tomonlarini kiriting: a=> b=> c=> ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        if (a + b > c && b + c > a && c + a > b) Console.WriteLine("Uchburchak bo'la oladi.");
        else Console.WriteLine("Bunday uchburchak yo'q");*/


        /*//B8:Foydalanuvchi secondlarni kiritadi.Siz esa uni to'liq necha minut bo'lishini ekranga chiqaring
        Console.WriteLine("Sekundlarni kriting: ");
        int secund = int.Parse(Console.ReadLine());
        int toliq_minut = 0;
        toliq_minut = secund / 60;
        Console.WriteLine(toliq_minut);*/


        /*//B9:Foydalanuvchi secondlarni kiritadi.Siz esa uni to'liq necha soat bo'lishini ekranga chiqaring
        Console.WriteLine("Sekundlarni kriting: ");
        int secund = int.Parse(Console.ReadLine());
        int soat = 0;
        soat = (secund / 60)/60;
        Console.WriteLine(soat);*/

        /*//B11: Foydalanuvchi 3 xonali son kiritadi. Shu sonning raqamlari yig'indisini toping.
        Console.WriteLine("Son kriting: ");
        int son = int.Parse(Console.ReadLine());
        int sum = 0;
        while(son != 0)
        {
            int qoldiq = son %10;
            sum += qoldiq;
            son /= 10;
        }
        Console.WriteLine(sum);*/


        /*//B12: B12: Foydalanuvchi 5 ta son kiritadi, shu sonlarning eng kattasini ekranga chiqaring.
        Console.WriteLine("5 ta son kriting: ");
        int[] sonlar = new int[5];

        Console.WriteLine("Iltimos, 5 ta son kiriting:");

        int engKatta = int.MinValue;

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Son {0}: ", i + 1);
            sonlar[i] = int.Parse(Console.ReadLine());

            if (sonlar[i] > engKatta)
            {
                engKatta = sonlar[i];
            }
        }

        Console.WriteLine("Eng katta son: " + engKatta);*/


        //B13: Foydalanuvchi 6 xonali son kiritadi.Shu sonning eng katta raqamini ekranga chiqaring:
        /*Console.WriteLine("Iltimos, 6 xonali bir son kiriting:");
        int son = int.Parse(Console.ReadLine());
        int engKattaRaqam = son % 10;
        for (int i = 1; i < 6; i++)
        {
            son /= 10;
            int raqam = son % 10;
            if (raqam > engKattaRaqam)
            {
                engKattaRaqam = raqam;
            }
        }
        Console.WriteLine("Eng katta raqam: " + engKattaRaqam);*/


        /*//B14: Foydalanuvchi hafta kuni raqamini kiritadi
        //Agar 1 kiritsa->Dushanba chiqsin
        //Agar 2 kiritsa->Seshanba chiqsin
        //Agar 3 kiritsa->Chorshanba chiqsin
        //Agar 4 kiritsa->Payshanba chiqsin
        //Agar 5 kiritsa->Juma chiqsin
        //Agar 6 kiritsa->Shanba chiqsin
        //Agar 7 kiritsa->Yakshanba chiqsin

        //aks holda->Bunday kun yo'q chiqsin
        Console.WriteLine("Sonkriting: ");
        int kun = int.Parse(Console.ReadLine());

        switch (kun)
        {
            case 1:
                Console.WriteLine("Dushanba"); break;
            case 2:
                Console.WriteLine("Seshanba"); break;
            case 3:
                Console.WriteLine("Chorshanba"); break;
            case 4:
                Console.WriteLine("Payshanba"); break;
            case 5:
                Console.WriteLine("Juma"); break;
            case 6:
                Console.WriteLine("Shanba"); break;
            case 7:
                Console.WriteLine("Yakshanba"); break;
            default:
                Console.WriteLine("Bunday kun yo'q"); break;
        }*/


        //B15:
        //Foydalanuvchi baho kiritadi.Agar bu baho

        //[80 - 100] oraliqda bo'lsa —> ekranga "5" chiqsin
        //[60 - 80] oraliqda bo'lsa —> ekranga "4" chiqsin
        //[40 - 60] oraliqda bo'lsa —> ekranga "3" chiqsin
        //[20 - 40] oraliqda bo'lsa —> ekranga "2" chiqsin
        //aks holda -> "Siz bebahosiz" degan yozuv chiqsin
        //1-susl:
        /*Console.WriteLine("Iltimos, baho kiriting:");
        int baho = int.Parse(Console.ReadLine());
        string natija;
        switch (baho)
        {
            case int n when (n >= 80 && n <= 100):
                natija = "5";
                break;
            case int n when (n >= 60 && n < 80):
                natija = "4";
                break;
            case int n when (n >= 40 && n < 60):
                natija = "3";
                break;
            case int n when (n >= 20 && n < 40):
                natija = "2";
                break;
            default:
                natija = "Siz bebahosiz";
                break;
        }
        Console.WriteLine(natija);*/
        //2-susl:
        /*Console.WriteLine("Iltimos, baho kiriting:");
        int baho = int.Parse(Console.ReadLine());

        if (baho >= 80 && baho <= 100)
        {
            Console.WriteLine("5");
        }
        else if (baho >= 60 && baho < 80)
        {
            Console.WriteLine("4");
        }
        else if (baho >= 40 && baho < 60)
        {
            Console.WriteLine("3");
        }
        else if (baho >= 20 && baho < 40)
        {
            Console.WriteLine("2");
        }
        else
        {
            Console.WriteLine("Siz bebahosiz");
        }*/


        /*//B16:
        //Foydalanuvchi 3 ta qiymat kiritadi:
        //son
        //belgi
        //son
        //Belgining qiymatlar bo'lishi mumking -> +, -, *, /
        //Siz esa, kiritilgan belgiga mos ravishda, 2 ta son o'rtasidagi amalni bajaring.

        Console.WriteLine("son belgilarni kiriting: ");

        int son1 = int.Parse(Console.ReadLine());
        char belgi = char.Parse(Console.ReadLine());
        int son2 = int.Parse(Console.ReadLine());

        int natija = 0;
        switch (belgi)
        {
            case '+':
                natija = son1 + son2;
                break;
            case '-':
                natija = son1 - son2;
                break;
            case '*':
                natija = son1 * son2;
                break;
            case '/':
                natija = son1 / son2;
                break;
            default:
                Console.WriteLine("Noto'g'ri amal belgisi kiritildi.");
                break;
        }
        Console.WriteLine("Natija: " + natija);*/


        /*//B18: Foydalanuvchi 2 ta butunn son kiritadi. Agar bu sonlarning bittasi ikkinchisiga ga bo'linsa "chelsea" degan
        //yozuv chiqarilsin, aks holda "liverpool" degan yozuv ekranga chiqarilsin

        Console.WriteLine("butun son kriitng: ");
        Console.Write("1-chi son:");
        double a = double.Parse(Console.ReadLine());
        Console.Write("2-chi son: ");
        double b = double.Parse(Console.ReadLine());
        if (a%b==0 || b%a ==0) Console.WriteLine("chelsea");
        else Console.WriteLine("liverpul");*/


        /*//B19: Foydalanuvchi butun son kiritadi. Bu son musbat bo'lsa ham manfiy bo'lsa ham,
        //musbat qilib ekranga chiqaring.
        Console.WriteLine("Istalgan son kriting: ");
        int son = int.Parse(Console.ReadLine());

        if (son >= 0)
        {
            Console.WriteLine(son);
        }

        else if(son < 0)
        {
            Console.WriteLine(son * (-1));
        }*/

        /*//B21: Foydalanuvchi float son kiritadi. Agar shu son butun bo'lsa ekranga "butun son"
        //degan yozuvchi chiqaring, aks holda "haqiqiy son" degan yozuvchi chiqaring

        Console.WriteLine("son kriitng: ");
        double raqam = double.Parse(Console.ReadLine());
        if(Math.Round(raqam) != raqam)
        {
            Console.WriteLine("Butun son");
        }
        else
        {
            Console.WriteLine("Haqiqiy son");
        }*/


        /*//B23:Foydalanavchi belgi kiritiladi. Agar shu belgi unli harf bo'lsa ekranga "unli harf" degan yozuvni chiqaring, agar undosh harf kiritgan bo'lsa "undosh harf"
        //degan yozuv chiqaring, aksa holda "bunday harf yo'q" degan yozuvni chiqaring.
        Console.Write("Iltimos, belgini kiriting: ");
        char belgi = char.ToLower(Console.ReadKey().KeyChar);

        if (Char.IsLetter(belgi))
        {
            if (belgi == 'a' || belgi == 'e' || belgi == 'i' || belgi == 'o' || belgi == 'u')
            {
                Console.Write(" Unli harf");
            }
            else
            {
                Console.Write(" Undosh harf");
            }
        }
        else
        {
            Console.Write("Bunday harf yo'q");
        }
        Main(args);*/



        /*//B:25 Foydalanuvchi oy tartib sonini kiritadi. Siz esa shu oyda necha kun borligini toping

        Console.WriteLine("Oy raqamini kiriting: ");
        int oyraqami = int.Parse(Console.ReadLine());

        if (oyraqami == 4 || oyraqami == 6 || oyraqami == 9 || oyraqami == 11) Console.WriteLine(" 30 kun bor");
        else if (oyraqami == 1 || oyraqami == 7 || oyraqami == 8 || oyraqami == 10 || oyraqami == 12) Console.WriteLine("31 kun bor");
        else if (oyraqami == 2) Console.WriteLine("28 kun bor");
        else Console.WriteLine("bir yilda 12 oy bor siz 12 dan yuqori raqam kiritdingiz");
        Main(args);*/
    }
}