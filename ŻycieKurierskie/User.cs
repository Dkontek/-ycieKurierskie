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

        String login;
        String password;
        String name;
        String surname;
        String address;
        String city;
        String email;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dkon\source\repos\ŻycieKurierskie\ŻycieKurierskie\Database.mdf;Integrated Security=True");
        SqlCommand cmd;
        public User()
        {
            Register();
        }
        public void Register()
        {
            System.Console.WriteLine("Podaj Login");
            login = System.Console.ReadLine();
            System.Console.WriteLine("Podaj Hasło");
            password = System.Console.ReadLine();
            System.Console.WriteLine("Podaj Imię");
            name = System.Console.ReadLine();
            System.Console.WriteLine("Podaj Nazwisko");
            surname = System.Console.ReadLine();
            System.Console.WriteLine("Podaj Miasto");
            city = System.Console.ReadLine();
            System.Console.WriteLine("Podaj Adres");
            address = System.Console.ReadLine();
            System.Console.WriteLine("Podaj E-Mail");
            email = System.Console.ReadLine();


            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dkon\source\repos\ŻycieKurierskie\ŻycieKurierskie\Database.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd;
            // cmd = new SqlCommand("INSERT INTO [User] (login, password, name, surname, city, address, email) VALUES ({0},{1},{2},{3},{4},{5},{6});", con);

            String query = "INSERT INTO Users (login, password, name, surname, city, address, email) VALUES (@login, @password, @name, @surname, @city, @address, @email)";
            using (SqlCommand command = new SqlCommand(query, con))
            {
                command.Parameters.AddWithValue("@login",login);
                command.Parameters.AddWithValue("@password",password);
                command.Parameters.AddWithValue("@name",name);
                command.Parameters.AddWithValue("@surname",surname);
                command.Parameters.AddWithValue("@city",city);
                command.Parameters.AddWithValue("@address",address);
                command.Parameters.AddWithValue("@email",email);

                int result = command.ExecuteNonQuery();
                if (result < 0)
                    Console.WriteLine("Error inserting data into Database!");
            }

            
            SqlCommand readvalues;

            readvalues = new SqlCommand("SELECT * FROM Users;", con);
            SqlDataReader rdr = null;

            rdr = readvalues.ExecuteReader();



            Console.WriteLine("Twoje dane:");
            while (rdr.Read())
            {
                String tempName = rdr["name"].ToString().Trim();
                String tempsurname       = rdr["surname"].ToString().Trim();
                String tempcity          = rdr["city"].ToString().Trim();
                String tempadress        = rdr["address"].ToString().Trim();
                String tempemail         = rdr["email"].ToString().Trim();
                String templogin        = rdr["login"].ToString().Trim();
                String temppassword      = rdr["password"].ToString().Trim();

            


                System.Console.WriteLine(tempName    );
                System.Console.WriteLine(tempsurname );
                System.Console.WriteLine(tempcity    );
                System.Console.WriteLine(tempadress  );
                System.Console.WriteLine(tempemail   );
                System.Console.WriteLine(templogin   );
                System.Console.WriteLine(temppassword);

                

            }
        

            if (rdr != null)
            {
                rdr.Close();
            }

            // close the connection
            if (con != null)
            {
                con.Close();
            }




        }



    }
}
