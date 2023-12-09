using ExemploExplorando.Models;

Pessoa p1 = new Pessoa("Mateus", "Melo");
Pessoa p2 = new Pessoa("Kamila", "Melo");
Pessoa p3 = new Pessoa("Yasmin", "Melo");


Curso cursoDeCsharp = new Curso();
cursoDeCsharp.Nome = "Csharp";
cursoDeCsharp.Alunos = new List<Pessoa>();

cursoDeCsharp.AdicionarAluno(p1);
cursoDeCsharp.AdicionarAluno(p2);
cursoDeCsharp.AdicionarAluno(p3);
cursoDeCsharp.ListarAlunos();
