using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Video_Store_rental.Models;

namespace Video_Store_rental.Models
{
    public partial class VideodbContext : DbContext
    {
        public DbSet<GenresModel> Genres { get; set; } //adds names to the columns
        public DbSet<MovieModel> Movies { get; set; }
        public DbSet<RentalRecordModel> RentalRecords { get; set; }
        public DbSet<CustomerModel> Customers {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql(@"Host=localhost; Database=Videodb;Username=dev; Password=dev");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { }
    }
}
