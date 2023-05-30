using Microsoft.EntityFrameworkCore;
using MvcCoreSeriesAWSBeanstalk.Data;
using MvcCoreSeriesAWSBeanstalk.Models;

namespace MvcCoreSeriesAWSBeanstalk.Repositories
{
    public class RepositorySeries
    {
        private SeriesContext context;

        public RepositorySeries(SeriesContext context)
        {
            this.context = context;
        }

        public async Task<List<Serie>> GetSeriesAsync()
        {
            return await this.context.Series.ToListAsync();
        }

        private int GetMaxIdSerie()
        {
            return this.context.Series.Max(x => x.IdSerie) + 1;
        }

        public async Task CreateSerieAsync(string nombre, string imagen, int anyo)
        {
            Serie serie = new Serie();
            serie.IdSerie = this.GetMaxIdSerie();
            serie.Nombre = nombre;
            serie.Imagen = imagen;
            serie.Anyo = anyo;
            this.context.Series.Add(serie);
            await this.context.SaveChangesAsync();
        }



    }
}
