using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreGeneratedDocument;
using Bibliotec.Contexts;
using Bibliotec.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Bibliotec.Controllers
{
    [Route("[controller]")]
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController (ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        Context context = new Context();
        private IEnumerable<Usuario> listaUsuario;

        public IActionResult Index()
        {
            return View();
        }

        public Context GetContext()
        {
            return context;
        }

         [Route("Lagar")] 
        public IActionResult Logar(IFormCollection form)
        {
            //Criar duas variaceis  para armazenas as informacoes do formulario
            string? emailInformado = form["Email"];
            string? senhaInformado = form["Senha"];

              //Busca no banco de dados   
             Usuario usuarioBuscado = context.Usuario.FirstOrDefault(Usuario => Usuario.Email == emailInformado && Usuario.Senha == senhaInformado)!;
             
             
             //De outro forma:
            //  List<Usuario>listaUsuario = context.Usuario.ToList();
            //  foreach(Usuario usuario_ in listaUsuario){
            //       if (usuario_.Email == emailInformado && usuario_.Senha == senhaInformado){
            //         //usuario logado
            //       }else{
            //          //Usuario nao encotrado
            //       }

             //se meu usuario buscado for igual a null
             if (usuarioBuscado == null){
               Console.WriteLine($"Dados invalidos!");
               return LocalRedirect("~/Login");
            
             }else{

                Console.WriteLine($"Eba voce entrou!");
                  return LocalRedirect("~/Livro2");
             }


        

        }
        


        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View("Error!");
        // }
    }
}