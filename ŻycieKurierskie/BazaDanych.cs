using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ŻycieKurierskie
{
    class BazaDanych
    {
        static public List<User> uzytkownicy = new List<User>();
        static public List<Package> paczki = new List<Package>();

        public static void dodajPaczke(Package paczka)
        {
            paczki.Add(paczka);
        }

        public static void dodajUzytkownika(User uzytkownik)
        {
            uzytkownicy.Add(uzytkownik);
        }

        public static User zaloguj(string login, string password)
        {
            foreach (User uzytkownik in uzytkownicy)
            {
                if (uzytkownik.login == login && uzytkownik.password == password)
                {
                    return uzytkownik;

                }

            }

            System.Console.WriteLine("Bledne dane");
            return null;
        }

        static public bool sprawdzLogin(string login)
        {
            foreach (User uzytkownik in uzytkownicy)
            {
                if (uzytkownik.login == login)
                {
                    System.Console.WriteLine("login zajety");
                    return true;
                }               
            }
            return false;
        }

        static public bool sprawdzHaslo(string password)
        {
            foreach (User uzytkownik in uzytkownicy)
            {
                if (uzytkownik.password == password)
                {
                    System.Console.WriteLine("haslo zajete");
                    return true;
                }
            }
            return false;
        }


        static public bool sprawdzEmail(string email)
        {
            foreach (User uzytkownik in uzytkownicy)
            {
                if (uzytkownik.email == email)
                {
                    System.Console.WriteLine("email zajety");
                    return true;
                }
            }
            return false;

        }

        static public Package znajdzPaczke(int _packageID)
        {
            foreach (Package paczka in paczki)
            {
                if (paczka.packageID == _packageID)
                {
                    return paczka;
                }
            }

            System.Console.WriteLine("nie znaleziono paczki");
            return null;


        }

    }
}
