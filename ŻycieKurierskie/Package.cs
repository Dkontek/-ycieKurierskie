using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ŻycieKurierskie
{
    class Package
    {
        public int packageID;

        public User nadawca;
        String[] Status = { "Zarejestrowano","przyjęto","w magazynie","w sortowni","w drodze","w sortowni docelowej","przyjęta do dostarczenia przez kuriera", "dostarczona", "odmowa przyjecia" };

        int currentstatus = 0;

        String Senderlogin;
        String Sendername;
        String Sendersurname;
        String Senderaddress;
        String Sendercity;
        String Senderemail;

        
       public String Recievername;
       public String Recieversurname;
       public String Recieveraddress;
       public String Recievercity;
       public String Recieveremail;
       public String Recieverphone;


        public Package(User uzytkownik)
        {
            if (BazaDanych.paczki.Count != 0)
                packageID = BazaDanych.paczki[BazaDanych.paczki.Count - 1].packageID + 100;

            else packageID = 1;
            nadawca = uzytkownik;

            
            
            /*
            Senderlogin=uzytkownik.login;
            Sendername = uzytkownik.name;
            Sendersurname = uzytkownik.surname;
            Senderaddress = uzytkownik.address;
            Sendercity = uzytkownik.city;
            Senderemail = uzytkownik.city;
            */
            System.Console.WriteLine("Podaj Imię adresata");
            Recievername = System.Console.ReadLine();

            System.Console.WriteLine("Podaj Nazwisko adresata");
            Recieversurname = System.Console.ReadLine();


            System.Console.WriteLine("Podaj Miasto adresata");
            Recievercity = System.Console.ReadLine();

            System.Console.WriteLine("Podaj Adres adresata");
            Recieveraddress = System.Console.ReadLine();

            System.Console.WriteLine("Podaj Email adresata");
            Recieveremail = System.Console.ReadLine();

            System.Console.WriteLine("Podaj telefon adresata");
            Recieverphone = System.Console.ReadLine();

             
            System.Console.WriteLine("ID Twojej paczki: {0}", packageID);
            System.Console.WriteLine("Status: {0}", Status[currentstatus]);

            BazaDanych.paczki.Add(this);

        }

        public void changeStatus()
        {
            System.Console.WriteLine("na jaki status chcesz zmienic?");
            System.Console.WriteLine("0. Zarejestrowano");
            System.Console.WriteLine("1. przyjęto");
            System.Console.WriteLine("2. w magazynie");
            System.Console.WriteLine("3. w sortowni");
            System.Console.WriteLine("4. w drodze");
            System.Console.WriteLine("5. w sortowni docelowej");
            System.Console.WriteLine("6. przyjęta do dostarczenia przez kuriera");
            System.Console.WriteLine("7. dostarczona");
            System.Console.WriteLine("8. odmowa przyjecia");

            currentstatus = Int32.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Status: {0}", Status[currentstatus]);

        }

        public void checkStatus()
        {
            System.Console.WriteLine("Status: {0}", Status[currentstatus]);

        }

              public string _checkStatus()
        {
            return Status[currentstatus];

        }
    }
}
