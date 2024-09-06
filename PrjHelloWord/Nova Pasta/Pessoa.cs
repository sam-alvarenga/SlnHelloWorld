using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace é aqui que construimos pacotes, onde você organiza a classe. 
//Seria o nome completo da sua classe.
//E é comum usar namespace em qualquer linguagem
namespace PrjHelloWord.NovaPasta
{
    internal class Pessoa
    {
        public string Nome { get; set; }

        public int Idade { get; set; }

        // O metodo Construct sempre leva o nome da class, é padrão do C#, diferente do php que usa __Construct
        public Pessoa()
        {

        }
    }
}
