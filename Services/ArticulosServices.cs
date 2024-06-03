using Ap1_P1_RalfyGenao.DAL;
using Ap1_P1_RalfyGenao.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;

namespace Ap1_P1_RalfyGenao.Services
{
    public class ArticulosServices
    {
        private readonly Contexto _contexto;

        public ArticulosServices(Contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<bool> Existe(int Articulos)
        {
            return await _contexto.Articulos.AnyAsync(A => A.ArticuloId == Articulos);

        }
        public async Task<bool> Existe(string? Descripcion)
        {
            return await _contexto.Articulos.AnyAsync(A => A.Descripcion == Descripcion);
        }
        private async Task<bool> Insertar(Articulos articulos)
        {

            _contexto.Articulos.Add(articulos);
            return await _contexto.SaveChangesAsync() > 0;
        }

        private async Task<bool> Modificar(Articulos articulos)
        {
            _contexto.Articulos.Update(articulos);
            return await _contexto.SaveChangesAsync() > 0;
        }
        public async Task<bool> Guardar(Articulos articulos)
        {
            if (!await Existe(articulos.ArticuloId))
                return await Insertar(articulos);
            else
                return await Modificar(articulos);
        }
        public async Task<bool> Eliminar(int id)
        {

            var Articulos = await _contexto.Articulos.FindAsync(id);
            if (Articulos == null)
                return false;

            _contexto.Articulos.Remove(Articulos);
            return await _contexto.SaveChangesAsync() > 0;
        }
        public async Task<Articulos?> Buscar(int id)
        {

            return await _contexto.Articulos.AsNoTracking().FirstOrDefaultAsync(A => A.ArticuloId == id);

        }
        public async Task<List<Articulos>> Listar(Expression<Func<Articulos, bool>> criterio)
        {

            return await _contexto.Articulos.AsNoTracking().Where(criterio).ToListAsync();
        }
    }
}
