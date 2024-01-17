using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploExplorando.Models;
using System.Globalization;

string dataString = "2024-01-17 00:48";
DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);
if (sucesso)
{
    Console.WriteLine($"Converção com sucesso! Data: {data}");
}
else
{
    Console.WriteLine($"{dataString} não é uma data válida");
}




















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
