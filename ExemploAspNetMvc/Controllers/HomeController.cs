using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ExemploAspNetMvc.Models;

namespace ExemploAspNetMvc.Controllers;

public class UserRequest
{
    public string Nome { get; set; }
    public string Email { get; set; }
}

public class HomeController : Controller /* Herança (HomeController extende a Classe Controller*/
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index() 
    {
        return View(); /*Chamando a função view*/
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult PrimeiraAction()
    {
        return View();
    }

    public string TesteQueryString([FromQuery] string q, [FromQuery] string nome)
    {
        return $"Chegou aqui {q} e {nome}";
    }

    public string TesteForm([FromForm] UserRequest userRequest)
    {
        return $"Nome: {userRequest.Nome}, E-mail: {userRequest.Email}";
    }

    public IActionResult Form()
    {
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
