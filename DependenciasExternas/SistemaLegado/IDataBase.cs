namespace SistemaLegado
{
    public interface IDataBase
    {
        Usuario ObterUsuario(int id);
        void Salvar(ICheckin checkin, Unidade unidade, Usuario usuario);
    }
}