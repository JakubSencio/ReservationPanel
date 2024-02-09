using Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class AppDbContext :  IdentityDbContext<IdentityUser>
    {
        public DbSet<ReservationEntity> Reservations { get; set; }
        public DbSet<OrganizationEntity> Organizations { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<HotelOwner> HotelOwners { get; set; }


        private string DbPath { get; set; }
        private string connectionString { get; set; }
        public AppDbContext()
        {
            connectionString = "data source=Jacob;initial catalog=ASP;trusted_connection=true";
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
        options.UseSqlServer(connectionString);
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);

            string ADMIN_ID = Guid.NewGuid().ToString();
            string ROLE_ID = Guid.NewGuid().ToString();

            // dodanie roli administratora
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "admin",
                NormalizedName = "ADMIN",
                Id = ROLE_ID,
                ConcurrencyStamp = ROLE_ID
            });

            // utworzenie administratora jako użytkownika
            var admin = new IdentityUser
            {
                Id = ADMIN_ID,
                Email = "adam@wsei.edu.pl",
                EmailConfirmed = true,
                UserName = "adam",
                NormalizedUserName = "ADMIN",
                NormalizedEmail = "ADAM@WSEI.EDU.PL"
            };

            // haszowanie hasła
            PasswordHasher<IdentityUser> ph = new PasswordHasher<IdentityUser>();
            admin.PasswordHash = ph.HashPassword(admin, "1234abcd!@#$ABCD");

            // zapisanie użytkownika
            modelBuilder.Entity<IdentityUser>().HasData(admin);

            // przypisanie roli administratora użytkownikowi
            modelBuilder.Entity<IdentityUserRole<string>>()
            .HasData(new IdentityUserRole<string>
            {
                RoleId = ROLE_ID,
                UserId = ADMIN_ID
            });

            string USER_ID = Guid.NewGuid().ToString();
            string USERROLE_ID = Guid.NewGuid().ToString();

            // dodanie roli administratora
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "user",
                NormalizedName = "USER",
                Id = USERROLE_ID,
                ConcurrencyStamp = USERROLE_ID
            });

            // utworzenie administratora jako użytkownika
            var user = new IdentityUser
            {
                Id = USER_ID,
                Email = "malysz@wsei.edu.pl",
                EmailConfirmed = true,
                UserName = "malysz",
                NormalizedUserName = "USER",
                NormalizedEmail = "USER@WSEI.EDU.PL"
            };

            // haszowanie hasła
            PasswordHasher<IdentityUser> pha = new PasswordHasher<IdentityUser>();
            user.PasswordHash = pha.HashPassword(user, "1234abcd!@#$ABCD");
            
            // zapisanie użytkownika
            modelBuilder.Entity<IdentityUser>().HasData(user);

            // przypisanie roli administratora użytkownikowi
            modelBuilder.Entity<IdentityUserRole<string>>()
            .HasData(new IdentityUserRole<string>
            {
                RoleId = USERROLE_ID,
                UserId = USER_ID
            });

            modelBuilder.Entity<ReservationEntity>()
                .HasOne(e => e.Organization)
                .WithMany(o => o.Reservations)
                .HasForeignKey(e => e.OrganizationId);

            modelBuilder.Entity<OrganizationEntity>().HasData(
                 new OrganizationEntity()
                 {
                     Id = 1,
                     Title = "WSEI",
                     Nip = "83492384",
                     Regon = "13424234",
                 },
                 new OrganizationEntity()
                 {
                     Id = 2,
                     Title = "Firma",
                     Nip = "2498534",
                     Regon = "0873439249",
                 }
             ); ;
            modelBuilder.Entity<ReservationEntity>().HasData(
               new ReservationEntity()
               {
                   Id = 1,
                   Name = "AA",
                   Region = "ul. Fiolkowa",
                   City = "Krakow",
                   OrganizationId = 1,

               },
               new ReservationEntity()
               {
                   Id = 2,
                   Name = "C#",
                   Region = "ul. Rozowa",
                   City = "Krakow",
                   OrganizationId = 2,
               }
           );
            modelBuilder.Entity<OrganizationEntity>()
               .OwnsOne(e => e.Address)
               .HasData(
                   new { OrganizationEntityId = 1, City = "Kraków", Street = "Św. Filipa 17", PostalCode = "31-150", Region = "małopolskie" },
                   new { OrganizationEntityId = 2, City = "Kraków", Street = "Krowoderska 45/6", PostalCode = "31-150", Region = "małopolskie" }
               );
            modelBuilder.Entity<HotelOwner>()//name lastname mail reservations
            .HasData
            (
                new HotelOwner() { OwnerId = 1, Name = "Peter", LastName = "Griffin", Mail = "peter.griffin@gmail.com"},
                new HotelOwner() { OwnerId = 2, Name = "Thomas", LastName = "McCwak", Mail = "thomas.mccwak@gmail.com"},
                new HotelOwner() { OwnerId = 3, Name = "Mariusz", LastName = "Pudzianowski", Mail = "mario.pudzilla@pudzian.pl"}
            );
            modelBuilder.Entity<Hotel>() //name adress city stars
            .HasData
            (
                new Hotel() { HotelId = 1, Name = "London Look Hotel", Adress = "ul. Zlota 44" , City = "Warsaw", Stars = 5},
                new Hotel() { HotelId = 2, Name = "Resdient Big Hotel", Adress = "ul. Kaminskiego 1337", City = "Bydgoszcz", Stars = 4},
                new Hotel() { HotelId = 3, Name = "U Pudziana Hotel", Adress = "ul. Leskowiec 4", City = "Biala Rawska", Stars = 5}
            );


            modelBuilder.Entity<HotelOwner>()
          .HasMany(b => b.Hotels) 
          .WithMany(a => a.HotelOwners)
          .UsingEntity
            ( 
            join => join.HasData
            (
                new { HotelOwnersOwnerId = 1, HotelsHotelId = 1 },
                new { HotelOwnersOwnerId = 2, HotelsHotelId = 2 },
                new { HotelOwnersOwnerId = 3, HotelsHotelId = 3 }
            )
           );
        }
    }
}