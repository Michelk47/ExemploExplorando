using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(nome:"Michel", sobrenome:"Alcantara");
//p1.Nome = "Michel";
//p1.Sobrenome = "Alcantara";



Pessoa p2 = new Pessoa(nome:"Diego", sobrenome:"Palareti");
//p2.Nome = "Diego";
//p2.Sobrenome = "Palareti";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAlunos(p1);
cursoDeIngles.AdicionarAlunos(p2);
cursoDeIngles.LisarAlunos();












//Pessoa p1 = new Pessoa();
//p1.Nome = "Michel";
//p1.Idade = 0;
//p1.Sobrenome = "Alcantara";

//p1.Apresentar();