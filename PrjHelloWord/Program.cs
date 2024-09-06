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


using PrjHelloWord.NovaPasta;

//Definindo uma variável como tipo Pessoa para armazenar um
//Objeto pessoa. Nenhum outro tipo vai funcionar
Pessoa minhaPessoa = new Pessoa();

Console.WriteLine("Hello, Digite seu nome");
minhaPessoa.Nome = Console.ReadLine();

Console.WriteLine("Hello, Digite sua idade:");
minhaPessoa.Idade =  Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"O nome da pessoa é {minhaPessoa.Nome} e a idade é { minhaPessoa.Idade.ToString()} anos.");