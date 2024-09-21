using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    //namespace é aqui que construimos pacotes, onde você organiza a classe. 
    //Seria o nome completo da sua classe.
    //E é comum usar namespace em qualquer linguagem
namespace SamAlvarenga.PrjHelloWorld.Models
{
    internal class Pessoa
    {
        private string ?_nome;


        public string Nome
        {
            get
            {
                return this._nome.ToUpper();
            }
            set
            {
                if (value == String.Empty || value.Length < 2)
                {
                    //lançar exception
                    throw new Exception("Erro: nome nulo ou inválido!");
                }

                this._nome = value.Trim().ToUpper(); //Trim elimina espaço da esquerda e direita
            }
        }


        //getter e setter default
        private int _idade; //atributo


        public int Idade
        { //property ou get/setter
            get
            {
                return this._idade;
            }
            set
            {
                if (value <= 0 || value > 120)
                {
                    throw new Exception("Erro: idade inválida!");
                }
                this._idade = value;
            }
        }
        
          //demonstrar como seria o padrão
         //O método retornará uma string que representa a idade da pessoa, seguida pela palavra "anos".
        public string getIdadeFormatada()
        {

            return $"{this.Idade.ToString()} anos";
        }

        public Pessoa() { }
        public Pessoa(string pNome, int pIdade)
        {
            this.Nome = pNome;
            this.Idade = pIdade;
        }

        // O metodo Construct sempre leva o nome da class, é padrão do C#, diferente do php que usa __Construct
        // public Pessoas {}

        //modificador | tipo de retorno | nome do método(tipos e parametros)
        public bool verificarMaioridade()
        {
            if (this.Idade < 18)
            {
                return false;
            }
            return true;
        }

        public string exibirMensagemMaioridade()
        {
            //if ternario 
            //     condição ? caminho verdadeiro : caminho falso
            //int x = y >10 ? 5 : 9;
            //para retonar o nome de quem digita
            return this.verificarMaioridade() ? $"{this.Nome} é maior de idade." : $"{this.Nome} é menor de idade.";

            //if (this.verificarMaioridade())
            //{
            //    return "Você é maior de idade.";
            //}
            //else 
            //{
            //    return "Você é menor de idade.";
            //}
        }

        public string exibirDadosPessoa()
        {
            return $"################################" +
                   $"\n O nome da pessoa é {this.Nome} " +
                   $"e a idade é {this.getIdadeFormatada()} \n" +
                   $"{this.exibirMensagemMaioridade()} \n" +
                   $"################################";
        }

        //metodo sem retorno
        //public void fazerAlgo()
        //{
        //}
    }
}
    
