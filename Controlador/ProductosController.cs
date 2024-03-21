using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM2Parcial3.Controlador
{
    public class ProductosController
    {
        readonly SQLiteAsyncConnection _connection;
        public ProductosController() {
            SQLite.SQLiteOpenFlags extensiones = SQLite.SQLiteOpenFlags.ReadWrite |
                                                SQLite.SQLiteOpenFlags.Create |
                                                SQLite.SQLiteOpenFlags.SharedCache;

            _connection = new SQLiteAsyncConnection(Path.Combine(FileSystem.AppDataDirectory, "DBProducto.db3"), extensiones);
            _connection.CreateTableAsync<Models.Procuctossql>().Wait();
        }
        public async Task<int> StoreSitios(Models.Procuctossql productos)
        {

            if (productos.Id == 0)
            {
                return await _connection.InsertAsync(productos);
            }
            else
            {
                return await _connection.UpdateAsync(productos);
            }
        }
    }
}
