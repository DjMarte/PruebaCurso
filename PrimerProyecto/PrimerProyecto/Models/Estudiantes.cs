using System.ComponentModel.DataAnnotations;

namespace PrimerProyecto.Models;

public class Estudiantes
{
    [Key]
    public int EstudianteId { get; set; }

    public string? Nombre { get; set; }

    public int Matricula { get; set; }

    public string? Carrera { get; set; }

}
