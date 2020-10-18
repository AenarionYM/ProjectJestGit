using System;
using System.Net.Mime;

namespace O.R.K.A._Project_ver._2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Konstruktory Klas//
            Methods methods = new Methods();
            Menu menu = new Menu();
            
            //Eq
            bool kot = false;
            
            //Unlocker'y
            bool dyrkaWBramie = true;
            
            //Achivments
            bool niespostrzezony = false;
            
            //Nagany
            int nagany = 0;
            
            //Wstęp do gry
            Console.WriteLine("Witaj w Project O.R.K.A.!");
            methods.Sleep(350);
            Console.WriteLine("Jest to gra textowa w której wcielasz się w frajera który chodzi do TEB'u");
            methods.Sleep(100);
            Console.WriteLine("Pomiędzy lekcjami spierdoliłeś do Ropuszki po Gorącego Psa z extra SSSOOOSSS");
            methods.Sleep(200);
            Console.WriteLine("Reszte dowiesz(lub też nie) się podczas gry.");
            methods.Sleep(200);
            Console.WriteLine("Miłej zabawy! - Zarząd TEB Studio");
            methods.Ent();
            methods.Clear();
            //Menu
            menu:
            menu._Menu();
            string menuChoice = Console.ReadLine();

            if (menuChoice == "1")
            {
                Console.WriteLine("Zapraszam!");
                methods.Ent();
                methods.Clear();
                goto front;
                
            }
            else if (menuChoice == "2")
            {
                Console.WriteLine("Zapraszam ponownie!");
                methods.Ent();
                methods.Clear();
                goto menu;
            }
            else if (menuChoice == "3")
            {
                Console.WriteLine("No raczej nie");
                methods.Ent();
                methods.Clear();
                goto menu;
            }
            else if (menuChoice == "4")
            {
                Console.WriteLine("No xD");
                methods.Ent();
                methods.Clear();
                goto menu;
            }
            else
            {
                Console.WriteLine("Jak ty głupi");
                methods.Ent();
                methods.Clear();
                goto menu;            
            }

            //Przed budynkiem
            front:
            {
             Console.WriteLine("Stoisz przed głównym budynkiem Technikum TEB Edukacja w Bielsku");
             methods.Sleep(500);
             Console.WriteLine("Co robisz?");
             methods.Sleep(500);
             Console.WriteLine("1. Wchodzisz");
             methods.Sleep(500);
             Console.WriteLine("2. Odchodzisz");
             string choiseToEnter = Console.ReadLine();

             if (choiseToEnter == "1")
             {
                 Console.WriteLine("Oł szit hir łi goł agen");
                 if (dyrkaWBramie == true)
                 {
                     dyrkaWBramie = false;
                     methods.Ent();
                     methods.Clear();
                     Console.WriteLine("Wchodzisz do szkoły");
                     methods.Sleep(1000);
                     goto dyrkaGate;
                 }
                 else
                 {
                     methods.Ent();
                     methods.Clear();
                     goto gate;
                 }
             }
             
             else if (choiseToEnter == "2")
             {
                Console.WriteLine("Patrzysz na szkołę"); 
                methods.Sleep(500);
                Console.WriteLine("*A... Pierdole*");
                methods.Sleep(500);
                Console.WriteLine("Odchodzisz");
                methods.Sleep(500);
                Console.Write(".");
                methods.Sleep(500);
                Console.Write(".");
                methods.Sleep(500);
                Console.Write(".");
                Environment.Exit(1);
             }

             else
             {
                 Console.WriteLine("Dev Log: Jesteś debilem");
                 methods.Sleep(1000);
                 methods.Ent();
                 goto front;
             }
             
            }
            
            //Dyrka w Bramie
            dyrkaGate:
            {
                Random achivmentDyrkaWBramie = new Random();
                int _achivmentDyrkaWBramie = achivmentDyrkaWBramie.Next(100);
                
                if (_achivmentDyrkaWBramie < 95)
                {
                    methods.Sleep(500);
                    Console.WriteLine("Dyrka: A co ty tutaj robisz");
                    methods.Sleep(500);
                    Console.WriteLine("Ty:yyyy...jaa....ni..");
                    methods.Sleep(500);
                    Console.WriteLine("Dyrka: Byłeś w Ropuszce.");
                    methods.Sleep(500);
                    Console.WriteLine("Dyrka: To znaczy nagana");
                    methods.Sleep(500);
                    Console.WriteLine("A teraz WON na lekcje!!!!");
                    methods.Sleep(500);
                    Console.WriteLine("*Dostałeś naganę*");
                    Console.WriteLine("");
                    Console.WriteLine("TIP: Dostałeś naganę, trzy takowe oznaczają koniec gry.");
                    methods.Sleep(500);
                    Console.WriteLine("Stan nagan możesz sprawdzić w ekwipunku");
                    methods.Ent();
                    methods.Clear();
                    methods.Sleep(500);
                }
                else if (_achivmentDyrkaWBramie >= 95)
                {
                    Console.WriteLine("Zostałeś niespostrzeżony");
                    methods.Sleep(500);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Achievement Get: Niespostrzeżony");
                    Console.ResetColor();
                    Console.WriteLine(" ");
                    methods.Ent();
                    niespostrzezony = true;
                    methods.Clear();
                    methods.Sleep(500);
                }
                goto gate;
            }
            
            //Brama
            gate:
            {
                Console.WriteLine("Znajdujesz się w przedsionku");
                methods.Sleep(500);
                Console.WriteLine("Widzisz dwie drogi");
                methods.Sleep(500);
                Console.WriteLine("1. Schody na lewo");
                methods.Sleep(500);
                Console.WriteLine("2. Schody na prawo");
                methods.Sleep(500);
                Console.WriteLine("3. Wyjście");
                methods.Sleep(500);
                Console.WriteLine("4. Ekwipunek");

                string choiseGate = Console.ReadLine();
                
                if (choiseGate == "1")
                {
                    Console.WriteLine("Postanawisz wejść po schodach na lewo");
                    methods.Ent();
                    methods.Clear();
                    methods.Sleep(500);
                    goto groundfloor;
                }
                else if (choiseGate == "2" && kot == false)
                {
                    Console.WriteLine("*Zamknięte*");
                    methods.Sleep(500);
                    Console.WriteLine("Kurwa, dalej niewiem jaki jest ten kod to szatni");
                    methods.Ent();
                    methods.Clear();
                    methods.Sleep(500);
                    goto gate;
                }
                else if (choiseGate == "2" && kot == true)
                {
                    Console.WriteLine("*beep*");
                    methods.Sleep(500);
                    Console.WriteLine("Otwierasz drzwi i schodzisz do Lochów");
                    methods.Ent();
                    methods.Clear();
                    methods.Sleep(500);
                    goto basement;
                }
                else if (choiseGate == "3")
                {
                    Console.WriteLine("Wychodzisz na zewnątrz");
                    methods.Ent();
                    methods.Clear();
                    methods.Sleep(500);
                    goto front;
                }
                else if (choiseGate == "4")
                {
                    //eq do zrobienia
                }
                else
                {
                    methods.els();
                    goto gate;
                }
            }
            
            //Korytarz parter
            groundfloor:
            {
                
            }
            
            //Piwnica
            basement:
            {
                
            }
        }
    }
}