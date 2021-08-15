using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Site1.Models {
    public class Contato {
        [Required(ErrorMessage ="O Campo é Obrigatório!")]
        [MaxLength(50, ErrorMessage = "O Campo deve possuir no máximo 50 caracteres!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Campo é Obrigatório!")]
        [MaxLength(70, ErrorMessage = "O Campo deve possuir no máximo 70 caracteres!")]
        [EmailAddress(ErrorMessage = "O Email é inválido!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O Campo é Obrigatório!")]
        [MaxLength(70, ErrorMessage = "O Campo deve possuir no máximo 70 caracteres!")]
        public string Assunto { get; set; }

        [Required(ErrorMessage = "O Campo é Obrigatório!")]
        [MaxLength(2000, ErrorMessage = "O Campo deve possuir no máximo 2000 caracteres!")]
        public string Mensagem { get; set; }

    }
}
