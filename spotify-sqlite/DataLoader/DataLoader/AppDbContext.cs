using DataLoader.Configuration;
using DataLoader.Entity;
using Microsoft.EntityFrameworkCore;

namespace DataLoader;

public class AppDbContext : DbContext
{
    private readonly DatabaseSettings _settings;

    public AppDbContext(DatabaseSettings settings)
    {
        _settings = settings;
    }

    public DbSet<TrackEntity> Tracks { get; set; }
    public DbSet<AlbumEntity> Albums { get; set; }
    public DbSet<ArtistEntity> Artists { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(_settings.ConnectionString);
        optionsBuilder.EnableSensitiveDataLogging();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AlbumEntity>()
            .HasMany(a => a.Tracks)
            .WithOne(t => t.Album)
            .HasForeignKey(t => t.AlbumId);

        modelBuilder.Entity<AlbumEntity>()
            .HasMany(a => a.Artists)
            .WithMany(a => a.Albums)
            .UsingEntity(
                "ArtistAlbum",
                l => l.HasOne(typeof(ArtistEntity)).WithMany().HasForeignKey("ArtistId").HasPrincipalKey(nameof(ArtistEntity.ArtistId)),
                r => r.HasOne(typeof(AlbumEntity)).WithMany().HasForeignKey("AlbumId").HasPrincipalKey(nameof(AlbumEntity.AlbumId)),
                j => j.HasKey("ArtistId", "AlbumId"));
    }
}