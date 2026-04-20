using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using EventosTematicos.Data;
using EventosTematicos.Models;

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
    //Se asigna una nueva etiqueta para que el controlador entienda que tiene que recibir unos parametros
    // sin esto el no va a saber que tiene que recibir 
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    // se pone la etiqueta post para que le haga post a la base de datos y añada 
    // todos los campos dentro de las columnas usando el dbcontext
    [HttpPost]
    public IActionResult Create(Evento evento)
    {
        //llamamos al dbcontext y al modelo que contiene los parametros para añadirlos dentro la base de datos
        _context.EventosTematicos.Add(evento);
        // le decimos al dbcontext que guarde todos los cambios
        _context.SaveChanges();
        // y que redericcione al index a la vista principal
        return RedirectToAction("Index");
    }

    public IActionResult Admin()
    {
        var eventos = _context.EventosTematicos.ToList();
        return View(eventos);
    }
    [HttpGet]
    public IActionResult Edit(int id)
    {
        var evento = _context.EventosTematicos.Find(id);
        return View(evento);
    }
    [HttpPost]
    public IActionResult Edit(Evento evento)
    {
        _context.Update(evento);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
    
    [HttpGet]
    public IActionResult Delete(int id)
    {
        
        var evento = _context.EventosTematicos.Find(id);
        _context.Remove(evento);
        _context.SaveChanges();
        return RedirectToAction("Index");
        
    }
}