using Cadastro.Models;
using Microsoft.EntityFrameworkCore;

namespace Cadastro.Data
{
    public class BancoContex : DbContext
    {
           public BancoContex(DbContextOptions<BancoContex> options) : base(options)
        {

        }

        public DbSet<ContatoModel> Clientes { get; set; }
            
    }
}
