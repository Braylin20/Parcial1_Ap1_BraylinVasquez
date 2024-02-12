using Microsoft.EntityFrameworkCore;
using Parcial1_Ap1_BraylinVasquez.Dal;
using Parcial1_Ap1_BraylinVasquez.Models;
using System.Linq.Expressions;

namespace Parcial1_Ap1_BraylinVasquez.Services
{
    public class MetasServices
    {
        public readonly Contexto _contexto;

        public MetasServices(Contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<bool> Guardar(Metas metas)
        {
            int guardo;
            if (metas.MetaId == 0)
            {
                await _contexto.Metas.AddAsync(metas);
                guardo = 1;
            }
            else
            {
                _contexto.Metas.Update(metas);
                guardo = await _contexto.SaveChangesAsync();
                _contexto.Metas.Entry(metas).State = EntityState.Detached;
            }
            return guardo > 0;
        }
        public async Task<bool> Eliminar(int metasId)
        {
            return await _contexto.Metas.AsNoTracking().Where(m => m.MetaId == metasId).ExecuteDeleteAsync() > 0;
        }
        public async Task<Metas?> Buscar(int metasId)
        {
            return await _contexto.Metas.AsNoTracking().FirstOrDefaultAsync(m => m.MetaId == metasId);
        }
        public async Task<List<Metas>> Listar(Expression<Func<Metas, bool>> criterio)
        {
            return await _contexto.Metas.AsNoTracking().Where(criterio).ToListAsync();
        }
    }
}
