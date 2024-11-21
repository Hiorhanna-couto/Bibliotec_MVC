using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotec.Models
{
    public class livroReserva
    {
        [Key]
        public int livroReservaID {get ; set ;}
        public DateOnly Dtreserva { get ; set ;}
        public DateOnly DtDevolocao{ get ; set ;}

        
        public int Status {get; set;}
        public int UsuarioID {get; set;}

        [ForeignKey ("Usuario")]
        public int Usuario {get; set;}

        public int livroID {get; set;}
        [ForeignKey ("livro")]
        public int livro {get; set;}


    }
}