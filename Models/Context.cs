using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public class Context : DbContext
    {

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptions)
        {
            dbContextOptions.UseSqlServer(connectionString: @"Data Source=DESKTOP-Q75278E;Initial Catalog=MVC;Integrated Security=True");
        }

    }

    //add-migration InitialCreate -- Inicial 
    //
    //Update-Database  -- 
    // add migration TabelaProduto
    //Update-Database
}
