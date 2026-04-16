namespace EventosTematicos.Models;

public class Evento
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string UrlImagen { get; set; }
    public DateTime Fecha { get; set; }
    public TimeSpan HoraInicio { get; set; }
    public TimeSpan HoraFin { get; set; }
    public string Ubicacion { get; set; }
    public decimal Precio { get; set; }
    public string Descripcion { get; set; }
    
    public string FechaTransformada => Fecha.ToString("dd/MM/yyyy");

    
}