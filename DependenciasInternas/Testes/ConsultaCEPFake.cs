using DependenciasInternas;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Testes
{
    public class ConsultaCEPFake : ConsultaCEP
    {
        public override dynamic ObterCepDosCorreios(string cep)
        {
            if (cep != "12345678")
                return string.Empty;

            dynamic obj = new ExpandoObject();
            obj.logradouro = "Alameda Vicente Pinzon";
            return JsonConvert.SerializeObject(obj);
        }
    }
}
