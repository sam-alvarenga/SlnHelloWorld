using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamAlvarenga.PrjHelloWorld.Models
{
    public class PessoaJuridica : Pessoa
    {
        private string _Cnpj ;

        public string Cnpj
        {
            get { return _Cnpj; }
            set
            {
                if(value.Length != 15)
                {
                    throw new Exception("CNPJ Inválido!");

                }
                _Cnpj = value;
            }
                
                
                
                
        }


        // Construtor para inicializar os dados da PessoaJuridica
        public PessoaJuridica(string pNome, int pIdade, string pjCnpj) : base(pNome, pIdade)
        {
          
            this.Cnpj = pjCnpj;
        }    
    }
}
