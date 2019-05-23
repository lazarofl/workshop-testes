using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;

namespace SistemaLegado
{
    public class ProcessadorDeCheckin
    {
        public string LerNomeDoArquivo(FileInfo arquivo)
        {
            return arquivo.FullName;
        }

        public bool ProcessarCheckin(Unidade unidade, Usuario usuario, ICheckin checkin, IDataBase db)
        {
            if (!checkin.ÉVálido(unidade, usuario))
            {
                var usuarioAtualizado = db.ObterUsuario(usuario.Id);

                if (usuario != null
                    && usuario.Id == usuarioAtualizado.Id)
                {
                    db.Salvar(checkin, unidade, usuario);
                    return true;
                }
                return false;
            }
            return false;
        }

    }
}
