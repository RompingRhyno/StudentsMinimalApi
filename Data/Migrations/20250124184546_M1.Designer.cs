﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentsMinimalApi.Data;

#nullable disable

namespace StudentsMinimalApi.Data.Migrations
{
    [DbContext(typeof(SchoolDbContext))]
    [Migration("20250124184546_M1")]
    partial class M1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.1");

            modelBuilder.Entity("StudentsMinimalApi.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("School")
                        .HasColumnType("TEXT");

                    b.HasKey("StudentId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            FirstName = "Tom",
                            LastName = "Max",
                            School = "Nursing"
                        },
                        new
                        {
                            StudentId = 2,
                            FirstName = "Ann",
                            LastName = "Fay",
                            School = "Mining"
                        },
                        new
                        {
                            StudentId = 3,
                            FirstName = "Joe",
                            LastName = "Sun",
                            School = "Nursing"
                        },
                        new
                        {
                            StudentId = 4,
                            FirstName = "Sue",
                            LastName = "Fox",
                            School = "Computing"
                        },
                        new
                        {
                            StudentId = 5,
                            FirstName = "Ben",
                            LastName = "Ray",
                            School = "Mining"
                        },
                        new
                        {
                            StudentId = 6,
                            FirstName = "Zoe",
                            LastName = "Cox",
                            School = "Business"
                        },
                        new
                        {
                            StudentId = 7,
                            FirstName = "Sam",
                            LastName = "Ray",
                            School = "Mining"
                        },
                        new
                        {
                            StudentId = 8,
                            FirstName = "Dan",
                            LastName = "Ash",
                            School = "Medicine"
                        },
                        new
                        {
                            StudentId = 9,
                            FirstName = "Pat",
                            LastName = "Lee",
                            School = "Computing"
                        },
                        new
                        {
                            StudentId = 10,
                            FirstName = "Kim",
                            LastName = "Day",
                            School = "Nursing"
                        },
                        new
                        {
                            StudentId = 11,
                            FirstName = "Tim",
                            LastName = "Rex",
                            School = "Computing"
                        },
                        new
                        {
                            StudentId = 12,
                            FirstName = "Rob",
                            LastName = "Ram",
                            School = "Nursing"
                        },
                        new
                        {
                            StudentId = 13,
                            FirstName = "Jan",
                            LastName = "Fry",
                            School = "Mining"
                        },
                        new
                        {
                            StudentId = 14,
                            FirstName = "Jim",
                            LastName = "Tex",
                            School = "Nursing"
                        },
                        new
                        {
                            StudentId = 15,
                            FirstName = "Ben",
                            LastName = "Kid",
                            School = "Business"
                        },
                        new
                        {
                            StudentId = 16,
                            FirstName = "Mia",
                            LastName = "Chu",
                            School = "Medicine"
                        },
                        new
                        {
                            StudentId = 17,
                            FirstName = "Ted",
                            LastName = "Tao",
                            School = "Computing"
                        },
                        new
                        {
                            StudentId = 18,
                            FirstName = "Amy",
                            LastName = "Day",
                            School = "Nursing"
                        },
                        new
                        {
                            StudentId = 19,
                            FirstName = "Ian",
                            LastName = "Roy",
                            School = "Nursing"
                        },
                        new
                        {
                            StudentId = 20,
                            FirstName = "Liz",
                            LastName = "Kit",
                            School = "Nursing"
                        },
                        new
                        {
                            StudentId = 21,
                            FirstName = "Mat",
                            LastName = "Tan",
                            School = "Medicine"
                        },
                        new
                        {
                            StudentId = 22,
                            FirstName = "Deb",
                            LastName = "Roy",
                            School = "Medicine"
                        },
                        new
                        {
                            StudentId = 23,
                            FirstName = "Ana",
                            LastName = "Ray",
                            School = "Mining"
                        },
                        new
                        {
                            StudentId = 24,
                            FirstName = "Lyn",
                            LastName = "Poe",
                            School = "Computing"
                        },
                        new
                        {
                            StudentId = 25,
                            FirstName = "Amy",
                            LastName = "Raj",
                            School = "Nursing"
                        },
                        new
                        {
                            StudentId = 26,
                            FirstName = "Kim",
                            LastName = "Ash",
                            School = "Mining"
                        },
                        new
                        {
                            StudentId = 27,
                            FirstName = "Bec",
                            LastName = "Kid",
                            School = "Nursing"
                        },
                        new
                        {
                            StudentId = 28,
                            FirstName = "Eva",
                            LastName = "Fry",
                            School = "Computing"
                        },
                        new
                        {
                            StudentId = 29,
                            FirstName = "Eli",
                            LastName = "Lap",
                            School = "Business"
                        },
                        new
                        {
                            StudentId = 30,
                            FirstName = "Sam",
                            LastName = "Yim",
                            School = "Nursing"
                        },
                        new
                        {
                            StudentId = 31,
                            FirstName = "Joe",
                            LastName = "Hui",
                            School = "Mining"
                        },
                        new
                        {
                            StudentId = 32,
                            FirstName = "Liz",
                            LastName = "Jin",
                            School = "Nursing"
                        },
                        new
                        {
                            StudentId = 33,
                            FirstName = "Ric",
                            LastName = "Kuo",
                            School = "Business"
                        },
                        new
                        {
                            StudentId = 34,
                            FirstName = "Pam",
                            LastName = "Mak",
                            School = "Computing"
                        },
                        new
                        {
                            StudentId = 35,
                            FirstName = "Cat",
                            LastName = "Yao",
                            School = "Medicine"
                        },
                        new
                        {
                            StudentId = 36,
                            FirstName = "Lou",
                            LastName = "Zhu",
                            School = "Mining"
                        },
                        new
                        {
                            StudentId = 37,
                            FirstName = "Tom",
                            LastName = "Dag",
                            School = "Business"
                        },
                        new
                        {
                            StudentId = 38,
                            FirstName = "Stu",
                            LastName = "Day",
                            School = "Business"
                        },
                        new
                        {
                            StudentId = 39,
                            FirstName = "Tom",
                            LastName = "Gad",
                            School = "Mining"
                        },
                        new
                        {
                            StudentId = 40,
                            FirstName = "Bob",
                            LastName = "Bee",
                            School = "Business"
                        },
                        new
                        {
                            StudentId = 41,
                            FirstName = "Jim",
                            LastName = "Ots",
                            School = "Business"
                        },
                        new
                        {
                            StudentId = 42,
                            FirstName = "Tom",
                            LastName = "Mag",
                            School = "Business"
                        },
                        new
                        {
                            StudentId = 43,
                            FirstName = "Hal",
                            LastName = "Doe",
                            School = "Mining"
                        },
                        new
                        {
                            StudentId = 44,
                            FirstName = "Roy",
                            LastName = "Kim",
                            School = "Mining"
                        },
                        new
                        {
                            StudentId = 45,
                            FirstName = "Vis",
                            LastName = "Cox",
                            School = "Nursing"
                        },
                        new
                        {
                            StudentId = 46,
                            FirstName = "Kay",
                            LastName = "Aga",
                            School = "Nursing"
                        },
                        new
                        {
                            StudentId = 47,
                            FirstName = "Reo",
                            LastName = "Hui",
                            School = "Nursing"
                        },
                        new
                        {
                            StudentId = 48,
                            FirstName = "Bob",
                            LastName = "Roe",
                            School = "Mining"
                        },
                        new
                        {
                            StudentId = 49,
                            FirstName = "Jay",
                            LastName = "Eff",
                            School = "Computing"
                        },
                        new
                        {
                            StudentId = 50,
                            FirstName = "Eva",
                            LastName = "Chu",
                            School = "Business"
                        },
                        new
                        {
                            StudentId = 51,
                            FirstName = "Lex",
                            LastName = "Rae",
                            School = "Nursing"
                        },
                        new
                        {
                            StudentId = 52,
                            FirstName = "Lin",
                            LastName = "Dex",
                            School = "Mining"
                        },
                        new
                        {
                            StudentId = 53,
                            FirstName = "Tom",
                            LastName = "Dag",
                            School = "Business"
                        },
                        new
                        {
                            StudentId = 54,
                            FirstName = "Ben",
                            LastName = "Shy",
                            School = "Computing"
                        },
                        new
                        {
                            StudentId = 55,
                            FirstName = "Rob",
                            LastName = "Bos",
                            School = "Nursing"
                        },
                        new
                        {
                            StudentId = 56,
                            FirstName = "Ali",
                            LastName = "Mac",
                            School = "Business"
                        },
                        new
                        {
                            StudentId = 57,
                            FirstName = "Edi",
                            LastName = "Gee",
                            School = "Computing"
                        },
                        new
                        {
                            StudentId = 58,
                            FirstName = "Eva",
                            LastName = "Cao",
                            School = "Mining"
                        },
                        new
                        {
                            StudentId = 59,
                            FirstName = "Jun",
                            LastName = "Lam",
                            School = "Computing"
                        },
                        new
                        {
                            StudentId = 60,
                            FirstName = "Eli",
                            LastName = "Tao",
                            School = "Computing"
                        },
                        new
                        {
                            StudentId = 61,
                            FirstName = "Ana",
                            LastName = "Bay",
                            School = "Computing"
                        },
                        new
                        {
                            StudentId = 62,
                            FirstName = "Gil",
                            LastName = "Tal",
                            School = "Mining"
                        },
                        new
                        {
                            StudentId = 63,
                            FirstName = "Wes",
                            LastName = "Dey",
                            School = "Nursing"
                        },
                        new
                        {
                            StudentId = 64,
                            FirstName = "Nea",
                            LastName = "Tan",
                            School = "Computing"
                        },
                        new
                        {
                            StudentId = 65,
                            FirstName = "Ava",
                            LastName = "Day",
                            School = "Nursing"
                        },
                        new
                        {
                            StudentId = 66,
                            FirstName = "Rie",
                            LastName = "Ray",
                            School = "Business"
                        },
                        new
                        {
                            StudentId = 67,
                            FirstName = "Ken",
                            LastName = "Sim",
                            School = "Nursing"
                        },
                        new
                        {
                            StudentId = 68,
                            FirstName = "Liz",
                            LastName = "Kim",
                            School = "Nursing"
                        },
                        new
                        {
                            StudentId = 69,
                            FirstName = "Max",
                            LastName = "Fur",
                            School = "Mining"
                        },
                        new
                        {
                            StudentId = 70,
                            FirstName = "Edi",
                            LastName = "Kai",
                            School = "Mining"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
