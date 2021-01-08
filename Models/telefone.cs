using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Contatos.Models
{
    public class telefone
    {
        [Key]
        [DisplayName("Código")]
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} é obrigatório")]
        [DisplayName("Nome")]
        [MaxLength(100), MinLength(3)]
        public string Nome { get; set; }
        [DisplayName("Tipo")]
        [Display(Name = "Tipo")]
        [Required(ErrorMessage = "Escolha um Tipo de Telefone")]
        public TipoTelefone Tipo { get; set; }
        [Required(ErrorMessage = "{0} é obrigatório")]
        [MaxLength(13), MinLength(10)]
        [DisplayName("Telefone")]
        public string Numero { get; set; }

        public enum TipoTelefone
        {
            [Display(Name = "Celular")]
            Celular = 1,
            [Display(Name = "Residencial")]
            Residencial = 2,
            [Display(Name = "Trabalho")]
            Trabalho = 3,
            [Display(Name = "WhatsApp")]
            WhatsApp = 4,
        }

    }

}