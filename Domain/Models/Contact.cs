using System;
using System.Collections.Generic;
using Common.Validations;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(60, ErrorMessage = "Este campo deve ter no mínimo 1 caractere e máximo 60")]
        [MinLength(1, ErrorMessage = "Este campo deve ter no mínimo 1 caractere e máximo 60")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(60, ErrorMessage = "Este campo deve ter no mínimo 1 caractere e máximo 60")]
        [MinLength(1, ErrorMessage = "Este campo deve ter no mínimo 1 caractere e máximo 60")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(160, ErrorMessage = "Este campo deve ter no mínimo 1 caractere e máximo 60")]
        [MinLength(1, ErrorMessage = "Este campo deve ter no mínimo 1 caractere e máximo 60")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(13, ErrorMessage = "Este campo deve ter no mínimo 3 caractere e máximo 13")]
        [MinLength(3, ErrorMessage = "Este campo deve ter no mínimo 3 caractere e máximo 13")]
        public string Phone { get; set; }
    }
}
