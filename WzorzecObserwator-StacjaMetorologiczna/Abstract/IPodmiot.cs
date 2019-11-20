using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzorzecObserwator_StacjaMetorologiczna.Abstract
{
    public interface IPodmiot
    {
        void ZarejestrujObserwatora(IObserwator obserwator);
        void UsunObserwatora(IObserwator obserwator);
        void PowiadomObserwatorow();
    }
}
