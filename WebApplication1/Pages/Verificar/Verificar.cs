using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Pages.Entrada;
using WebApplication1.Pages.Saida;

namespace WebApplication1.Pages.Verificar
{
    public class Verificar
    {
        public int ID { get; set; }
        public decimal ValorTotal { get; set; }
        [ForeignKey("ID")]
        public decimal ValorEntrada { get; set; }
        public virtual Entradas Entrada { get; set; }
        public decimal ValorSaida { get; set; }
        [ForeignKey("ID")]
        public virtual Saidas Saidas { get; set; }
    }
}
