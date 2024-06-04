using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class LeituraArquivo
    {
        public (bool Sucesso, string[] Linhas, int QuantidadeLinhas) LerArquivo(string caminho)
        {
            try
            {
                string[] linha = File.ReadAllLines(caminho);
                return (true, linha, linha.Count());
            }
            catch (Exception)
            {
                return (false, new string[0], 0);
            }
            

        }
    }
}
