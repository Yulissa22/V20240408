using V20240408.AccesoADatos;
using V20240408.EntidadesDeNegocio;

namespace V20240408.LogicaDeNegocio
{
    public class PersonaBL
    {
        readonly PersonaDAL _personaDAL;
        public PersonaBL (PersonaDAL personaDAL)
        {
            _personaDAL = personaDAL;
        }

        public async Task<int> Crear(PersonaV PersonaV)
        {
            return await _personaDAL.Crear(PersonaV);
        }

        public async Task<int> Modificar(PersonaV PersonaV)
        {
            return await _personaDAL.Modificar(PersonaV);
        }

        public async Task<int> Eliminar(PersonaV PersonaV)
        {
            return await _personaDAL.Eliminar(PersonaV);
        }

        public async Task<PersonaV> ObtenerPorId(PersonaV PersonaV)
        {
            return await _personaDAL.ObtenerPorId(PersonaV);
        }

        public async Task<List<PersonaV>> ObtenerTodos()
        {
            return await _personaDAL.ObtenerTodos();
        }

        public async Task<List<PersonaV>> Buscar(PersonaV PersonaV)
        {
            return await _personaDAL.Buscar(PersonaV);
        }
    }
}
