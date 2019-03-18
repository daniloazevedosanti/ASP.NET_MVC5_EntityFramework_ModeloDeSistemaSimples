using System;
using System.ComponentModel.DataAnnotations;

namespace ModeloSistemaDeCadastro.Models
{
   public class Pessoa
   {
      [Key]
      public int Id { get; set; }

      [Required(ErrorMessage ="Dado Obrigatório")]
      public string Nome { get; set; }

      [Required(ErrorMessage = "Dado Obrigatório")]
      [DataType(DataType.Date)]
      [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy}")]
      [Display(Name = "Data de Nascimento")]
      public DateTime DataNascimento { get; set; }

      [Required(ErrorMessage = "Dado Obrigatório")]
      [DisplayFormat(DataFormatString = "{0:F2}")]
      public double Saldo { get; set; }



   }
}