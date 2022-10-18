using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_3PMO2.Models
{
    public class PersonaDB
    {
        readonly SQLiteAsyncConnection _connection;
        public PersonaDB(String dbpanth)
        {
            _connection = new SQLiteAsyncConnection(dbpanth);
            _connection.CreateTableAsync<Persona>().Wait();
        }

        // CRUD

        public Task<int> StoreEmple(Persona emple)
        {
            if (emple.id != 0)
            {
                return _connection.UpdateAsync(emple);
            }
            else
            {
                return _connection.InsertAsync(emple);
            }
        }

        public Task<List<Models.Persona>> ListaEmpleados()
        {
            return _connection.Table<Models.Persona>().ToListAsync();
        }

        public Task<Models.Persona> ObtenerEmpleados(int pid)
        {
            return _connection.Table<Models.Persona>()
                .Where(i => i.id == pid)
                .FirstOrDefaultAsync();
        }

        public Task<int> DeleteEmple(Models.Persona emple)
        {
            return _connection.DeleteAsync(emple);
        }
    }
}
