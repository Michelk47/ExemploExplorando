using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ExemploExplorando.Models
{
    public class VendaDeserializando
    {
        public int Id { get; set; }
        //JsonProperty serve pra quando você tiver que receber um dado do arquivo do seu cliente que não segue o padrão do .NET como nesse caso que o campo Produto esta vendo Nome_Produto
        [JsonProperty("Nome_Produto")]
        public string Produto { get; set;}
        public decimal Preco { get; set;}
        public DateTime DataVenda { get; set; }
    }
}
