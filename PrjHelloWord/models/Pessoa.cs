using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

//namespace é aqui que construimos pacotes, onde você organiza a classe. 
//Seria o nome completo da sua classe.
//E é comum usar namespace em qualquer linguagem
namespace PrjHelloWord.models;

    internal class Pessoa
    {
        public string Nome { get; set; }

        public int Idade { get; set; }

        // O metodo Construct sempre leva o nome da class, é padrão do C#, diferente do php que usa __Construct
        //public Pessoa()
    
        //modificador | tipo retorno | nome método (tipos e parâmentros)

        public bool verificarMaioridade()
        {
            if(this.Idade<18)
            {
                return false;
            }
            return true;
        }

    

        public string exibirMensagemMaioridade()
        {
            //if ternário
            //        condição ? caminho verdadeiro : caminho falso  
            //int x = y > 10 ? 5:9;
            //return this.verificarMaioridade()? "Você é maior de idade." : "Você é menor de idade.";
                //para retonar o nome de quem digita
            return this.verificarMaioridade() ? $"{this.Nome} é maior de idade." : $"{ this.Nome} é menor de idade.";
        

                //    if (this.verificarMaioridade()) {
                //        return "Você é maior de idade.";
                //    }
                //    else { 
                //        return "Você é menor de idade.";
                //    }
                //}

                //método sem retorno 
                //public void fazerAlgo()
                //{
        }
        public string exibirDadosPessoa()
        {
            return $"############################### \n"  +
                   $"O nome da pessoa é {this.Nome} " +
                   $"e a idade é {this.Idade} anos. \n" +
                   $"{this.exibirMensagemMaioridade()}\n" +
                   $"###############################";

        }
        public Pessoa() { }
        public Pessoa(string pNome, int pIdade)
        {
            this.Nome = pNome;
            this.Idade = pIdade;
        }


}

