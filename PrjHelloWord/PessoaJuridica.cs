using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamAlvarenga.PrjHelloWorld.Models
{
    /// <summary>
    /// Representa uma pessoa jurídica.
    /// Herda da classe <see cref="Pessoa"/>.
    /// </summary>
    public class PessoaJuridica : Pessoa
    {
        private string _Cnpj ;

        /// <summary>
        /// Obtém ou define o CNPJ da pessoa jurídica.
        /// Lança uma exceção se o CNPJ não tiver 15 caracteres.
        /// </summary>
        /// <exception cref="Exception">Lançada quando o CNPJ é inválido.</exception>
        public string Cnpj
        {
            get { return _Cnpj; }
            set
            {
                if(value.Length != 14)
                {
                    throw new Exception("CNPJ Inválido!");

                }
                _Cnpj = value;
            }
                
                
                
                
        }


        // Construtor para inicializar os dados da PessoaJuridica
        /// <summary>
        ///  Representação de uma pessoa juridica
        /// </summary>
        /// <param name="pNome">Representa o nome da pessoa jurídica. Valores nulos ou com menos de dois caracteres não são admitidos.</param>
        /// <param name="pIdade">Representa a idade da pessoa jurídica. Valores menores que 1 e maiores que 135 não sao admitidos.</param>
        /// <param name="pjCnpj">Representa o CNPJ da pessoa jurídica. Valores com quantidade de caracteres diferente de 15 não serão aceitos.</param>
        public PessoaJuridica(string pNome, int pIdade, string pjCnpj) : base(pNome, pIdade)
        {
          
            this.Cnpj = pjCnpj;
        }    
    }
}
