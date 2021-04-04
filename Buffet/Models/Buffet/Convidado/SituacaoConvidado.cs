using System.Collections;
using System.Collections.Generic;
using Buffet.Models.Buffet.Cliente;

namespace Buffet.Models.Buffet
{
    public class SituacaoConvidado
    {
        public int Id { get; set; }
        public string Descricao { get; set; } //Confirmado, Cancelado ou Pendente
    }
}