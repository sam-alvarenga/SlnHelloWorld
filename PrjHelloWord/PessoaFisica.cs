using SamAlvarenga.PrjHelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SamAlvarenga.PrjHelloWorld.Models
{

    /// <summary>
    /// Representa uma pessoa física no sistema, contendo além de nome e idade, o cpf.
    /// </summary>
    public class PessoaFisica : Pessoa
    {
        //encapsulamento do cpf
        private string _cpf;

        /// <summary>
        /// Representa o cpf da pessoa física. Valores que não possuam 11 caracteres não serão aceitos.
        /// </summary>
        public string Cpf
        {
            get { return _cpf; }
            set { 
                if (value.Length!=11) 
                {

                    throw new Exception("Cpf Inválido!");
                }
                _cpf = value; 
            }
        }

        /// <summary>
        /// Representação de uma pessoa física
        /// </summary>
        /// <param name="pNome">Representa o nome da pessoa física. Valores nulos ou com menos de dois caracteres não são admitidos</param>
        /// <param name="pIdade">Representa a idade da pessoa física. Valores menores que 1 e maiores que 135 não sao admitidos.</param>
        /// <param name="pCpf">Representa o número de cadastro da pessoa física. Valores com quantidade de caracteres diferente de 11 não serão aceitos</param>
        public PessoaFisica(string pNome, int pIdade, string pCpf) : base (pNome,pIdade) 
        {
            this.Cpf = pCpf;
        }
    }
}

