using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site1.Library.Filters {
    public class LoginAttribute : ActionFilterAttribute{

        public override void OnActionExecuting(ActionExecutingContext context) {
            
            if (context.HttpContext.Session.GetString("Login") == null) {

                if (context.Controller != null) {

                    Controller controlador = context.Controller as Controller;
                    controlador.TempData["MensagemErro"] = "Faça o Login para ter permissão de acessar esta página!";
                }

                context.Result = new RedirectToActionResult("Login", "Home", null);
            }
        }
    }
}
