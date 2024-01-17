using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploExplorando.Models;
using System.Globalization;

Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("BA", "bahia");
estados.Add("MG", "Minas Gerais");

foreach(var item in estados)
{
    Console.WriteLine($"Chave:{item.key}, Valor: {item.value}");

} Console.WriteLine("__________________");

estados.remove("BA");
estados["SP"] = "São Paulo - valor alterado";

foreach(var item in estados)
{
    Console.WriteLine($"Chave:{item.key}, Valor: {item.value}");

}
string chave = "BA";
Console.WriteLine($"Verificando o elemento:{chave}");
if(estados.ContainsKey(chave))
{
    Console.WriteLine($"Valor existente: {chave}");
}
else
{
    Console.WriteLine($"Valor não existe. É seguro adicionar chave: {chave}");
}















//  Stack<int> pilha = new Stack<int>();

//  pilha.Push(4);
//  pilha.Push(6);
//  pilha.Push(8);
//  pilha.Push(10);

//  foreach(int item in pilha)
//  {
//     Console.WriteLine(item);
//  }
//  Console.WriteLine($"Removendo o elmento do topo: {pilha.pop()}");
// pilha.Push(20);

//  foreach(int item in pilha)
//  {
//     Console.WriteLine(item);
//  }























//  Queue<int> fila = Queue<int>();

//  fila.Enqueue(2);
//  fila.Enqueue(4);
//  fila.Enqueue(6);
//  fila.Enqueue(8);

//  foreach(int item in fila)
//  {
//     Console.WriteLine(item);
//  }
//  Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
// fila.Enqueue(10);

//  foreach(int item in fila)
//  {
//     Console.WriteLine(item);
//  }




























//new ExemploExecao().Metodo1();







// try
// {
// string[] linhas = File.ReadAllLines("Arquivos/aquivoLeitura.txt");

// foreach(string Linha in linhas)
//  {
//     Console.WriteLine(linha);
//  }
// }

// catch(FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado {ex.Message}");
// }
//  catch(Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica.{ex.Message}");
// }
// finally
// {
// Console.WriteLine("Seu programa chegou até aqui");
// }




















// string dataString = "2024-01-17 00:48";
// DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);
// if (sucesso)
// {
//     Console.WriteLine($"Converção com sucesso! Data: {data}");
// }
// else
// {
//     Console.WriteLine($"{dataString} não é uma data válida");
// }




















//CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");



//decimal valorMonetario = 1582.40;

//Console.WriteLine(valorMonetario.ToString("C2"));


//double porcentagem = .3421;

//Console.WriteLine(porcentagem.ToString("P"));

//int numero = 123456;
//Console.WriteLine(numero.ToString(##-##-##));




















//int numero1 = 10;
//string numero2 = "20";

//string resultado = numero1 + numero2;
//Console.WriteLine(resultado);



















//Pessoa p1 = new Pessoa(nome: "Fernando",sobrenome: "Ferraz");
// Pessoa p2 = new Pessoa(nome: "Sofia",sobrenome: "Ferraz");


// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();






























// Pessoa p1 = new Pessoa();
// p1.Nome = "Fernando";
// p1.Idade = 35;
// p1.Sobrenome = "Ferraz";
// p1.Apresentar();
