using System.Collections.Generic;

namespace Catalogo.Jogos.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorId(int id);        
        void Insere(T entidade);        
        void Concluido(int id);        
        void Atualiza(int id, T entidade);
        int ProximoId();
    }
}