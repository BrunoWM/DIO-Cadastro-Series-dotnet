using System;

namespace DIO_Cadastro_Series_dotnet 
{
    public class Serie : EntidadeBase 
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int ano { get; set; }
        private bool ativa {get; set; }

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = Id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.ano = ano;
            this.ativa = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.ano + Environment.NewLine;
            retorno += "Excluído: " + this.ativa + Environment.NewLine;


            return retorno;
        }

        public string retornaTitulo() {
            return this.Titulo;
        }

        public int retornaId() {
            return this.Id;
        }

        public void Excluir() {
            this.ativa = false;
        }
    }
}