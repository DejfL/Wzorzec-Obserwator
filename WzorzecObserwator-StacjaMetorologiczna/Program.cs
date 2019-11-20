using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WzorzecObserwator_StacjaMetorologiczna.Models;

namespace WzorzecObserwator_StacjaMetorologiczna
{
    class Program
    {
        static void Main(string[] args)
        {
            DanePogodowe danePogodowe = new DanePogodowe();
            WarunkiBiezaceWyswietl warunkiBiezaceWyswietl = new WarunkiBiezaceWyswietl(danePogodowe);
            danePogodowe.UstawOdczyt(34, 65, 1231);
            Console.ReadKey();
        }
    }
}
