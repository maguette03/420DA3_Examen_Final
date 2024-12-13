using _420DA3_Examen_Final.Business.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_Examen_Final.DataAccess
{
    internal class MyDbContext :DbContext
    {

        public DbSet<Auteur> Auteurs {  get; set; }
        public DbSet<Livre> livres { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string connectionString = ConfigurationManager.ConnectionStrings["ExamenDatabase"].ConnectionString;

            optionsBuilder
                .UseSqlServer(connectionString)
                .UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //configuration des entites
            _ = modelBuilder.Entity<Auteur>()
                .ToTable(nameof(Auteurs))
                .HasKey(a => a.Id);

            _= modelBuilder.Entity<Livre>()
                .ToTable(nameof(livres))
                .HasKey(l => l.Id);

            //configuration des colones 
            _ = modelBuilder.Entity<Auteur>()
                .Property(a => a.Id)
                .HasColumnName(nameof(Auteur.Id))
                .HasColumnOrder(0)
                .HasColumnType("int")
                .UseIdentityColumn(1, 1);

            _ = modelBuilder.Entity<Auteur>()
                .Property(a => a.FirstName)
                .HasColumnName(nameof(Auteur.FirstName))
                .HasColumnOrder(1)
                .HasColumnType($"nvarchar({Auteur.MAX_LENGTH_FIRSTNAME})")
                .IsRequired(true);

            _ = modelBuilder.Entity<Auteur>()
               .Property(a => a.LastName)
               .HasColumnName(nameof(Auteur.LastName))
                .HasColumnOrder(2)
               .HasColumnType($"nvarchar({Auteur.MAX_LENGTH_LASTNAME})")
            .IsRequired(true);

            _ = modelBuilder.Entity<Auteur>()
               .Property(a => a.RowVersion)
               .HasColumnName(nameof(Auteur.RowVersion))
               .HasColumnOrder(3)
               .IsRowVersion();


            //Pour livre
            _ = modelBuilder.Entity<Livre>()
               .Property(l => l.Id)
               .HasColumnName(nameof(Livre.Id))
               .HasColumnOrder(0)
               .HasColumnType("int")
               .UseIdentityColumn(1, 1);


            _ = modelBuilder.Entity<Livre>()
                .Property(l => l.Titre)
                .HasColumnName(nameof(Livre.Titre))
                .HasColumnOrder(1)
                .HasColumnType($"nvarchar({Livre.MAX_LENGTH_TITRE})")
                .IsRequired(true);

            _ = modelBuilder.Entity<Livre>()
                .Property(l => l.Isbn)
                .HasColumnName(nameof(Livre.Isbn))
                .HasColumnOrder(2)
                .HasColumnType($"nvarchar({Livre.MAX_LENGTH_ISBN})")
                .IsRequired(true);


            _ = modelBuilder.Entity<Livre>()
                .Property(l => l.RowVersion)
                .HasColumnName(nameof(Livre.RowVersion))
                .HasColumnOrder(3)
                .IsRowVersion();

            Auteur aut1 = new Auteur { Id = 1, FirstName = "Isaac", LastName = "Asimov" };
            Auteur aut2 = new Auteur { Id = 2, FirstName = "Alastair", LastName = "Reynolds" };
            Auteur aut3 = new Auteur { Id = 3, FirstName = "Peter F", LastName = "Hamilton" };

            _ = modelBuilder.Entity<Auteur>()
                .HasData(aut1, aut2, aut3);

            Livre liv1 = new Livre { Id = 1, Titre = "Foundation", Isbn = "978-0-553-29335-7" };
            Livre liv2 = new Livre { Id = 2, Titre = "Revelation Space ", Isbn = "978-0-575-06875-9" };

            _ = modelBuilder.Entity<Livre>()
                .HasData(liv1, liv2);


            _ = modelBuilder.Entity<Auteur>()
                .HasMany(a => a.Livres)
                .WithMany(l => l.Auteurs)
                .UsingEntity(
                    "AuteursLivres",
                    leftRel => leftRel.HasOne(typeof(Livre)).WithMany().HasForeignKey("LivreId"),
                    righRel => righRel.HasOne(typeof(Auteur)).WithMany().HasForeignKey("AuteurId"),
                    conf =>
                    {
                        conf.ToTable("AuteursLivres").HasKey("AuteurId", "LivreId");
                        conf.HasData(
                           new { AuteurId = 1, LivreId = 1 },
                           new { AuteurId = 2, LivreId = 2 }
                        );
                    }
                );

        }
    }
}
