using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WzorzecObserwator_StacjaMetorologiczna.Abstract;

namespace WzorzecObserwator_StacjaMetorologiczna.Models
{
    class DanePogodowe : IPodmiot
    {
        private ArrayList obserwatorzy;
        private float temperatura;
        private float wilgotnosc;
        private float cisnienie;

        public DanePogodowe()
        {
            obserwatorzy = new ArrayList();
        }
        public void PowiadomObserwatorow()
        {
            for (int i = 0; i < obserwatorzy.Count; i++)
            {
                IObserwator obserwator = (IObserwator)obserwatorzy[i];
                obserwator.Aktualizacja(temperatura, wilgotnosc, cisnienie);
            }
        }

        public void UsunObserwatora(IObserwator obserwator)
        {
            int i = obserwatorzy.IndexOf(obserwator);
            if (i > 0)
                obserwatorzy.RemoveAt(i);
        }

        public void ZarejestrujObserwatora(IObserwator obserwator)
        {
            obserwatorzy.Add(obserwator);
        }

        public void OdczytZmiana()
        {
            PowiadomObserwatorow();
        }

        public void UstawOdczyt(float temperaturaParam, float wilgotnoscParam, float cisnienieParam)
        {
            temperatura = temperaturaParam;
            wilgotnosc = wilgotnoscParam;
            cisnienie = cisnienieParam;
            OdczytZmiana();
        }
    }
}
