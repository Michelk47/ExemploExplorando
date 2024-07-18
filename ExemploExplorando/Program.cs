using ExemploExplorando.Models;
using System.Globalization;
using Newtonsoft.Json;


//=========================== Como usar Convert e Parse ====================================================//
// o Convert e Parse fazem a conversão de tipo porem a diferença dos dois é que no Convert se ele receber
// null ele retorna 0 e não da erro na compilação já o Parse assim que recebe um valor null ele acaba dando erro
int a = Convert.ToInt32(null);
//int b = int.Parse("6c");

Console.WriteLine(a);
//Console.WriteLine(b);

//============================================================================================================//





//========= como declarar a datetime ===============//

//DateTime dataAtual = DateTime.Now;
//Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));

//===================================================//

//Pessoa2 p2 = new Pessoa2();

//p2.Nome = "Michel";
//p2.Idade = 26;

//p2.Apresentar();

//========================================================== teste 2 =============================//

// lendo um arquivo json e rodando ele na tela com todas as informações do arquivo
//string conteudoArquivo = File.ReadAllText("M:/Curso_C#/ExemploExplorando/Arquivos/vendas.json");

//List<VendaDeserializando> listaVenda = JsonConvert.DeserializeObject<List<VendaDeserializando>>(conteudoArquivo);


//foreach (VendaDeserializando venda in listaVenda)
//{
//    Console.WriteLine("\n");
//    Console.WriteLine($"Id: {venda.Id} \n Produto: {venda.Produto} \n Preço: {venda.Preco} \n Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
//}







//=============== SEREALIZANDO OS DADOS PARA JSON ===================//
//DateTime dataAtual = DateTime.Now;

//List<Venda> listaVendas = new List<Venda>();

//Venda v1 = new Venda(1, "Material de estritório", 25.00M, dataAtual);
//Venda v2 = new Venda(2, "Licença de Sofware", 110.00M, dataAtual);

//listaVendas.Add(v1);
//listaVendas.Add(v2);

//string seriealizado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

//File.WriteAllText("M:/Curso_C#/ExemploExplorando/Arquivos/vendas.json", seriealizado);


//Console.WriteLine(seriealizado);

//===================================================================//




//int numero = 15;
//bool ehPar = false;

//ehPar = numero % 2 == 0;
//Console.WriteLine($" O número {numero} é " + (ehPar ? "par": "impar"));



// usando um descontrutor onde você desfaz uma varivel que já está no construtor 
//Pessoa p1 = new Pessoa("Michel", "Alcantara");

//(string nome, string sobrenome) = p1;

//Console.WriteLine($"{nome} {sobrenome}");






//criando um class que retorna um tuplas trazendo 3 informações true, as linhas do arquivo e a quantidade de linhas
//LeituraArquivo arquivos = new LeituraArquivo();

//desta forma aqui eu estou descartando a variavel quantidadeLinhas quando você não vai usar uma variavel você pode usar desse jeito
//(sucesso, linhasArquivo, _)
//var (sucesso, linhasArquivo, quantidadeLinhas) = arquivos.LerArquivo("C:/Users/michel.alcantara/Desktop/ExemploExplorandoC#/ExemploExplorando/ExemploExplorando/Arquivos/arquivoLeitura.txt");

//if (sucesso)
//{
//    Console.WriteLine($"Quantidade de linhas do arquivo: {quantidadeLinhas}");

//    foreach(string linhas in linhasArquivo)
//    {
//        Console.WriteLine(linhas);
//    }
//}
//else
//{
//    Console.WriteLine("Não foi possivel ler o arquivo");
//}







//================= tuplas ========================
//varias formas de declarar um tupla mais a mais recomenda é está abaixo porque com ela você consegui nomear seus dados já os outros abaixo nem com o nome item1, item2 e assim por diante.
//(int Id,  string Nome, string Sobrenome, decimal Altura) tupla = (1, "Michel", "Alcantara", 1.85M);

//ValueTuple<int, string, string, decimal> outroexemploTupla = (1, "Michel", "Alcantara", 1.85M);
//var outroExemploTuplaCreate = Tuple.Create(1, "Michel", "Alcantara", 1.85M);

//Console.WriteLine($"Id: {tupla.Id}");
//Console.WriteLine($"Nome: {tupla.Nome}");
//Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");
//Console.WriteLine($"Altura: {tupla.Altura}");
//================= tuplas ========================



//declarando o Dictionary
//Dictionary<string, string> estado = new Dictionary<string, string>();

//inserindo o valor no dictionary
//estado.Add("SP", "São Paulo");
//estado.Add("BA", "Bahia");
//estado.Add("MG", "Minas Gerais");

// mostrando um valor unico usando key do dictionary
//Console.WriteLine(estado["MG"]);
//foreach(var item in estado)
//{
//    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
//}

// removendo dictionary
//estado.Remove("BA");
//Console.WriteLine("\n\n");

//alterando o valor do dictionary
//estado["SP"] = "São Paulo - valor alterado";

//foreach (var item in estado)
//{
//    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
//}

//string chave = "PR";
//Console.WriteLine($"Verifecando o elemento {chave}");

// validando se existe essa Key no dictionary com a função ContainsKey() que retorna se existe a Key passada no dictinary ou não
//if (estado.ContainsKey(chave))
//{
//    Console.WriteLine($"Valor existente: {chave}");
//}
//else
//{
//    Console.WriteLine($"Valor não existe. é seguro adicionar a chave {chave}");
//}


//-----------------------------------------------------------------------

//declarando a pilha no c#
//Stack<int> pilha = new Stack<int>();
//inserir na pilha com o Push();
//pilha.Push(4);
//pilha.Push(6);
//pilha.Push(8);
//pilha.Push(10);

//foreach (int item in pilha)
//{
//    Console.WriteLine(item);
//}

// removendo item da pilha com Pop();
//Console.WriteLine($"Removendo elemento topo: {pilha.Pop()}");
//pilha.Push(20);
//foreach (int item in pilha)
//{
//    Console.WriteLine(item);
//}




//===========declarando uma fila no c#==========
//Queue<int> fila = new Queue<int>();

////inserindo valor na fila com o Enqueue();
//fila.Enqueue(2);
//fila.Enqueue(4);
//fila.Enqueue(6);
//fila.Enqueue(8);

//foreach(int item in fila)
//{
//    Console.Write($"\n{item}");
//}

// removendo um elemento da fila com o Dequeue();
//Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");

//foreach (int item in fila)
//{
//    Console.Write($"\n{item}");
//}


//----------------------------------------------


//new ExemploExcecao().Metodo1();


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