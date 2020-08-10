using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TietokantaDemoAdoNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aloitetaan tietokantayhteyden avaus...");

            string yhteysmerkkijono = "Server=localhost\\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;";
            SqlConnection yhteys = new SqlConnection(yhteysmerkkijono);
            yhteys.Open();

            Console.WriteLine("Tietokantayhtes avattu onnistuneesti.");

            yhteys.Close();
            Console.ReadLine();
        }
    }
}
