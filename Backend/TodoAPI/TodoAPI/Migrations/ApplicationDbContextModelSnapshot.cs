﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TodoAPI.Data;

#nullable disable

namespace TodoAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TodoAPI.Models.Entity.RefreshToken", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Expires")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Revoked")
                        .HasColumnType("datetime2");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("RefreshTokens");
                });

            modelBuilder.Entity("TodoAPI.Models.Entity.UserAudit", b =>
                {
                    b.Property<Guid>("UserAuditId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("LoginTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LogoutTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserAuditId");

                    b.HasIndex("UserId");

                    b.ToTable("UserAudits");
                });

            modelBuilder.Entity("TodoAPI.Models.Role", b =>
                {
                    b.Property<Guid>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            RoleId = new Guid("f96a963b-0b8f-4083-92f7-f1996a881cfb"),
                            RoleName = "Admin"
                        },
                        new
                        {
                            RoleId = new Guid("25680e27-a078-4a56-bd64-dc3b530bc4f0"),
                            RoleName = "User"
                        });
                });

            modelBuilder.Entity("TodoAPI.Models.TodoItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("TodoItems");
                });

            modelBuilder.Entity("TodoAPI.Models.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = new Guid("2fa0b5dd-b8aa-4928-8219-8416f12138ba"),
                            CreatedAt = new DateTime(2024, 11, 12, 7, 46, 59, 689, DateTimeKind.Utc).AddTicks(583),
                            Email = "admin@example.com",
                            PasswordHash = "$2a$11$r7B0czcVuEQ29pdWaeOkkO/6iBihtnqndnkNV/pRZ2vvbcet0FXTa",
                            UpdatedAt = new DateTime(2024, 11, 12, 7, 46, 59, 689, DateTimeKind.Utc).AddTicks(587),
                            Username = "admin"
                        },
                        new
                        {
                            UserId = new Guid("a638c95a-0508-483b-b686-f7b8f21a5a17"),
                            CreatedAt = new DateTime(2024, 11, 12, 7, 46, 59, 796, DateTimeKind.Utc).AddTicks(1440),
                            Email = "user@example.com",
                            PasswordHash = "$2a$11$RTANhkE7TsrsWoh4IkKdZOe6gPWb0jfTLxG5vixGbHzSDf27okWC6",
                            UpdatedAt = new DateTime(2024, 11, 12, 7, 46, 59, 796, DateTimeKind.Utc).AddTicks(1443),
                            Username = "user"
                        });
                });

            modelBuilder.Entity("TodoAPI.Models.UserRole", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            UserId = new Guid("2fa0b5dd-b8aa-4928-8219-8416f12138ba"),
                            RoleId = new Guid("f96a963b-0b8f-4083-92f7-f1996a881cfb")
                        },
                        new
                        {
                            UserId = new Guid("a638c95a-0508-483b-b686-f7b8f21a5a17"),
                            RoleId = new Guid("25680e27-a078-4a56-bd64-dc3b530bc4f0")
                        });
                });

            modelBuilder.Entity("TodoAPI.Models.Entity.RefreshToken", b =>
                {
                    b.HasOne("TodoAPI.Models.User", "User")
                        .WithMany("RefreshTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TodoAPI.Models.Entity.UserAudit", b =>
                {
                    b.HasOne("TodoAPI.Models.User", "User")
                        .WithMany("UserAudits")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TodoAPI.Models.TodoItem", b =>
                {
                    b.HasOne("TodoAPI.Models.User", "User")
                        .WithMany("TodoItems")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("User");
                });

            modelBuilder.Entity("TodoAPI.Models.UserRole", b =>
                {
                    b.HasOne("TodoAPI.Models.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TodoAPI.Models.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TodoAPI.Models.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("TodoAPI.Models.User", b =>
                {
                    b.Navigation("RefreshTokens");

                    b.Navigation("TodoItems");

                    b.Navigation("UserAudits");

                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
