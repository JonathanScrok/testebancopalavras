using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Site1.Models {
    public class Usuario {
        [Required(ErrorMessage = "O Campo é Obrigatório!")]
        [EmailAddress(ErrorMessage = "O Email é inválido!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O Campo é Obrigatório!")]
        public string Senha { get; set; }
    }
}
