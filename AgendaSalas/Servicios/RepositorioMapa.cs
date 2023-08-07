
using AgendaSalas.Models;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace AgendaSalas.Servicios
{
    public interface IRepositorioMapa
    {
        Task InsertarEvento(MapaModel mapa);
        string nombre();
    }
    public class RepositorioMapa : IRepositorioMapa
    {
        private readonly string conexionSQL;

        public RepositorioMapa(IConfiguration configuracionDB)
        {
            conexionSQL = configuracionDB.GetConnectionString("DefaultConection");
        }

        public async Task InsertarEvento(MapaModel mapa)
        {
            
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("sala", mapa.sala);
                parameters.Add("titulo", mapa.titulo);
                parameters.Add("agendai", mapa.agendai);
                parameters.Add("agendaf", mapa.agendaf);
                parameters.Add("horainicio", mapa.inicio);
                parameters.Add("horafin", mapa.fin);
                using var conexion = new SqlConnection(conexionSQL);
                await conexion.QueryAsync("InsertarEvento", parameters, commandType: CommandType.StoredProcedure);
            
        }

        public string nombre()
        {
            string name = "Juan Francisco Mejia Hoyo";
            return name;
        }
    }
}
