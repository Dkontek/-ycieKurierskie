using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
namespace ŻycieKurierskie
{
    class User
    {
        public int userID;
        public String login;
        public String password;
        public String name;
        public String surname;
        public String address;
        public String city;
        public String email;
        public String phone;

     
        public User()
        {

        }
        public User(string _login, string _password, string _name, string _surname, string _address, string _city, string _email, string _phone)
        {
            if (BazaDanych.uzytkownicy.Count != 0)
                userID = BazaDanych.uzytkownicy[BazaDanych.uzytkownicy.Count - 1].userID + 100;
            else userID = 1;

            login = _login;
            password = _password;
            name = _name;
            surname = _surname;
            address = _address;
            city = _city;
            email = _email;
            phone = _phone;

            BazaDanych.dodajUzytkownika(this);
        }


        public void Register()
        {
            if (BazaDanych.uzytkownicy.Count != 0)
                userID = BazaDanych.uzytkownicy[BazaDanych.uzytkownicy.Count - 1].userID + 100;
            else userID = 1;
            do
            {
                System.Console.WriteLine("Podaj Login");
                login = System.Console.ReadLine();
            } while (BazaDanych.sprawdzLogin(login) == true);

            do
            {
                System.Console.WriteLine("Podaj Hasło");
                password = System.Console.ReadLine();
            } while (BazaDanych.sprawdzHaslo(password) == true);


            System.Console.WriteLine("Podaj Imię");
            name = System.Console.ReadLine();

            System.Console.WriteLine("Podaj Nazwisko");
            surname = System.Console.ReadLine();

            System.Console.WriteLine("Podaj Miasto");
            city = System.Console.ReadLine();

            System.Console.WriteLine("Podaj Adres");
            address = System.Console.ReadLine();

            do
            {
                System.Console.WriteLine("Podaj E-Mail");
                email = System.Console.ReadLine();

            } while (BazaDanych.sprawdzEmail(email) == true);











            Console.WriteLine("Twoje dane:");





            System.Console.WriteLine(name);
            System.Console.WriteLine(surname);
            System.Console.WriteLine(city);
            System.Console.WriteLine(address);
            System.Console.WriteLine(email);
            System.Console.WriteLine(login);
            System.Console.WriteLine(password);




            BazaDanych.dodajUzytkownika(this);




        }

        public void userLogin()

        {
            User uzytkownik = null;
            do
            {
                System.Console.WriteLine("podaj login");
                string templogin = System.Console.ReadLine();
                System.Console.WriteLine("podaj haslo");
                string temppassword = System.Console.ReadLine();



                uzytkownik = BazaDanych.zaloguj(templogin, temppassword);


            } while (uzytkownik == null);


            this.login = uzytkownik.login;
            this.password = uzytkownik.password;
            this.name = uzytkownik.name;
            this.surname = uzytkownik.surname;
            this.address = uzytkownik.address;
            this.city = uzytkownik.city;
            this.email = uzytkownik.email;
            this.phone = uzytkownik.phone;

            Console.WriteLine("Twoje dane:");



            System.Console.WriteLine(name);
            System.Console.WriteLine(surname);
            System.Console.WriteLine(city);
            System.Console.WriteLine(address);
            System.Console.WriteLine(email);
            System.Console.WriteLine(login);
            System.Console.WriteLine(password);

        }


        public void nadajPaczke()
        {
            Package paczka = new Package(this);
        }

        public void znajdzPaczke()
        {
            System.Console.WriteLine("podaj ID paczki");
            int packageID = Int32.Parse(System.Console.ReadLine());

            Package paczka = BazaDanych.znajdzPaczke(packageID);
           if(paczka!=null) paczka.checkStatus();

            System.Console.WriteLine("czy chcesz zmienic status paczki? \n 1. Tak\n 2.Nie\n");
            int j = Int32.Parse(System.Console.ReadLine());
            if (j == 1) paczka.changeStatus();


        }


        public void pokazMojePaczki()
        {

            System.Console.WriteLine("Twoje paczki: ");
            System.Console.WriteLine("ID:\t\t\t Imie:\t\t\t Nazwisko:\t\t\t telefon:\t\t\t adres:\t\t\t email:\t\t\t status:\t\t\t");
            foreach (Package paczka in BazaDanych.paczki)
            {
                if (paczka.nadawca.login == this.login)
                {
                    System.Console.WriteLine("{0}\t\t\t {1}\t\t\t {2}\t\t\t {3}\t\t\t {4}\t\t\t {5}\t\t\t {6}\t\t\t",paczka.packageID, paczka.Recievername, paczka.Recieversurname, paczka.Recieverphone,paczka.Recieveraddress, paczka.Recieveremail, paczka._checkStatus());

                }

            }
            System.Console.ReadLine();
        }
    }
}
