using Site1.Library.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Site1.Models {
    public class Palavra {
        
        public int Id { get; set; }

        [Required(ErrorMessage = "O Campo é Obrigatório!")]
        [MaxLength(20, ErrorMessage = "O Campo deve possuir no máximo 20 caracteres!")]
        [UnicoNomePalavra]
        public string Nome { get; set; }

        //1-Fácil, 2-Médio, 3-Difícil
        public byte? Nivel { get; set; }
    }
}
