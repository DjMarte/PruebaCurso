using System.ComponentModel.DataAnnotations;

namespace PrimerProyecto.Models;

public class DiasSemanas
{
    [Key]
    public int DiasSemanasId { get; set; }

    [Required(ErrorMessage = "Campo obligatorio")]
    [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Solo se permiten letras")]
    public string? Dias { get; set; }
}
