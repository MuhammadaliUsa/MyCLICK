namespace MyCalculator
{
    internal class Program
    {
        static void Menyu()
        {
            Console.WriteLine("1>To'lovlar");
            Console.WriteLine("2>Balans");
            Console.WriteLine("3>O'tkazmalar");
            Console.WriteLine("4>Hamyon");
            Console.WriteLine("5>Sozlash");
            Console.WriteLine("6>Avtoto'lov");
            Console.WriteLine("7>Internet-paketlar");
            Console.WriteLine("8>Zakot,Fitr va boshqalar");
            Console.WriteLine("9>Dtm uchun to'lov");
            Console.WriteLine();
            Console.Write("Kerakli bo'limni tanglang: ");
        }
        static void Bolim01()
        {
            Console.WriteLine("1>Uyali aloqo");
            Console.WriteLine("2>Internet");
            Console.WriteLine("3>Web-sayitlar");
            Console.WriteLine("4>Tv va Telefon");
            Console.WriteLine("5>Kommunal");
            Console.WriteLine("6>Davlat xizmatlari va GAI");
            Console.WriteLine("7>Kredit qaytarish");
            Console.WriteLine("8>Xayriya");
            Console.WriteLine("9>Xalqaro to'lov");
            Console.WriteLine();
            Console.WriteLine("0>Ortga");
        }
        static void Bolim03()
        {
            Console.WriteLine("1>Pul yuborish");
            Console.WriteLine("2>Pul o'tkazish so'rovi");
            Console.WriteLine("3>O'tkazmalar tarixi");

            Console.WriteLine();
            Console.WriteLine("0>Ortga");
        }
        static void Bolim04()
        {
            Console.WriteLine("1>Hamyon yaratish");
            Console.WriteLine("2>Hamyon bu nima");
            Console.WriteLine("3>Tariflar");
            Console.WriteLine("4>Hamyon raqami");
            Console.WriteLine();
            Console.WriteLine("0>Ortga");
        }
        static void Bolim05()
        {
            Console.WriteLine("1>CLICK-PIN o'zgartirish");
            Console.WriteLine("2>CLICK-PIN yangilash");
            Console.WriteLine("3>Ma'lumotlar");
            Console.WriteLine();
            Console.WriteLine("0>Ortga");
        }

        static void Main(string[] args)
        {
            int bolim, bolim1, bolim3, bolim4, bolim5, password = 12345;
        Start:
            Console.Clear();
            Menyu();

            int.TryParse(Console.ReadLine(), out bolim);
            if (bolim>9||bolim<0)
            {
                Console.Clear();
                Console.WriteLine("Bunday bo'lim yoq!");
                return;
            }

            switch (bolim)
            {
                case 1:
                    Console.Clear();
                    Bolim01();
                    Console.WriteLine();
                    Console.Write("Kerakli bo'limni tanglang: ");
                    int.TryParse(Console.ReadLine(), out bolim1);
                    switch (bolim1)
                    {
                        case 0:

                            goto Start;

                        case 1:
                            Console.Clear();
                            Console.WriteLine("Telefon raqamini operator kodi bilan tering ");
                            Console.WriteLine("(Beeline,Uccel,Perfectum,Uzmobile,MOBIUZ,UMS)");
                           string phoneNumber;
                            Start5:
                            phoneNumber = Console.ReadLine();
                            if (phoneNumber.Length>=13)
                            {
                                Console.Clear();
                                Console.WriteLine("To'lov miqdorini kiriting");
                                int value;
                                int.TryParse(Console.ReadLine(), out value);
                                Console.Clear();
                                Console.WriteLine($"{phoneNumber} raqamiga {value} pul miqdori muaffaqiyatli o'tkazildi");

                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Yaroqli telefon raqamini kiriting!");
                                
                                goto Start5;
                               
                            }
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Wife xisob raqamini kiriting:");
                            string wifeNumber;
                        Start6:
                            wifeNumber = Console.ReadLine();
                            if (wifeNumber.Length >= 12)
                            {
                                Console.Clear();
                                Console.WriteLine("To'lov miqdorini kiriting");
                                int wifeValue;
                                int.TryParse(Console.ReadLine(), out wifeValue);
                                Console.Clear();
                                Console.WriteLine($"{wifeNumber}  xisob raqamiga {wifeValue} pul miqdori muaffaqiyatli o'tkazildi");

                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Yaroqli xisob raqamini kiriting!");

                                goto Start6;

                            }
                            break;
                            break;
                        default:
                            Console.WriteLine("Hali bu bo'lim ishga tushmadi!");
                            break;

                    }
                    break;
                case 2:
                    Console.Clear();

                Start1:
                    Console.Write("Parolni kiriting:");
                    int.TryParse(Console.ReadLine(), out password);

                    if (password == 12345)
                    {
                        Console.Clear();
                        Console.WriteLine("Xisobingiz:300$");

                    }

                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Parol xato!");
                        Console.WriteLine("Qaytadan urinib ko'ring!");
                        goto Start1;
                    }
                    break;

                case 3:
                    Console.Clear();
                    Bolim03();
                    Console.WriteLine();
                    Console.Write("Kerakli bo'limni tanglang: ");
                    int.TryParse(Console.ReadLine(), out bolim3);
                    switch (bolim3)
                    {
                        case 0:
                            goto Start;
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Mablag'ni qabul qiluvchining telefon yoki karta/hamyon raqamini kiriting:");
                            string cardNumber;
                        Start7:
                            cardNumber = Console.ReadLine();
                            if (cardNumber.Length >= 13)
                            {
                                Console.Clear();
                                Console.WriteLine("To'lov miqdorini kiriting");
                                int cardValue;
                                int.TryParse(Console.ReadLine(), out cardValue);
                                Console.Clear();
                                Console.WriteLine($"{cardNumber} kartasiga {cardValue} pul miqdori muaffaqiyatli o'tkazildi");

                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Yaroqli karta raqamini kiriting!");

                                goto Start7;

                            }
                            break;
                            //break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Mablag' tushadigan karta");
                            Console.WriteLine("1>Kartalar ro'yxati");
                            Console.WriteLine("2>Boshqa karta");
                            Console.WriteLine();
                            Console.WriteLine("0>Ortga");
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Jo'natmalar tarixi");
                            Console.WriteLine("1>Kutilmoqda");
                            Console.WriteLine("2>Jo'natilgan");
                            Console.WriteLine();
                            Console.WriteLine("0>Ortga");
                            break;

                    }

                    break;
                case 4:
                    Console.Clear();
                    Bolim04();
                    Console.WriteLine();
                    Console.Write("Kerakli bo'limni tanglang: ");
                    int.TryParse(Console.ReadLine(), out bolim4);
                    switch (bolim4)
                    {
                        case 0:
                            goto Start;
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Sizda hamyon yaratilgan!");
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Hamyon kartangiz bo'lmasa ham CLICK orqali to'lovlarni amalga oshirishga yordam beradi.");
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Kartadan hamyonga o'tkazma-0%");
                            Console.WriteLine("Hamyonlar orasida o'tkazma-0.5% ");
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("Sizning hamyoningiz raqami");
                            Console.WriteLine("8800457899566");
                            break;


                    }

                    break;
                case 5:
                Start2:
                    Console.Clear();
                    Bolim05();
                    Console.WriteLine();
                    Console.Write("Kerakli bo'limni tanglang: ");
                    int.TryParse(Console.ReadLine(), out bolim5);
                    switch (bolim5)
                    {
                        case 0:
                            goto Start;
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Avvalgi CLICK-PIN ni kiriting");
                            Console.WriteLine();
                            Console.WriteLine("0>Ortga");
                            Start3:
                            int oldPassword;
                            int.TryParse(Console.ReadLine(), out oldPassword);
                            if (oldPassword == 12345)
                            {
                                Console.Clear();
                                Console.WriteLine("Yangi parolni kiriting");
                                int newPassword;
                                int.TryParse(Console.ReadLine(), out newPassword);
                                Console.Clear();
                                Console.WriteLine("Yangi parol muaffaqiyatli o'rnatildi!!!");

                            }

                            else
                            {
                                Console.Clear();
                                Console.WriteLine("CLICK-PIN noto'g'ri terilgan,iltimos qaytadan tering!");
                               
                                goto Start3;
                            }
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("CLICK-PIN almashtirilganda barcha kartangiz CLICKdan o'chiriladi");
                            Console.WriteLine();
                            Console.WriteLine("1>Tasdiqlash");
                            Console.WriteLine();
                            Console.WriteLine("0>Ortga");
                            int confirmCode;
                            int.TryParse(Console.ReadLine(),out confirmCode);
                            if (confirmCode==1)
                            {  Console.Clear(); 
                                Console.WriteLine("Kartangiz CLICKdan o'chirildi");
                            }
                            if (confirmCode==0)
                            {
                                goto Start;
                            }
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("CLICK-PIN bu siz uchun eng muhim bo'lgan kodlardan biri xisoblanadi!");
                            break;

                    }
                    break;


                default:
                    Console.WriteLine("Hali bu bo'lim ishga tushmadi!");

                    break;
            }
        }
    }
}
