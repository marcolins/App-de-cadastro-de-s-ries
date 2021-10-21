namespace Dio.Series.interfaces
{
    public interface Irepositorio<T>
    {
        List<T> lista();
        T RetornaPorId(int id);        
        void Insere(T entidade);
        void Exclui(int id);
        void Atualiza(int id, T entidade);
        int ProximoId();
    }
}