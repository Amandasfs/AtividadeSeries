using System;

namespace catalogo.jogos
{
    public class Jogos : BaseEntidade
    {
        //Atributos
        private string Nome {get; set;}
        private string Descricao {get; set;}
        private int Ano{get; set;}
        private bool Excluido {get; set;} 
        private Genero Genero{get; set;}

    }
    //Métodos
    public Jogos(int id,
                 Genero genero,
                 string nome,
                 string descricao,
                 int ano)
    {
        this.Id = id;
		this.Genero = genero;
		this.Nome = nome;
		this.Descricao = descricao;
		this.Ano = ano;
        this.Excluido = false;
    }
     public override string ToString()
	{
        string retorno = "";
        retorno += "Gênero: " + this.Genero + Environment.NewLine;
        retorno += "Nome: " + this.Nome + Environment.NewLine;
        retorno += "Descrição: " + this.Descricao + Environment.NewLine;
        retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
        retorno += "Excluido: " + this.Excluido;
		return retorno;
	}
    public string retornaNome()
		{
			return this.Nome;
		}

		public int retornaId()
		{
			return this.Id;
		}
        public bool retornaExcluido()
		{
			return this.Excluido;
		}
        public void Excluido() 
        {
            this.Excluir = true;
        }
}