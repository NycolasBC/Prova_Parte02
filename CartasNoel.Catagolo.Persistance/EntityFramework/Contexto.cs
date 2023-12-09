using CartasNoel.Catalogo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartasNoel.Catagolo.Persistance.EntityFramework
{
    public class Contexto : DbContext
    {
        #region - Atributo e construtor

        private readonly DatabaseSettings _databaseSettings;

        public Contexto(DbContextOptions<Contexto> options, IOptions<DatabaseSettings> databaseSettings)
            : base(options)
        {
            _databaseSettings = databaseSettings.Value;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_databaseSettings.ConnectionString);
        }

        #endregion

        public DbSet<Cartas> Cartas { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CartasConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
