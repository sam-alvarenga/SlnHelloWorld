using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    //namespace é aqui que construimos pacotes, onde você organiza a classe. 
    //Seria o nome completo da sua classe.
    //E é comum usar namespace em qualquer linguagem
namespace SamAlvarenga.PrjHelloWorld.Models

    //<summary>
    //Representação de uma pessoa.
    //</summary>
{
    public class Pessoa
    {
        private string _nome;

        //<summary>
        //Representação o nome da pessoa.
        //Valores nulos ou com menos de dois caracteres não são admitidos.
        //</summary>

        public string Nome
        {
            get
            {
                if(this._nome == null)
                {
                    return "";
                }
                else
                {
                   return this._nome.ToUpper();
                }

                //if ternário no get (: seria o else) 
                //return this._nome == null ? "" : this._nome.ToUpper();
            }

            // setar valores de fora
            set
            {
                //
                if (value == null || value == String.Empty)
                {
                    //lançar exception
                    throw new Exception("Erro: nome nulo ou inválido!");
                }
                else // recebeu o else para 
                {
                    //trim usado para comparação e verificação
                    if (value.Trim().Length < 2)
                    {
                        throw new Exception("Erro: nome deve ter ao menos dois caracteres!");
                    }
                }

                //Trim usado para verificar e joga para this._nome
                this._nome = value.Trim().ToUpper(); //Trim elimina espaço da esquerda e direita
            }
        }


        //getter e setter default
        private int _idade; //atributo
        /// <summary>
        /// Representa a idade de uma pessoa.
        /// valores menores que 1 e maiores que 135 não são aceitos.
        /// </summary>

        public int Idade
        { //property ou get/setter
            get
            {
                return this._idade;
            }
            set
            {
                if (value <= 0 || value > 135)
                {
                    throw new Exception("Erro: idade inválida!");
                }
                this._idade = value;
            }
        }
        
          //demonstrar como seria o padrão
         


        /// <summary>
        /// Representa de uma pessoa
        /// <param name="pNome">Representa o nome da pessoa. Valores nulos ou com menos de dois caracteres não são admitidos.</param>
        /// <param name="pIdade">Representa a idade da pessoa. Valores menos que 1 e maiores que 135 não são admitidos</param>
        /// </summary>
        //public Pessoa() { }
        public Pessoa(string pNome, int pIdade) //O método retornará uma string que representa a idade da pessoa, seguida pela palavra "anos".
        {
            this.Nome = pNome;
            this.Idade = pIdade;
        }

        // O metodo Construct sempre leva o nome da class, é padrão do C#, diferente do php que usa __Construct
        // public Pessoas {}

        //modificador | tipo de retorno | nome do método(tipos e parametros)
        /// <summary>
        /// Verifica a maioridade da pessoa
        /// </summary>
        /// <returns>Retorna se a pessoa é ou não maior de idade.</returns>
        public bool verificarMaioridade()
        {
            //if (this.Idade < 18)
            //{
            //    return false;
            //}
            //return true;

            //simplificando em if ternário 
            return this.Idade >= 18 ? true : false;
        }

        /// <summary>
        /// Exibe uma mensagem informando se a pesssoa atingiu a maioridade.
        /// </summary>
        /// <returns>Retorna se a pessoa é ou não maior de idade  <Pessoa> é maior | menor de idade.</Pessoa></returns>
        ///
        public string exibirMensagemMaioridade()
        {
            //if ternário 
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
        /// <summary>
        /// Eibe todos os dados da pessoa
        /// </summary>
        /// <returns>Retorna uma mensagem padronozada com dados da pessoa.</returns>
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

        /// <summary>
        /// Retorna a idade formatada.
        /// </summary>
        /// <returns>Acrescenta a palavra anos à idade.</returns>
        public string getIdadeFormatada()
        {

            return $"{this.Idade.ToString()} anos";
        }

        public override string ToString()
        {
            return this.ToString();
        }
    }
}
    
