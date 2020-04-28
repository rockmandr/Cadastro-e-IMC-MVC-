using System.Globalization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AulaMVC.Models;
using System;

namespace AulaMVC.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [HttpPost()]
       public IActionResult ReceberDados(string nomeCliente, float Altura, int Peso, DateTime dataNascimento)
       {
           Cliente clienteModel =  new Cliente();
           clienteModel.Nome = nomeCliente;

           clienteModel.DataDeNascimento = dataNascimento;

            clienteModel.Altura = Altura;

            clienteModel.Peso = Peso;

            var imc = clienteModel.Peso / (clienteModel.Altura * clienteModel.Altura);
            
            clienteModel.Imc = imc;

           switch(dataNascimento.DayOfWeek)
           {
               case DayOfWeek.Sunday:
               clienteModel.DaiDaSemana = "Domingo";
               break;

               case DayOfWeek.Monday:
               clienteModel.DaiDaSemana = "Segunda-Feira";
               break;

               case DayOfWeek.Tuesday:
               clienteModel.DaiDaSemana = "Terça-Feira";
               break;
               
               case DayOfWeek.Wednesday:
               clienteModel.DaiDaSemana = "Quarta-Feira";
               break;

               case DayOfWeek.Thursday:
               clienteModel.DaiDaSemana = "Quinta-Feira";
               break;

               case DayOfWeek.Friday:
               clienteModel.DaiDaSemana = "Sexta-Feira";
               break;

               case DayOfWeek.Saturday:
               clienteModel.DaiDaSemana = "Sábado";
               break;

               default:
               clienteModel.DaiDaSemana = "Dia não existe";
               break;

           }

           return View(clienteModel);
       }
    }
}
