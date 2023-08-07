namespace AgendaSalas.Servicios
{
    public interface IRepositorioCalendario
    {

    }
    
    public class RepositorioCalendario
    {
        private readonly string conexionSQL;
        public RepositorioCalendario (IConfiguration configurationDB)
        {
            conexionSQL = configurationDB.GetConnectionString("DeafulConection");
        }



    }
}
