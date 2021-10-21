using System;
using System.Colçections.Generic;
using Dio.Series.interfaces;

namespace Dio.Series
{
    public class SerieRepositorio : IRepositorio<Series>
    {
        private List<Series> ListaSerie = new List<Series>();
        public void Atualiza(int id, Serie objeto)
        {
            ListaSerie[id] = objeto;
        }
        public void Exclui(int id)
        
        {
            ListaSerie[id].Excluir;
        }
        public void Insere(Series objeto)
        {
            ListaSerie.Add(objeto);
        }
        public List<Series> Lista()
        {
            return ListaSerie;
        }        
        public int ProximoId()
        {
            ListaSerie.Count;
        }
        public Series RetornaPorId(int id)
        {
            throw new notImplementedException();
        }
    }
}