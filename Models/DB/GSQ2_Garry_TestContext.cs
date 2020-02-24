using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CarDealershipSystem.Models.DB
{
    public partial class GSQ2_Garry_TestContext : DbContext
    {
        public GSQ2_Garry_TestContext()
        {
        }

        public GSQ2_Garry_TestContext(DbContextOptions<GSQ2_Garry_TestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Car> Car { get; set; }
        public virtual DbSet<CarFeature> CarFeature { get; set; }
        public virtual DbSet<CarFeatures> CarFeatures { get; set; }
        public virtual DbSet<CarModel> CarModel { get; set; }
        public virtual DbSet<CarSaleRecord> CarSaleRecord { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Person> Person { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
              optionsBuilder.UseSqlServer("Server=citizen.manukautech.info,6302;Initial Catalog=GSQ2_Garry_Test;Persist Security Info=True;User ID=GSQ2_Garry;Password=fBit$67975;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Car>(entity =>
            {
                entity.Property(e => e.CarId).HasColumnName("CarID");

                entity.Property(e => e.BodyType)
                    .IsRequired()
                    .HasColumnName("Body_Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CarModelId).HasColumnName("Car_Model_ID");

                entity.Property(e => e.Colour)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentMileage)
                    .IsRequired()
                    .HasColumnName("Current_Mileage")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DateImported)
                    .HasColumnName("Date_Imported")
                    .HasColumnType("date");

                entity.Property(e => e.ManufacturerYear).HasColumnName("Manufacturer_Year");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Transmission)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CarModel)
                    .WithMany(p => p.Car)
                    .HasForeignKey(d => d.CarModelId)
                    .HasConstraintName("FK_Car_CarModel");
            });

            modelBuilder.Entity<CarFeature>(entity =>
            {
                entity.ToTable("Car_Feature");

                entity.Property(e => e.CarFeatureId).HasColumnName("Car_Feature_ID");

                entity.Property(e => e.Feature)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CarFeatures>(entity =>
            {
                entity.HasKey(e => new { e.CarId, e.CarFeatureId });

                entity.Property(e => e.CarId).HasColumnName("Car_ID");

                entity.Property(e => e.CarFeatureId).HasColumnName("Car_Feature_ID");

                entity.HasOne(d => d.CarFeature)
                    .WithMany(p => p.CarFeatures)
                    .HasForeignKey(d => d.CarFeatureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CarFeatures_Car_Feature");

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.CarFeatures)
                    .HasForeignKey(d => d.CarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CarFeatures_Car");
            });

            modelBuilder.Entity<CarModel>(entity =>
            {
                entity.HasKey(e => e.ModelId);

                entity.Property(e => e.ModelId).HasColumnName("ModelID");

                entity.Property(e => e.EngineSize)
                    .IsRequired()
                    .HasColumnName("Engine_Size")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Manufacturer)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CarSaleRecord>(entity =>
            {
                entity.HasKey(e => e.SaleRecordId);

                entity.ToTable("Car_Sale_Record");

                entity.Property(e => e.SaleRecordId).HasColumnName("Sale_Record_ID");

                entity.Property(e => e.CarId).HasColumnName("CarID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Note)
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.PuchaseDate)
                    .HasColumnName("Puchase_Date")
                    .HasColumnType("date");

                entity.Property(e => e.TotalPaidPrice)
                    .HasColumnName("Total_Paid_Price")
                    .HasColumnType("money");

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.CarSaleRecord)
                    .HasForeignKey(d => d.CarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Car_Sale_Record_Car");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CarSaleRecord)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Car_Sale_Record_Customer");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.CustomerId)
                    .HasColumnName("CustomerID")
                    .ValueGeneratedNever();

                entity.Property(e => e.LicenceExpiryDate)
                    .HasColumnName("Licence_Expiry_Date")
                    .HasColumnType("date");

                entity.Property(e => e.LicenceNumber)
                    .IsRequired()
                    .HasColumnName("Licence_Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CustomerNavigation)
                    .WithOne(p => p.Customer)
                    .HasForeignKey<Customer>(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customer_Person");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.OfficeAddress)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneExtension)
                    .IsRequired()
                    .HasColumnName("Phone_Extension")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.EmployeeNavigation)
                    .WithOne(p => p.Employee)
                    .HasForeignKey<Employee>(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employee_Person");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
