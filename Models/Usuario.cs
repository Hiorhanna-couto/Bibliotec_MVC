using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotec.Models
{ 
    public class Usuario
    {
        [Key]
        public string? Nome {get ; set;}
        public int UsuarioID {get ; set;}
        public DateOnly DtNascimento {get ; set;}
        public string? Email {get ; set;}
        public string? Senha {get ; set;}
        public string? Contado {get ; set;}
        public bool Admin {get ; set;}
        public bool Status {get ; set;}

        //criar um atributo
        //EU falo par esta atributo que ele e uma fk

        [ForeignKey("Curso")]
       public int cursoID { get; set;}
     
       public Cursos ? curso { get ; set ;}

    }
}