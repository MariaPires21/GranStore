using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GranStore.Models;

namespace GranStore.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Categoria Cat1 = new();
        Cat1.Id = 1;
        Cat1.Nome = "Eletrônicos";

        Categoria Cat2 = new();
        Cat2.Id = 2;
        Cat2.Nome = "Roupas";

        List<Produto> produtos = new List<Produto>
        {
            new Produto
            {
                Id = 1,
                Nome = "Smartphone",
                Descricao = "Smartphone de última geração",
                Categoria = Cat1,
                QtdEstoque = 10,
                ValorCusto = 1500.00m,
                ValorVenda = 2000.00m
            },
            new Produto
            {
                Id = 2,
                Nome = "Camisa Polo",
                Descricao = "Camisa polo de algodão",
                Categoria = Cat2,
                QtdEstoque = 20,
                ValorCusto = 50.00m,
                ValorVenda = 80.00m
            }
        };

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
