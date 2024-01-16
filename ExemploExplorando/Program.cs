using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(nome: "Fernando",sobrenome: "Ferraz");
 Pessoa p2 = new Pessoa(nome: "Sofia",sobrenome: "Ferraz");
 

 Curso cursoDeIngles = new Curso();
 cursoDeIngles.Nome = "ingles";
 cursoDeIngles.Alunos = new List<Pessoa>();

 cursoDeIngles.AdicionarAluno(p1);
 cursoDeIngles.AdicionarAluno(p2);
 cursoDeIngles.ListarAlunos();






























// Pessoa p1 = new Pessoa();
// p1.Nome = "Fernando";
// p1.Idade = 35;
// p1.Sobrenome = "Ferraz";
// p1.Apresentar();
