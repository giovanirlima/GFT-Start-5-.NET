using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectTV
{
    public class Serie : EntidadeBase
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }

        private bool Excluido { get; set; }

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            Id = id;
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
            Excluido = false;
        }

        public string RetornaTitulo()
        {
            return Titulo;
        }

        internal int RetornaId()
        {
            return Id;
        }

        internal bool RetornaExluido()
        {
            return Excluido;
        }

        public void Exclui()
        {
            Excluido = true;
        }


        public override string ToString()
        {
            return $"Gênero - {Genero}, \nTitulo - {Titulo}, \nDescrição - {Descricao}, \nAno de Inicio - {Ano}, \nExcluido: {Excluido}";
        }

        
    }
}
