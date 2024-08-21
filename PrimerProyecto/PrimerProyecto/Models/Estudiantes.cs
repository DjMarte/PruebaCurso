using System.ComponentModel.DataAnnotations;

namespace PrimerProyecto.Models;

public class Estudiantes
{
    [Key]
    public int EstudianteId { get; set; }

    [Required(ErrorMessage = "Nombre Obligatorio")]
    [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Solo se permiten letras")]
    public string? Nombre { get; set; }

    [Required(ErrorMessage = "Matricula obligatoria")]
    [StringLength(9, ErrorMessage = "La matricula solo debe tener 8 digitos")]
    [RegularExpression(@"^\d{4}-\d{4}", ErrorMessage = "La matricula debe tener este formato xxxx-xxxx")]
    public string? Matricula { get; set; }

    [Required(ErrorMessage = "Carrera Obligatorio")]
    [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Solo se permiten letras")]
    public string? Carrera { get; set; }

}
