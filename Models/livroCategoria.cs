using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotec.Models
{
    public class livroCategoria
    {
      [Key]


        public int livroCategoriaID {get ; set;}

        [ForeignKey("Livro")]

        public int livroID {get ; set;}
        public int livro {get ; set;}

        [ForeignKey("Categoria")]

        public int CategoriaID {get ; set;}
        public int Categoria {get ; set;}
       
    }
}