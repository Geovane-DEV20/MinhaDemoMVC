using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MinhaDemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaDemoMVC.Controllers
{
    [Route("")] //Caso a rota estiver vazia, o mesmo irá na Home.
    [Route("gestao-clientes")] // URL: /Gestao
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("")]
        [Route("pagina-inicial")]
        [Route("pagina-inicial/{id:int}/{categoria:guid}")] // Recebendo parâmetros na rota.

        // Corresponde a um valor Guid válido. (Ex: CD2C1638-1638-72D5-1638-DEADBEEF1638)

        public IActionResult Index(string id, Guid categoria)
        {
            var filme = new Filme
            {
                Título = "Oi",
                DataLancamento = DateTime.Now,
                Genero = null,
                Avaliacao = 10,
                Valor = 20000
            };

            return RedirectToAction("Privacy", filme);
            
        }

        [Route("privacidade")]
        [Route("politica-de-privacidade")]
        public IActionResult Privacy(Filme filme) //O ModelState têm dois propósitos: Armazenar o valor submetido ao servidor. Armazenar os erros de validação associados com esses valores.
        {
            if(ModelState.IsValid)
            {

            }

            foreach (var error in ModelState.Values.SelectMany(m => m.Errors)) // "SelectMany" Vai buscar somentes os erros.
            {
                Console.WriteLine(error.ErrorMessage);
            }
            
            
            //var fileBytes = System.IO.File.ReadAllBytes(@"C:\arquivo.txt");
            //var fileName = "ola.txt";
            //return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);

            //return Json("{'nome':'Geovane'}");
            return View();
        } 

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        
        [Route("erro-encontrado")]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
