
using System;
using System.ComponentModel.DataAnnotations;

namespace AulaMVC.Models
{
    public class Cliente
    {
        public string Nome{get;set;}

        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime DataDeNascimento {get;set;}
        public float Altura{get;set;}
        public int Peso{get;set;}  
        public string DaiDaSemana {get;set;}

        public float Imc { get; set; }
    }
}