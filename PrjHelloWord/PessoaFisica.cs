﻿using SamAlvarenga.PrjHelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SamAlvarenga.PrjHelloWorld.Models
{
    public class PessoaFisica : Pessoa
    {
        //encapsulamento do cpf
        private string _cpf;

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


        public PessoaFisica(string pNome, int pIdade, string pCpf) : base (pNome,pIdade) 
        {
            this.Cpf = pCpf;
        }
    }
}

