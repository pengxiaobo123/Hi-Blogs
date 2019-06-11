﻿// <auto-generated />
using HiBlogs.Core.Authorization;
using HiBlogs.EntityFramework.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace HiBlogs.EntityFramework.Migrations
{
    [DbContext(typeof(HiBlogsDbContext))]
    [Migration("20170922101236_initDB")]
    partial class initDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("HiBlogs.Core.Entities.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<DateTime>("CreationTime");

                    b.Property<int>("CreatorUserId");

                    b.Property<int?>("DeleterUserId");

                    b.Property<DateTime?>("DeletionTime");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsForwarding");

                    b.Property<bool>("IsHome");

                    b.Property<bool>("IsMyHome");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

                    b.Property<string>("OldPublishTiem");

                    b.Property<int>("ReadNumber");

                    b.Property<int>("RemarksNumber");

                    b.Property<string>("Title");

                    b.Property<string>("Url");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("HiBlogs.Core.Entities.BlogBlogTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BlogId");

                    b.Property<int>("TagId");

                    b.HasKey("Id");

                    b.HasIndex("BlogId");

                    b.HasIndex("TagId");

                    b.ToTable("BlogBlogTag");
                });

            modelBuilder.Entity("HiBlogs.Core.Entities.BlogBlogType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BlogId");

                    b.Property<int>("TypeId");

                    b.HasKey("Id");

                    b.HasIndex("BlogId");

                    b.HasIndex("TypeId");

                    b.ToTable("BlogBlogType");
                });

            modelBuilder.Entity("HiBlogs.Core.Entities.BlogTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<int>("CreatorUserId");

                    b.Property<string>("Name");

                    b.Property<string>("Remark");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("BlogTag");
                });

            modelBuilder.Entity("HiBlogs.Core.Entities.BlogType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime");

                    b.Property<int>("CreatorUserId");

                    b.Property<string>("Name");

                    b.Property<string>("Remark");

                    b.HasKey("Id");

                    b.HasIndex("CreatorUserId");

                    b.ToTable("BlogType");
                });

            modelBuilder.Entity("HiBlogs.Core.Entities.Remark", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BlogId");

                    b.Property<string>("Content");

                    b.Property<DateTime>("CreationTime");

                    b.Property<int>("CreatorUserId");

                    b.Property<int?>("DeleterUserId");

                    b.Property<DateTime?>("DeletionTime");

                    b.Property<string>("IP");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

                    b.Property<bool>("Top");

                    b.HasKey("Id");

                    b.HasIndex("BlogId");

                    b.ToTable("Remark");
                });

            modelBuilder.Entity("HiBlogs.Core.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("HiBlogs.Core.Entities.RolePermissionName", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PermissionName");

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RolePermissionNames");
                });

            modelBuilder.Entity("HiBlogs.Core.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("CreationTime");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("Nickname");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("OpenId");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<int>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("HiBlogs.Core.Entities.Blog", b =>
                {
                    b.HasOne("HiBlogs.Core.Entities.User", "User")
                        .WithMany()
                       
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HiBlogs.Core.Entities.BlogBlogTag", b =>
                {
                    b.HasOne("HiBlogs.Core.Entities.Blog", "Blog")
                        .WithMany("BlogBlogTags")
                  
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HiBlogs.Core.Entities.BlogTag", "BlogTag")
                        .WithMany("BlogBlogTags")
                   
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HiBlogs.Core.Entities.BlogBlogType", b =>
                {
                    b.HasOne("HiBlogs.Core.Entities.Blog", "Blog")
                        .WithMany("BlogBlogTypes")
                      
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HiBlogs.Core.Entities.BlogType", "BlogType")
                        .WithMany("BlogBlogTypes")
                       
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HiBlogs.Core.Entities.BlogTag", b =>
                {
                    b.HasOne("HiBlogs.Core.Entities.User", "User")
                        .WithMany()
                       
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HiBlogs.Core.Entities.BlogType", b =>
                {
                    b.HasOne("HiBlogs.Core.Entities.User", "User")
                        .WithMany()
                        
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HiBlogs.Core.Entities.Remark", b =>
                {
                    b.HasOne("HiBlogs.Core.Entities.Blog", "Blog")
                        .WithMany("Remarks")
                    
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HiBlogs.Core.Entities.RolePermissionName", b =>
                {
                    b.HasOne("HiBlogs.Core.Entities.Role", "Role")
                        .WithMany("RolePermissionNames")
                    
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("HiBlogs.Core.Entities.Role")
                        .WithMany()
                 
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("HiBlogs.Core.Entities.User")
                        .WithMany()
                       
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("HiBlogs.Core.Entities.User")
                        .WithMany()
                      
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("HiBlogs.Core.Entities.Role")
                        .WithMany()
                       
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HiBlogs.Core.Entities.User")
                        .WithMany()
                       
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("HiBlogs.Core.Entities.User")
                        .WithMany()
                       
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
