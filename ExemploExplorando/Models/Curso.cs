using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAlunos(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
           
        }

        public void LisarAlunos()
        {
            Console.WriteLine($"Esses são alunos do curso de {Nome}");

            //for (int i = 0; i < Alunos.Count; i++)
            //{
            //    Console.WriteLine(Alunos[i].NomeCompleto);
            //}

            int contador = 1;
            foreach ( Pessoa aluno in Alunos )
            {
                Console.WriteLine($"Nº {contador++} - {aluno.NomeCompleto}");
            }
        }
    }
}
