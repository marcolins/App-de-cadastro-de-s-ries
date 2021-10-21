namespace Dio.Series
{
    public class Series : Entidade_Base
    {
        //Atributos
        private Genero Genero{get; set;}

        private string Titulo{get; set;}

        private string Descricao{get; set;}

        private int Ano{get; set;}

        private bool Excluido{get; set;}

        //Métodos
        public Series(int id, Genero genero, string titulo, string Descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string Tostring()
        {
            string retorno ="";
            retorno += "Gênero: " + this.Genero + Environment.Newline;
            retorno += "Título: " +this.Titulo + Environment.Newline;
            retorno += "Descrição: " +this.Descricao + Environment.Newline;
            retorno += "Ano inicio: " +this.Ano + Environment.Newline;
            retorno += "Excluido: " +this.Excluido + Environment.Newline;

            return retorno;

        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }
        public int retornaId()
        {
            return this.Id;
        }
         public bool retornaExcluido()
        {
            return this.Excluido;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }

    }
}