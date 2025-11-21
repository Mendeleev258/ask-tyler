using AskTyler.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace AskTyler.DataAccess;

public class AskTylerDbContext : DbContext
{
    public DbSet<AnswerEntity> Answers { get; set; }
    public DbSet<QuestionEntity> Questions { get; set; }
    public DbSet<TagEntity> Tags { get; set; }
    public DbSet<UserEntity> Users { get; set; }
    public DbSet<CountryEntity> Countries { get; set; }
    
    public AskTylerDbContext(DbContextOptions<AskTylerDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AnswerEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<AnswerEntity>().HasIndex(x => x.ExternalId).IsUnique();
        modelBuilder.Entity<AnswerEntity>().
            HasOne(x => x.User).
            WithMany(x => x.Answers).
            HasForeignKey(x => x.UserId);
        modelBuilder.Entity<AnswerEntity>().HasOne(x => x.Question)
            .WithMany(x => x.Answers)
            .HasForeignKey(x => x.QusetionId);
        
        modelBuilder.Entity<QuestionEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<QuestionEntity>().HasIndex(x => x.ExternalId).IsUnique();
        modelBuilder.Entity<QuestionEntity>()
            .HasOne(x => x.User)
            .WithMany(x => x.Questions)
            .HasForeignKey(x => x.UserId);
        modelBuilder.Entity<QuestionEntity>()
            .HasOne(x => x.Tag)
            .WithMany(x => x.Questions)
            .HasForeignKey(x => x.TagId);
        
        modelBuilder.Entity<UserEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<UserEntity>().HasIndex(x => x.ExternalId).IsUnique();
        modelBuilder.Entity<UserEntity>().HasIndex(x => x.Email).IsUnique();
        modelBuilder.Entity<UserEntity>().HasIndex(x => x.Username).IsUnique();
        modelBuilder.Entity<UserEntity>()
            .HasOne(x => x.Country)
            .WithMany(x => x.Users)
            .HasForeignKey(x => x.CountryId);
        
        modelBuilder.Entity<CountryEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<CountryEntity>().HasIndex(x => x.ExternalId).IsUnique();
        modelBuilder.Entity<CountryEntity>().HasIndex(x => x.Name).IsUnique();
        
        modelBuilder.Entity<TagEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<TagEntity>().HasIndex(x => x.ExternalId).IsUnique();
        modelBuilder.Entity<TagEntity>().HasIndex(x => x.Name).IsUnique();
        

    }
}