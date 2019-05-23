using SistemaLegado;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProject1.Fakes
{
    public class DBFake : IDataBase
    {
        public bool Acessou { get; set; }

        public Usuario ObterUsuario(int id)
        {
            return new Usuario()
            {
                Id = id
            };
        }

        public void Salvar(ICheckin checkin, Unidade unidade, Usuario usuario)
        {
            //nada
            this.Acessou = true;
        }
    }
}
