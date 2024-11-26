
using Bibliotec.Models;
using Microsoft.EntityFrameworkCore;


namespace Bibliotec.Contexts
{
    // Classe que tera as informacoes do banco de dados 
    public class Context : DbContext
    { // criar um metodo construtor
         public Context(){

   
         }
         public Context(DbContextOptions<Context> Options ) : base (Options){

         }

      // onConfiguring -> Possui a configuracao da conexao com o banco de dados
      protected override void  OnConfiguring (DbContextOptionsBuilder optionsBuilder){
      // colocar as informacoes do banco 
      
         if (!optionsBuilder.IsConfigured)
         {
            // A string de conexao da banco de dados : 
            // Data Source => Nome do servidor do banco de dados 
            //Initial Catalog => Informacoes de acesso ao servidor do banco de dados 

            //ALUNOS:
            //optionsBuilder.UseSqlServer

            //  optionsBuilder.UseSqlServer("Data Source=DESKTOP-EVM36M7\\SQLEXPRESS02; Initial Catalog = Bibliotec_mvc; User Id=sa; Password=123; Integrated Security=true; TrustServerCertificate = true");
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-EVM36M7\\SQLEXPRESS02; Initial Catalog = Bibliotec_mvc; User Id=sa; Password=123; TrustServerCertificate = true");


         }

      }
     
     // As referencias das nossas tabelas no Banco de dados:
     public DbSet<Categoria> Categoria{ get; set ;}
      //Curso
     public DbSet<Curso> Curso{ get; set ;}
      //livro
     public DbSet<Livro> livro{ get; set ;}
      //livroCategoria
     public DbSet<livroCategoria> livroCategoria{ get; set ;}
      //Usuario 
     public DbSet<Usuario> Usuario{ get; set ;}
      //livroReserva
     public DbSet<livroReserva> livroReserva{ get; set ;}

    }
}