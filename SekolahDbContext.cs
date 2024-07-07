using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latih10_KonekDataBase
{
    public class SekolahDbContext : DbContext
    {
        public DbSet<SiswaModel> siswa1 { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=localhost;Database=sekolah;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
