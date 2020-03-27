using Microsoft.EntityFrameworkCore;
using TestAppForAbb.Core.Models;

namespace TestAppForAbb.DataLayer.Repository
{
    public interface IRepository
    {
        DbSet<Motor> Motors { get; set; }

        DbSet<Measure> Measures { get; set; }

        DbSet<T> Set<T>() where T : class;

        int SaveChanges();
    }
}
