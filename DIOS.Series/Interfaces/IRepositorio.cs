using System.Collections.Generic;
namespace DIOS.Series.interfaces
{
    public interface IRepositorio<T>
    {
        List <T> Lista();
        T RetornaPorId(int id);
        void Inseri(T entidade);

        void Exclui (int id);
        void Atualiza (int id, T entidade);
        int ProximoId();
         
    }
}