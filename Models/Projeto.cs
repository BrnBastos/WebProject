using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebProject.Models;
using System.ComponentModel.DataAnnotations;

namespace WebProject.Models
{
    public class Projeto
    {
        [Range(0, 3000, ErrorMessage = "o valor deve ser positivo")]
        public int Codigo { get; set; }
        
        [Required(ErrorMessage = "este campo é obrigatório")]
        [StringLength(15, MinimumLength = 1, ErrorMessage = "número de caracteres inválido max30")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "este campo é obrigatório")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "número de caracteres inválido")]
        public string Descricao { get; set; }
        [Range(0, 30000, ErrorMessage = "o peso válido é entre 0 e 30000kg")] 
        public int Peso { get; set; }
        [Required(ErrorMessage = "este campo é obrigatório")]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "número de caracteres inválido max30")]
        public string Categoria { get; set; }
        [Range(0, 300, ErrorMessage = "o valor deve ser entre 1 e 100")] 
        public double ValorUnitario { get; set; }
   


    }
}