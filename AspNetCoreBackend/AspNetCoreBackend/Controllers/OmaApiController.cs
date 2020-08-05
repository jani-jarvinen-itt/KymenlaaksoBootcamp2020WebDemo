using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreBackend.Controllers
{
    [Route("api/oma")]
    [ApiController]
    public class OmaApiController : ControllerBase
    {
        [Route("luku")]
        public int Luku()
        {
            return 123;
        }

        [Route("satunnainen")]
        public int Satunnaisluku()
        {
            Random random = new Random();
            int luku = random.Next(1, 20);
            return luku;
        }

        [Route("ottelut")]
        public List<string> Ottelut()
        {
            string[] joukkueet = new string[]
            {
                "AAA", "BBB", "CCC", "DDD"
            };

            List<string> pelit = new List<string>();
            Random random = new Random();

            for (int laskuri = 0; laskuri < 12; laskuri++)
            {
                bool peliOk = false;
                while (!peliOk)
                {
                    int indeksi = random.Next(0, joukkueet.Length);
                    string kotiJoukkue = joukkueet[indeksi];

                    bool indeksiOk = false;
                    int indeksi2 = 0;
                    while (!indeksiOk)
                    {
                        indeksi2 = random.Next(0, joukkueet.Length);
                        indeksiOk = indeksi != indeksi2;
                    }
                    string vierasJoukkue = joukkueet[indeksi2];

                    string peli = kotiJoukkue + "-" + vierasJoukkue;

                    if (!pelit.Contains(peli))
                    {
                        pelit.Add(peli);
                        peliOk = true;
                    }
                }
            }

            return pelit;
        }

        [Route("merkkijono")]
        public string Merkkijono()
        {
            return "ABCD";
        }

        [Route("merkkijonot")]
        public string[] Merkkijonot()
        {
            return new string[] { "ABCD", "DEFG" };
        }
    }
}
