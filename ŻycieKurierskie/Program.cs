using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ŻycieKurierskie
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("Wiktor11", "Wiktor11", "Wiktor", "Czechowski", "aaaa 11", "Szczecin", "Wiktor@wiktor.pl", "666 666 666");
            User user2 = new User("xd", "xd", "xd", "xd", "xd 11", "Szczecin", "xd@xd.pl", "666 666 666");
            User user3 = new User("Daniel", "Kontek", "xd", "xd", "xd 11", "Szczecin", "xd@xd.pl", "666 666 666");
            System.Console.WriteLine("co chcesz zrobić?");
            System.Console.WriteLine("1. Zarejestruj");
            System.Console.WriteLine("2. Zaloguj");
            User xd = new User();
            int i = Int32.Parse(System.Console.ReadLine());
            if (i == 1)
            {

                xd.Register();

            }
            if (i == 2)
            {

                xd.userLogin();

            }

           


            do
            {
                System.Console.Clear();
                System.Console.WriteLine("co chcesz zrobić?");
                System.Console.WriteLine("1. Znajdz paczke");
                System.Console.WriteLine("2. Nadaj paczke");
                System.Console.WriteLine("3. Pokaz moje paczki");
                System.Console.WriteLine("9. WYJDZ");
                i = Int32.Parse(System.Console.ReadLine());


                if (i == 1)
                {
                    System.Console.Clear();
                    xd.znajdzPaczke();


                }
                if (i == 2)
                {

                    xd.nadajPaczke();

                }
                if (i == 3)
                {

                    xd.pokazMojePaczki();

                }

                if (i == 9)
                {
                    Environment.Exit(0);
                }

            } while (true);
                System.Console.ReadKey();
            System.Console.ReadKey();
            System.Console.ReadKey();


        }
    }
}
