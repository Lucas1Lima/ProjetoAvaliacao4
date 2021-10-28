using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Pages.Entrada;
using WebApplication1.Pages.Saida;
using WebApplication1.Pages.Verificar;

namespace WebApplication1.Data
{
    public class WebApplication1Context : DbContext
    {
        public WebApplication1Context (DbContextOptions<WebApplication1Context> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=UNDERUNDER\SQLEXPRESS; Database = 
        EmpresaDB;integrated security = true;User Id=lucas;");
        }
        public DbSet<WebApplication1.Pages.Entrada.Entradas> Entradas { get; set; }

        public DbSet<WebApplication1.Pages.Saida.Saidas> Saidas { get; set; }

        public DbSet<WebApplication1.Pages.Verificar.Verificar> Verificar { get; set; }
    }
}
