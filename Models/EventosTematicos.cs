using System.ComponentModel.DataAnnotations.Schema;

namespace EventosTematicos.Models;

public class Evento
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    [Column("url_imagen")] 
    public string UrlImagen { get; set; }

    public DateTime Fecha { get; set; }

    [Column("hora_inicio")] 
    public TimeSpan HoraInicio { get; set; }

    [Column("hora_final")] 
    public TimeSpan HoraFin { get; set; }

    public string Ubicacion { get; set; }
    public decimal Precio { get; set; }
    public string Descripcion { get; set; }
    
    public string FechaTransformada => Fecha.ToString("dd/MM/yyyy");
}