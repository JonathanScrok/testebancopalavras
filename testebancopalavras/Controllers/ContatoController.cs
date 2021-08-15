using Microsoft.AspNetCore.Mvc;
using Site1.Library.Mail;
using Site1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site1.Controllers {
    public class ContatoController : Controller {
        public IActionResult Index() {
            ViewBag.Contato = new Contato();

            return View();
        }

        public IActionResult ReceberContato([FromForm] Contato contato) {

            if (ModelState.IsValid) {
                //string conteudo = string.Format("Nome: {0}, Email: {1}, Assunto: {2}, Mensagem: {3}", contato.Nome, contato.Email, contato.Assunto, contato.Mensagem);
                //return new ContentResult() { Content = conteudo };

                EnviarEmail.EnviarMensagemContato(contato);

                ViewBag.Contato = new Contato();

                ViewBag.Mesagem = "Mensagem enviada com sucesso!";
                return View("Index");

            } else {
                ViewBag.Contato = contato;

                return View("Index");

            }


        }

        /* Obter Dados Manualmente

        public IActionResult ReceberContato() {

            //POST - Request.Form
            //GET - Request.Query ou Request.QueryString
            Contato contato = new Contato();
            contato.Nome = Request.Form["nome"];
            contato.Email = Request.Form["email"];
            contato.Assunto = Request.Form["assunto"];
            contato.Mensagem = Request.Form["mensagem"];

            string conteudo = string.Format("Nome: {0}, Email: {1}, Assunto: {2}, Mensagem: {3}", contato.Nome, contato.Email, contato.Assunto, contato.Mensagem);
            return new ContentResult() { Content = conteudo };
        }
        */
    }
}
