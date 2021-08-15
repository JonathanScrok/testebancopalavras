using Site1.Database;
using Site1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Site1.Library.Validation {
    public class UnicoNomePalavraAttribute : ValidationAttribute {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext) {

            Palavra palavra = validationContext.ObjectInstance as Palavra;
            var _db = (DatabaseContext)validationContext.GetService(typeof(DatabaseContext));



            //Já existe no banco 1 registro:
            // - Verificar se o nome existe
            // - Verificar se o Id é o mesmo do registro no banco.

            var palavraBanco =_db.Palavras.Where(a => a.Nome == palavra.Nome && a.Id != palavra.Id).FirstOrDefault();

            if (palavraBanco == null) {
                return ValidationResult.Success;
            } else {
                return new ValidationResult("A palavra "+palavra.Nome+" já está cadastrada!");
            }
        }
    }
}
