using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using EventosTematicos.Data;

namespace EventosTematicos.Controllers;

public class UserController : Controller
{
    private readonly MySqlDbContext _context;
    public UserController(MySqlDbContext context)
    {
        _context = context;
    }
    
    public IActionResult Index()
    {
        var eventos = _context.EventosTematicos.ToList();
        return View(eventos);
    }
    public IActionResult Create()
    {
        return View();
    }
}