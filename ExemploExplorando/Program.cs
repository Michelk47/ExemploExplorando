using ExemploExplorando.Models;
using System.Globalization;

new ExemploExcecao().Metodo1();




















//try
//{
//    string[] linhas = File.ReadAllLines("C:/Users/michel.alcantara/Desktop/ExemploExplorandoC#/ExemploExplorando/ExemploExplorando/Arquivos/arquivoLeitura.txt");

//    foreach (string linha in linhas)
//    {
//        Console.WriteLine(linha);
//    }
//}

//catch (FileNotFoundException ex)
//{
//    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
//}

//catch (DirectoryNotFoundException ex)
//{
//    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrada. {ex.Message}");
//}

//catch (Exception ex)
//{
//    Console.WriteLine($"Acontenceu um exceção genérica: {ex.Message}");
//}
//finally
//{
//    Console.WriteLine("Chegou até aqui");
//}






//string dataString = "2022-04-17 18:00";

//bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

//if (sucesso)
//{
//    Console.WriteLine($"Conversão realiza com sucesso! Data: {data}");
//}
//else
//{
//    Console.WriteLine($"{dataString} não é valida!");
//}

//DateTime data4 = DateTime.Parse("32/04/2022 18:00");

//Console.WriteLine(data4);
//Console.WriteLine(data4.ToString("dd/MM/yyyy HH:mm"));
//Console.WriteLine(data4.ToShortDateString());
//Console.WriteLine(data4.ToShortTimeString());













// essa duas linha são para voc~e redefinir a moeda que vc vai trabalhar que nesse caso está configurando a moeda dolar.
//CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

//decimal valorMonetario = 1582.40M;
//Console.WriteLine($"{valorMonetario:C}");

// deste jeito você formata espefico o valor que você quer mesmo tendo a seu valor tiver em outro
//Console.WriteLine(valorMonetario.ToString("C8", CultureInfo.CreateSpecificCulture("en-US")));

//double porcentagem = .3421;
//Console.WriteLine(porcentagem.ToString("P"));




//Pessoa p1 = new Pessoa(nome:"Michel", sobrenome:"Alcantara");
//p1.Nome = "Michel";
//p1.Sobrenome = "Alcantara";

//Pessoa p2 = new Pessoa(nome:"Diego", sobrenome:"Palareti");
//p2.Nome = "Diego";
//p2.Sobrenome = "Palareti";

//Curso cursoDeIngles = new Curso();
//cursoDeIngles.Nome = "Ingles";
//cursoDeIngles.Alunos = new List<Pessoa>();

//cursoDeIngles.AdicionarAlunos(p1);
//cursoDeIngles.AdicionarAlunos(p2);
//cursoDeIngles.LisarAlunos();


//Pessoa p1 = new Pessoa();
//p1.Nome = "Michel";
//p1.Idade = 0;
//p1.Sobrenome = "Alcantara";

//p1.Apresentar();