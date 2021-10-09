
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MinhaDemoMVC.ViewComponents
{

    [ViewComponent(Name = "Carrinho")]
    public class CarrinhoViewComponent : ViewComponent
    {
        public int itensCarrinho { get; set; }

        public CarrinhoViewComponent()
        {
            itensCarrinho = 3; //Simulando o banco de dados
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(itensCarrinho);
        }
    }
}
