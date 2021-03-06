using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
   public  class CarContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-CMTU4ECP;Database=CarRental;Integrated Security=true;");
        }
        public DbSet<Car>  Cars { get; set; }
        public DbSet<Brand>   Brands { get; set; }
        public DbSet<Color>  Colors { get; set; }
        public DbSet<CarImage>  CarImages { get; set; }
        public DbSet<Customer>  Customers { get; set; }
        public DbSet<Rental>  Rentals { get; set; }
       // public DbSet<FileUpload>  FileUploads { get; set; }

        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

    }
}
