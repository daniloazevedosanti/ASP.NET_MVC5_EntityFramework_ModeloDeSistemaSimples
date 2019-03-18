using System.Data.Entity;

namespace ModeloSistemaDeCadastro.Models
{
   public class PessoaContexto : DbContext
   {
      public DbSet<Pessoa> Pessoas { get; set; }

   }
}