using Microsoft.EntityFrameworkCore;
using PrimerProyecto.Models;

namespace PrimerProyecto.DAL;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options) { }

    public DbSet<Estudiantes> Estudiantes { get; set; }
}
