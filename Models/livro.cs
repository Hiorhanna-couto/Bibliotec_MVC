using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotec.Models
{
    public class Livro 
    {
        [Key]
        public int livroID {get ; set; }
        
        public string? Nome {get ; set;}
        public string? Escritor {get ; set;}

        public string?  Editora {get ; set;}
        public string? Descricao  {get ; set;}
        public string? Idioma {get ; set;}
        public string? Imagem {get ; set;}
        public bool Reserva{get ; set;}
        public bool Ativa{get ; set;}



    }
}