using Microsoft.EntityFrameworkCore;
using V20240408.EntidadesDeNegocio;

namespace V20240408.AccesoADatos
{
    public class PersonaDAL
    {
        readonly AppDbContext _appDbContext;
        public PersonaDAL (AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<int> Crear(PersonaV PersonaV)
        {
            _appDbContext.Add(PersonaV);
            return await _appDbContext.SaveChangesAsync();
        }
        public async Task<int> Modificar(PersonaV PersonaV)
        {
            var clienteData = await _appDbContext.PersonaV.FirstOrDefaultAsync(s => s.Id == PersonaV.Id);
            if (clienteData != null)
            {
                clienteData.NombreV = PersonaV.NombreV;
                clienteData.ApellidoV = PersonaV.ApellidoV;
                clienteData.FechaNacimientoV = PersonaV.FechaNacimientoV;
                clienteData.sueldoV = PersonaV.sueldoV;
                clienteData.EstatusV = PersonaV.EstatusV;
                clienteData.ComentarioV = PersonaV.ComentarioV;
                _appDbContext.Update(clienteData);
            }
            return await _appDbContext.SaveChangesAsync();
        }
        public async Task<int> Eliminar(PersonaV cliente)
        {
            var clienteData = await _appDbContext.PersonaV.FirstOrDefaultAsync(s => s.Id == cliente.Id);
            if (clienteData != null)
                _appDbContext.Remove(clienteData);
            return await _appDbContext.SaveChangesAsync();
        }

        public async Task<PersonaV> ObtenerPorId(PersonaV PersonaV)
        {
            var clienteData = await _appDbContext.PersonaV.FirstOrDefaultAsync(s => s.Id == PersonaV.Id);
            if (clienteData != null)
                return clienteData;
            else
                return new PersonaV();
        }
        public async Task<List<PersonaV>> ObtenerTodos()
        {
            return await _appDbContext.PersonaV.ToListAsync();
        }
        public async Task<List<PersonaV>> Buscar(PersonaV PersonaV)
        {

            var query = _appDbContext.PersonaV.AsQueryable();
            if (!string.IsNullOrWhiteSpace(PersonaV.NombreV))
            {
                query = query.Where(s => s.NombreV.Contains(PersonaV.NombreV));
            }
            if (!string.IsNullOrWhiteSpace(PersonaV.ApellidoV))
            {
                query = query.Where(s => s.ApellidoV.Contains(PersonaV.ApellidoV));
            }
            return await query.ToListAsync();
        }
    }
}
