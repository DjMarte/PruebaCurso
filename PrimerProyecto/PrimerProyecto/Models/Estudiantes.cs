using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrimerProyecto.Models;

public class Estudiantes
{
    [Key]
    public int EstudianteId { get; set; }

    [Required(ErrorMessage = "Nombre Obligatorio")]
    [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Solo se permiten letras")]
    public string? Nombre { get; set; }

    [Required(ErrorMessage = "Matricula obligatoria")]
    [StringLength(9, ErrorMessage = "La matricula solo debe tener 9 digitos")]
    [RegularExpression(@"^\d{4}-\d{4}", ErrorMessage = "La matricula debe tener este formato xxxx-xxxx")]
    public string? Matricula { get; set; }

    [Required(ErrorMessage = "Carrera Obligatorio")]
    [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Solo se permiten letras")]
    public string? Carrera { get; set; }

    [ForeignKey("DiasSemanasId")]
    public int DiaId { get; set; }
    public DiasSemanas? DiasSemana { get; set; }
}
