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
                Nome = "Entre Cartas e Destinos",
                Descricao = "Uma história emocionante sobre duas pessoas que se apaixonam por cartas deixadas em uma velha livraria, mesmo sem nunca terem se visto.",
                Autor = "Camila Andrade",
                Editora = "Aurora Literária",
                Categoria = categorias[0],
                QtdEstoque = 10,
                ValorCusto = 30.00m,
                ValorVenda = 50.00m
            },
            new Produto {
                Id = 2,
                Foto = "/IMG/2.jpg",
                Nome = "O Último Verão em Paris",
                Descricao = "Dois jovens descobrem o amor em meio às ruas de Paris, mas precisam enfrentar a distância e o tempo.",
                Autor = "Rafael Monteiro",
                Editora = "Horizonte",
                Categoria = categorias[1],
                QtdEstoque = 5,
                ValorCusto = 40.00m,
                ValorVenda = 70.00m
            },
            new Produto {
                Id = 3,
                Foto = "/IMG/3.jpg",
                Nome = "A Casa dos Sussurros",
                Descricao = "Um grupo de amigos passa a noite em uma mansão abandonada e descobre que alguns segredos não deveriam ser revelados.",
                Autor = "Helena Duarte",
                Editora = "Noite Escura",
                Categoria = categorias[1],
                QtdEstoque = 5,
                ValorCusto = 40.00m,
                ValorVenda = 70.00m
            },
            new Produto {
                Id = 4,
                Foto = "/IMG/4.jpg",
                Nome = "Ecos na Floresta",
                Descricao = "Um casal de campistas se perde em uma floresta densa, mas logo percebe que não estão sozinhos — vozes e sombras os seguem a cada passo.",
                Autor = "Marcos Vidal",
                Editora = "Sangue & Tinta",
                Categoria = categorias[1],
                QtdEstoque = 5,
                ValorCusto = 40.00m,
                ValorVenda = 70.00m
            },
            new Produto {
                Id = 5,
                Foto = "/IMG/5.jpg",
                Nome = "Estação Aurora",
                Descricao = "Em uma estação espacial às margens de Saturno, cientistas descobrem um sinal misterioso que pode ser o primeiro contato com vida extraterrestre.",
                Autor = "Daniel Farias",
                Editora = "Cosmos",
                Categoria = categorias[1],
                QtdEstoque = 5,
                ValorCusto = 40.00m,
                ValorVenda = 70.00m
            },
            new Produto {
                Id = 6,
                Foto = "/IMG/6.jpg",
                Nome = "Viagem ao Planeta Vermelho",
                Descricao = "Um grupo de astronautas parte para Marte em uma missão histórica, mas precisa enfrentar desafios inesperados que colocam a sobrevivência da tripulação em risco.",
                Autor = "Larissa Campos",
                Editora = "Nexus",
                Categoria = categorias[1],
                QtdEstoque = 5,
                ValorCusto = 40.00m,
                ValorVenda = 70.00m
            },
             new Produto {
                Id = 7,
                Foto = "/IMG/7.jpg",
                Nome = "Manual de Como Não Dar Certo",
                Descricao = "A hilária trajetória de um jovem que tenta enriquecer com ideias mirabolantes e sempre acaba em situações desastrosas.",
                Autor = "Felipe Lemos",
                Editora = "Risada Livre",
                Categoria = categorias[1],
                QtdEstoque = 5,
                ValorCusto = 40.00m,
                ValorVenda = 70.00m
            },
            new Produto {
                Id = 8,
                Foto = "/IMG/8.jpg",
                Nome = "A Vovó Hacker",
                Descricao = "Uma senhora de 75 anos descobre que tem um talento incomum para invadir computadores — e decide usá-lo para aprontar na vizinhança.",
                Autor = "Júlia Ferreira",
                Editora = "Alegria Press",
                Categoria = categorias[1],
                QtdEstoque = 5,
                ValorCusto = 40.00m,
                ValorVenda = 70.00m
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
