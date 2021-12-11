using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WcfServiceLibraryRequest
{
    public partial class test_databaseContext : DbContext
    {
        public test_databaseContext()
        {
        }

        public test_databaseContext(DbContextOptions<test_databaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Brigade> Brigade { get; set; }
        public virtual DbSet<ManagerTable> ManagerTable { get; set; }
        public virtual DbSet<RequestStateTable> RequestStateTable { get; set; }
        public virtual DbSet<RequestTable> RequestTable { get; set; }
        public virtual DbSet<RequestTypeTable> RequestTypeTable { get; set; }
        public virtual DbSet<Storage> Storage { get; set; }
        public virtual DbSet<StorageItem> StorageItem { get; set; }
        public virtual DbSet<StreetTable> StreetTable { get; set; }
        public virtual DbSet<SystemAdministratorTable> SystemAdministratorTable { get; set; }
        public virtual DbSet<Worker> Worker { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=test_database;Username=postgres;Password=1234");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brigade>(entity =>
            {
                entity.HasKey(e => e.IdBrigade)
                    .HasName("brigade_pkey");

                entity.ToTable("brigade");

                entity.Property(e => e.IdBrigade).HasColumnName("id_brigade");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ManagerTable>(entity =>
            {
                entity.HasKey(e => e.IdManager)
                    .HasName("manager_table_pkey");

                entity.ToTable("manager_table");

                entity.Property(e => e.IdManager).HasColumnName("id_manager");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(500);

                entity.Property(e => e.Percent).HasColumnName("percent");
            });

            modelBuilder.Entity<RequestStateTable>(entity =>
            {
                entity.HasKey(e => e.IdRequestState)
                    .HasName("request_state_table_pkey");

                entity.ToTable("request_state_table");

                entity.Property(e => e.IdRequestState).HasColumnName("id_request_state");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnName("state")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<RequestTable>(entity =>
            {
                entity.HasKey(e => e.IdRequest)
                    .HasName("request_table_pkey");

                entity.ToTable("request_table");

                entity.Property(e => e.IdRequest).HasColumnName("id_request");

                entity.Property(e => e.AccountBalance).HasColumnName("account_balance");

                entity.Property(e => e.Apartment)
                    .HasColumnName("apartment")
                    .HasMaxLength(255);

                entity.Property(e => e.CommentForRequest)
                    .HasColumnName("comment_for_request")
                    .HasMaxLength(500);

                entity.Property(e => e.CommentMechanic)
                    .HasColumnName("comment_mechanic")
                    .HasMaxLength(500);

                entity.Property(e => e.CountTv).HasColumnName("count_tv");

                entity.Property(e => e.DateCreate)
                    .HasColumnName("date_create")
                    .HasColumnType("timestamp(0) without time zone");

                entity.Property(e => e.DateOfCompletion).HasColumnName("date_of_completion");

                entity.Property(e => e.FioClient)
                    .HasColumnName("fio_client")
                    .HasMaxLength(255);

                entity.Property(e => e.House)
                    .HasColumnName("house")
                    .HasMaxLength(255);

                entity.Property(e => e.IdBrigade).HasColumnName("id_brigade");

                entity.Property(e => e.IdManager).HasColumnName("id_manager");

                entity.Property(e => e.IdRequestState).HasColumnName("id_request_state");

                entity.Property(e => e.IdRequestType).HasColumnName("id_request_type");

                entity.Property(e => e.IdStreet).HasColumnName("id_street");

                entity.Property(e => e.IdSystemAdministrator).HasColumnName("id_system_administrator");

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("phone_number")
                    .HasColumnType("character varying");

                entity.Property(e => e.Ping)
                    .HasColumnName("ping")
                    .HasMaxLength(64);

                entity.Property(e => e.Port)
                    .HasColumnName("port")
                    .HasMaxLength(10);

                entity.Property(e => e.Review)
                    .HasColumnName("review")
                    .HasMaxLength(500);

                entity.Property(e => e.Speed)
                    .HasColumnName("speed")
                    .HasMaxLength(64);

                entity.HasOne(d => d.IdBrigadeNavigation)
                    .WithMany(p => p.RequestTable)
                    .HasForeignKey(d => d.IdBrigade)
                    .HasConstraintName("request_table_id_brigade_fkey");

                entity.HasOne(d => d.IdManagerNavigation)
                    .WithMany(p => p.RequestTable)
                    .HasForeignKey(d => d.IdManager)
                    .HasConstraintName("request_table_id_manager_fkey");

                entity.HasOne(d => d.IdRequestStateNavigation)
                    .WithMany(p => p.RequestTable)
                    .HasForeignKey(d => d.IdRequestState)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("request_table_id_request_state_fkey");

                entity.HasOne(d => d.IdRequestTypeNavigation)
                    .WithMany(p => p.RequestTable)
                    .HasForeignKey(d => d.IdRequestType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("request_table_id_request_type_fkey");

                entity.HasOne(d => d.IdStreetNavigation)
                    .WithMany(p => p.RequestTable)
                    .HasForeignKey(d => d.IdStreet)
                    .HasConstraintName("request_table_id_street_fkey");

                entity.HasOne(d => d.IdSystemAdministratorNavigation)
                    .WithMany(p => p.RequestTable)
                    .HasForeignKey(d => d.IdSystemAdministrator)
                    .HasConstraintName("request_table_id_system_administrator_fkey");
            });

            modelBuilder.Entity<RequestTypeTable>(entity =>
            {
                entity.HasKey(e => e.IdRequestType)
                    .HasName("request_type_table_pkey");

                entity.ToTable("request_type_table");

                entity.Property(e => e.IdRequestType).HasColumnName("id_request_type");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Storage>(entity =>
            {
                entity.HasKey(e => e.IdStorage)
                    .HasName("storage_pkey");

                entity.ToTable("storage");

                entity.Property(e => e.IdStorage).HasColumnName("id_storage");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.IdStorageItem).HasColumnName("id_storage_item");

                entity.HasOne(d => d.IdStorageItemNavigation)
                    .WithMany(p => p.Storage)
                    .HasForeignKey(d => d.IdStorageItem)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("storage_id_storage_item_fkey");
            });

            modelBuilder.Entity<StorageItem>(entity =>
            {
                entity.HasKey(e => e.IdStorageItem)
                    .HasName("item_pkey");

                entity.ToTable("storage_item");

                entity.Property(e => e.IdStorageItem)
                    .HasColumnName("id_storage_item")
                    .HasDefaultValueSql("nextval('item_id_item_seq'::regclass)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<StreetTable>(entity =>
            {
                entity.HasKey(e => e.IdStreet)
                    .HasName("street_table_pkey");

                entity.ToTable("street_table");

                entity.Property(e => e.IdStreet).HasColumnName("id_street");

                entity.Property(e => e.Street)
                    .IsRequired()
                    .HasColumnName("street")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<SystemAdministratorTable>(entity =>
            {
                entity.HasKey(e => e.IdSystemAdministrator)
                    .HasName("system_administrator_table_pkey");

                entity.ToTable("system_administrator_table");

                entity.Property(e => e.IdSystemAdministrator).HasColumnName("id_system_administrator");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Worker>(entity =>
            {
                entity.HasKey(e => e.IdWorker)
                    .HasName("worker_pkey");

                entity.ToTable("worker");

                entity.Property(e => e.IdWorker).HasColumnName("id_worker");

                entity.Property(e => e.IdBrigade).HasColumnName("id_brigade");

                entity.Property(e => e.Login)
                    .HasColumnName("login")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(500);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(255);

                entity.Property(e => e.Percent).HasColumnName("percent");

                entity.HasOne(d => d.IdBrigadeNavigation)
                    .WithMany(p => p.Worker)
                    .HasForeignKey(d => d.IdBrigade)
                    .HasConstraintName("worker_id_brigade_fkey");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
