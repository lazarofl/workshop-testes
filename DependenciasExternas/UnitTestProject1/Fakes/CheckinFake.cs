using SistemaLegado;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProject1.Fakes
{
    public class CheckinFake : ICheckin
    {
        public bool ÉVálido(Unidade unidade, Usuario usuario)
        {
            return unidade != null && usuario != null;
        }
    }
}
