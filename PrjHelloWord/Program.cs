// See https://aka.ms/new-console-template for more information

//C# é uma linguagem compilada e tipada

// int - números inteiros
//int variavelnumerica = 2;

// double - números decimas
//double variavelNumerica = 2;

//string - textos (sempre entre aspas "")
//string nome = "Samantha";

//char - único caractere (usa-se apotolos '')
//char caracterUnico = 'S';

//bool - booleano (true/false)
//bool temArCondicionado = false;



using SamAlvarenga.PrjHelloWorld.Models;



//////Console.WriteLine("Hello, Digite seu nome");
//////minhaPessoa.Nome = Console.ReadLine();

//////Console.WriteLine("Hello, Digite sua idade:");
//////minhaPessoa.Idade =  Convert.ToInt32(Console.ReadLine());

////////Console.WriteLine($"O nome da pessoa é {minhaPessoa.Nome} e a idade é { minhaPessoa.Idade.ToString()} anos." + $"{minhaPessoa.exibirMensagemMaioridade()}");
//////Console.WriteLine(minhaPessoa.exibirDadosPessoa());

//////metodo construtor que ja traz dados existentes
//////Definindo uma variável como tipo Pessoa para armazenar um
//////Objeto pessoa. Nenhum outro tipo vai funcionar
////Pessoa minhaPessoa = new Pessoa();


////try
////{
////    string ?nomePessoa = String.Empty permitido nulo
////	Console.WriteLine("PESSOA 1");
////	Console.WriteLine("Hello, Digite seu nome:");
////	minhaPessoa.Nome = Console.ReadLine();
////	Console.WriteLine("Digite sua idade:");
////	minhaPessoa.Idade = Convert.ToInt32(Console.ReadLine());

////	Console.WriteLine(minhaPessoa.exibirDadosPessoa());

////	Console.WriteLine("PESSOA 2");
////	Console.WriteLine("Hello, Digite seu nome:");
////	string nomePessoa = Console.ReadLine();
////	Console.WriteLine("Digite sua idade:");
////	int idadePessoa = Convert.ToInt32(Console.ReadLine());
    
//    Construtor Customizado
////	Pessoa minhaPessoa2 = new Pessoa(nomePessoa, idadePessoa);
////	Console.WriteLine(minhaPessoa2.exibirDadosPessoa());
////}
////catch (Exception ex)
////{

////	Console.WriteLine(ex.Message);

////}

//////if (minhaPessoa.verificarMaioridade() == true)
//////{
//////    Console.WriteLine($"Você é maior de idade.");
//////}
//////else
//////{
//////    Console.WriteLine($"Você é menor de idade.");
//////}

//////Tipo primitivo x Tipo Referência

//////int x = 10;
//////int y = 20;
//////Console.WriteLine(x);//10
//////Console.WriteLine(y);//20
//////x = y + 1;
//////Console.WriteLine(x);//21   
//////Console.WriteLine(y);//20

//////teste

Pessoa pessoa = new Pessoa("Juquinha", 40);

PessoaFisica pessoaFisica = new PessoaFisica("Martha", 34, "33344455566");