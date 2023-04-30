﻿// <auto-generated />
using System;
using MFMS.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MFMS.Infrastructure.Migrations
{
    [DbContext(typeof(EF_DbContext))]
    partial class EF_DbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.3.23174.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("MFMS.Domain.Client", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("id"));

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("contact_number")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("country_id")
                        .HasColumnType("integer");

                    b.Property<string>("created_by")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("created_date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("first_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("gender")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("last_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("modified_by")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("modified_date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("state_id")
                        .HasColumnType("integer");

                    b.Property<bool>("status")
                        .HasColumnType("boolean");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("zip_code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("client");
                });

            modelBuilder.Entity("MFMS.Domain.ClientProfileViewedHistory", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("id"));

                    b.Property<long>("client_id")
                        .HasColumnType("bigint");

                    b.Property<long>("maid_id")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("viewed_date")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("id");

                    b.ToTable("client_profile_viewed_history");
                });

            modelBuilder.Entity("MFMS.Domain.ClientSubscriptionDetail", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("ClientId")
                        .HasColumnType("bigint");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("PendingPoints")
                        .HasColumnType("integer");

                    b.Property<DateTime>("SubscribedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("SubscriptionId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ValidityEndDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("client_subscription_details");
                });

            modelBuilder.Entity("MFMS.Domain.Country", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("status")
                        .HasColumnType("boolean");

                    b.HasKey("id");

                    b.ToTable("country");
                });

            modelBuilder.Entity("MFMS.Domain.Currency", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int>("country_id")
                        .HasColumnType("integer");

                    b.Property<string>("currency_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("status")
                        .HasColumnType("boolean");

                    b.Property<string>("symbol")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("currency");
                });

            modelBuilder.Entity("MFMS.Domain.DocumentType", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("document_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("status")
                        .HasColumnType("boolean");

                    b.HasKey("id");

                    b.ToTable("document_type");
                });

            modelBuilder.Entity("MFMS.Domain.Language", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int>("country_id")
                        .HasColumnType("integer");

                    b.Property<string>("language_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("status")
                        .HasColumnType("boolean");

                    b.HasKey("id");

                    b.ToTable("language");
                });

            modelBuilder.Entity("MFMS.Domain.Maid", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("id"));

                    b.Property<string>("about_maid")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("age")
                        .HasColumnType("integer");

                    b.Property<bool>("availibility")
                        .HasColumnType("boolean");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("comments_by_admin")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("contact_number")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("country_id")
                        .HasColumnType("integer");

                    b.Property<string>("created_by")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("created_date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<byte[]>("document_photo")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<int>("document_type_id")
                        .HasColumnType("integer");

                    b.Property<DateTime>("expected_date_of_availibility")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("first_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("gender")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("is_block_listed")
                        .HasColumnType("boolean");

                    b.Property<bool>("is_verified")
                        .HasColumnType("boolean");

                    b.Property<int>("job_skills_id")
                        .HasColumnType("integer");

                    b.Property<string>("languages_known")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("last_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("modified_by")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("modified_date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("photo")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<string>("reference")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("salary_range_id")
                        .HasColumnType("integer");

                    b.Property<int>("state_id")
                        .HasColumnType("integer");

                    b.Property<bool>("status")
                        .HasColumnType("boolean");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("working_hours_id")
                        .HasColumnType("integer");

                    b.Property<string>("zip_code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("maid");
                });

            modelBuilder.Entity("MFMS.Domain.MaidReview", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("id"));

                    b.Property<long>("cient_id")
                        .HasColumnType("bigint");

                    b.Property<string>("comments")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("created_by")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("created_date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("maid_id")
                        .HasColumnType("bigint");

                    b.Property<string>("modified_by")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("modified_date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("rating")
                        .HasColumnType("integer");

                    b.Property<string>("review")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("maid_reviews");
                });

            modelBuilder.Entity("MFMS.Domain.Movie", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<decimal>("cost")
                        .HasColumnType("numeric");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("movie");
                });

            modelBuilder.Entity("MFMS.Domain.Requirement", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("id"));

                    b.Property<string>("comments_by_admin")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("contact_number")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("created_by")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("created_date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("modified_by")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("modified_date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("requirements")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("requirement");
                });

            modelBuilder.Entity("MFMS.Domain.SalaryRange", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("status")
                        .HasColumnType("boolean");

                    b.HasKey("id");

                    b.ToTable("salary_range");
                });

            modelBuilder.Entity("MFMS.Domain.State", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int>("country_id")
                        .HasColumnType("integer");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("status")
                        .HasColumnType("boolean");

                    b.HasKey("id");

                    b.ToTable("state");
                });

            modelBuilder.Entity("MFMS.Domain.SubscriptionType", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<long>("amount")
                        .HasColumnType("bigint");

                    b.Property<string>("benefits")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("country_id")
                        .HasColumnType("integer");

                    b.Property<string>("created_by")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("created_date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("currency_id")
                        .HasColumnType("integer");

                    b.Property<string>("desciption")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("how_it_works")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("modified_by")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("modified_date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("points")
                        .HasColumnType("integer");

                    b.Property<bool>("status")
                        .HasColumnType("boolean");

                    b.Property<string>("terms_and_conditions")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("validity_duration")
                        .HasColumnType("integer");

                    b.Property<string>("validity_type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("subscription_type");
                });

            modelBuilder.Entity("MFMS.Domain.WorkingHour", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("status")
                        .HasColumnType("boolean");

                    b.HasKey("id");

                    b.ToTable("working_hours");
                });
#pragma warning restore 612, 618
        }
    }
}
