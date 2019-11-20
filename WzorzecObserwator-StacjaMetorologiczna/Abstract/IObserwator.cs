using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzorzecObserwator_StacjaMetorologiczna.Abstract
{
    public interface IObserwator
    {
        void Aktualizacja(float temp, float wilgotnosc, float cisnienie);
    }
}
