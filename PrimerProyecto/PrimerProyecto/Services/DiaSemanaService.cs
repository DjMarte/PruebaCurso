using Microsoft.EntityFrameworkCore;
using PrimerProyecto.DAL;
using PrimerProyecto.Models;
using System.Linq.Expressions;

namespace PrimerProyecto.Services;

public class DiaSemanaService(Contexto _contexto)
{
    public async Task<bool> Guardar(DiasSemanas diasSemanas) {
        if(! await Existe(diasSemanas.DiasSemanasId, diasSemanas.Dias))
            return await Insertar(diasSemanas);
        else
            return await Modificar(diasSemanas);
    }

    private async Task<bool> Existe(int diasSemanasId, string dias) {
        return await _contexto.DiasSemanas
            .AnyAsync(d => d.DiasSemanasId == diasSemanasId
            && d.Dias.ToLower().Equals(dias.ToLower()));
    }

    private async Task<bool> Insertar(DiasSemanas diasSemanas) {
        _contexto.DiasSemanas .Add(diasSemanas);
        return await _contexto.SaveChangesAsync() > 0;
    }

    private async Task<bool> Modificar(DiasSemanas diasSemanas) {
        _contexto.Update(diasSemanas);
        var modificado = await _contexto.SaveChangesAsync() > 0;
        _contexto.Entry(diasSemanas).State = EntityState.Modified;
        return modificado;
    }

    public async Task<DiasSemanas?> Buscar(int id) {
        return await _contexto.DiasSemanas
            .AsNoTracking()
            .FirstOrDefaultAsync(d => d.DiasSemanasId == id);
    }

    public async Task<bool> Eliminar(DiasSemanas diasSemanas) {
        return await _contexto.DiasSemanas
            .AsNoTracking()
            .Where(d => d.DiasSemanasId == diasSemanas.DiasSemanasId)
            .ExecuteDeleteAsync() > 0;
    }

    public async Task<List<DiasSemanas>> Listar(Expression<Func<DiasSemanas, bool>> criterio) {
        return await _contexto.DiasSemanas
            .AsNoTracking()
            .Where(criterio)
            .ToListAsync();
    }
}
