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

            Console.WriteLine("Tietokantayhteys avattu onnistuneesti.");

            string sql = "SELECT CompanyName FROM Customers WHERE Country = 'Finland'";
            SqlCommand komento = new SqlCommand(sql, yhteys);
            SqlDataReader lukija = komento.ExecuteReader();

            while (lukija.Read())
            {
                Console.WriteLine("Asiakas: " + lukija["CompanyName"]);
            }

            lukija.Close();
            komento.Dispose();

            Console.WriteLine();
            Console.WriteLine("Valmis, suljetaan tietokantayhteys.");
            yhteys.Close();
            Console.ReadLine();
        }
    }
}
