using Newtonsoft.Json;
using RestSharp;

namespace DependenciasInternas
{
    public class ConsultaCEP
    {
        public string ObterEndereço(string cep)
        {
            dynamic result = ObterCepDosCorreios(cep);

            if (result.logradouro == null)
                throw new System.ApplicationException("CEP não encontrado");

            return result.logradouro;
        }

        public virtual dynamic ObterCepDosCorreios(string cep)
        {
            var client = new RestClient($"https://viacep.com.br/ws/{cep}/json/");
            var request = new RestRequest();

            request.Method = Method.GET;
            request.AddHeader("Accept", "application/json");
            request.Parameters.Clear();

            var response = client.Execute(request);
            var content = response.Content;

            dynamic result = JsonConvert.DeserializeObject(content);
            return result;
        }
    }
}
