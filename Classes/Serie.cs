using System;

namespace DIO_Cadastro_Series_dotnet 
{
    public class Serie : EntidadeBase
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int ano { get; set; }

        public Serie(Genero genero, string titulo, string descricao, int ano)
        {
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.ano = ano;

        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.ano + Environment.NewLine;

            return retorno;
        }

        public string retornaTitulo() {
            return this.Titulo;
        }

        public int retornaId() {
            return this.Id;
        }
    }
}