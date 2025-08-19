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
        List<Categoria> categorias = new List<Categoria>
        {
            new Categoria {
                Id = 1, Nome = "Romance"
            },
            new Categoria {
                Id = 2, Nome = "Terror"
            },
            new Categoria {
                Id = 3, Nome = "Ficção Científica"
            },
            new Categoria {
                Id = 4, Nome = "Comédia"
            }
        };

        List<Produto> produtos = new List<Produto>
        {
            new Produto {
                Id = 1,
                Foto = "/IMG/1.jpg",
                Nome = "Um Dia",
                Descricao = "A cada capítulo, o livro mostra a vida de Emma e Dexter ao longo dos anos, sempre no mesmo dia. Uma emocionante história de amizade e amor.",
                Autor = "David Nicholls",
                Editora = "Intrínseca",
                Categoria = categorias[0],
                QtdEstoque = 10,
                ValorCusto = 28.00m,
                ValorVenda = 49.90m
            },
            new Produto {
                Id = 2,
                Foto = "/IMG/2.jpg",
                Nome = "Como Eu Era Antes de Você",
                Descricao = "Louisa Clark aceita trabalhar cuidando de Will Traynor, um jovem rico tetraplégico, e ambos têm suas vidas transformadas por esse encontro.",
                Autor = "Jojo Moyes",
                Editora = "Intrínseca",
                Categoria = categorias[1],
                QtdEstoque = 5,
                ValorCusto = 30.00m,
                ValorVenda = 54.90m
            },
            new Produto {
                Id = 3,
                Foto = "/IMG/3.jpg",
                Nome = "It: A Coisa",
                Descricao = "Em uma pequena cidade, um grupo de amigos enfrenta uma entidade maligna que assume várias formas, incluindo o palhaço Pennywise.",
                Autor = "Stephen King",
                Editora = "Suma",
                Categoria = categorias[1],
                QtdEstoque = 5,
                ValorCusto = 45.00m,
                ValorVenda = 89.90m
            },
            new Produto {
                Id = 4,
                Foto = "/IMG/4.jpg",
                Nome = "O Exorcista",
                Descricao = "Um clássico do terror, narrando a luta de padres para salvar uma menina possuída por forças demoníacas.",
                Autor = "William Peter Blatty",
                Editora = "HarperCollins Brasil",
                Categoria = categorias[1],
                QtdEstoque = 5,
                ValorCusto = 32.00m,
                ValorVenda = 59.90m
            },
            new Produto {
                Id = 5,
                Foto = "/IMG/5.jpg",
                Nome = "O Guia do Mochileiro das Galáxias",
                Descricao = "Arthur Dent é salvo pouco antes da destruição da Terra e parte em uma aventura intergaláctica cheia de humor e absurdos.",
                Autor = "Douglas Adams",
                Editora = "Arqueiro",
                Categoria = categorias[1],
                QtdEstoque = 5,
                ValorCusto = 27.00m,
                ValorVenda = 49.90m
            },
            new Produto {
                Id = 6,
                Foto = "/IMG/6.jpg",
                Nome = "Neuromancer",
                Descricao = "Um marco do cyberpunk, trazendo hackers, inteligência artificial e megacorporações em um futuro sombrio.",
                Autor = "William Gibson",
                Editora = "Aleph",
                Categoria = categorias[1],
                QtdEstoque = 5,
                ValorCusto = 35.00m,
                ValorVenda = 64.90m
            },
             new Produto {
                Id = 7,
                Foto = "/IMG/7.jpg",
                Nome = "Diário de um Banana",
                Descricao = "Acompanhe as trapalhadas de Greg Heffley no formato de diário ilustrado, cheio de humor e situações do dia a dia.",
                Autor = "Jeff Kinney",
                Editora = "VR Editora",
                Categoria = categorias[1],
                QtdEstoque = 5,
                ValorCusto = 20.00m,
                ValorVenda = 39.90m
            },
            new Produto {
                Id = 8,
                Foto = "/IMG/8.jpg",
                Nome = "O Homem que Matou Getúlio Vargas",
                Descricao = "Uma sátira histórica cheia de humor, misturando personagens reais e fictícios em situações absurdas.",
                Autor = "Jô Soares",
                Editora = "Companhia das Letras",
                Categoria = categorias[1],
                QtdEstoque = 5,
                ValorCusto = 25.00m,
                ValorVenda = 44.90m
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
