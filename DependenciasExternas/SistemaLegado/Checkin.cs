using Newtonsoft.Json;
using RestSharp;
using System;

namespace SistemaLegado
{
    public class Checkin : ICheckin
    {
        public bool ÉVálido(Unidade unidade, Usuario usuario)
        {
            var client = new RestClient($"https://meuservico.com.br/ws/{unidade.Id}/{usuario.Id}/");
            var request = new RestRequest();

            request.Method = Method.GET;
            request.AddHeader("Accept", "application/json");
            request.Parameters.Clear();

            var response = client.Execute(request);
            var content = response.Content;

            dynamic result = JsonConvert.DeserializeObject(content);
            if (result.checkinavailable == null)
                throw new System.ApplicationException("Unidade não encontrada");

            return result.checkinavailable;
        }
    }
}