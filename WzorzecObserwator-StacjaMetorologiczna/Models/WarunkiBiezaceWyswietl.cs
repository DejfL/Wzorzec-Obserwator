using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WzorzecObserwator_StacjaMetorologiczna.Abstract;

namespace WzorzecObserwator_StacjaMetorologiczna.Models
{
    class WarunkiBiezaceWyswietl : IObserwator, IWyswietlElement
    {
        private float temperatura;
        private float wilgotnosc;
        private IPodmiot danePogodowe;

        public WarunkiBiezaceWyswietl(IPodmiot danePogodoweParam)
        {
            danePogodowe = danePogodoweParam;
            danePogodowe.ZarejestrujObserwatora(this);
        }
        public void Aktualizacja(float tempParam, float wilgotnoscParam, float cisnienieParam)
        {
            temperatura = tempParam;
            wilgotnosc = wilgotnoscParam;
            Wyswietl();
        }

        public void Wyswietl()
        {
            System.Console.WriteLine("Warunki biezace " + temperatura + " stopni c " + wilgotnosc + " % wilgotnosc");
        }
    }
}
