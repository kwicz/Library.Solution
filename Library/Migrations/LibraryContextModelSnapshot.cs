﻿// <auto-generated />
using Library.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Library.Migrations
{
    [DbContext(typeof(LibraryContext))]
    partial class LibraryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Library.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("Library.Models.AuthorBook", b =>
                {
                    b.Property<int>("AuthorBookId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AuthorId");

                    b.Property<int>("BookId");

                    b.HasKey("AuthorBookId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("BookId");

                    b.ToTable("AuthorBook");
                });

            modelBuilder.Entity("Library.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Title");

                    b.HasKey("BookId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Library.Models.Copy", b =>
                {
                    b.Property<int>("CopyId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BookId");

                    b.HasKey("CopyId");

                    b.HasIndex("BookId");

                    b.ToTable("Copies");
                });

            modelBuilder.Entity("Library.Models.CopyPatron", b =>
                {
                    b.Property<int>("CopyPatronId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CheckoutDate");

                    b.Property<string>("Copy");

                    b.Property<int>("CopyId");

                    b.Property<string>("DueDate");

                    b.Property<string>("Patron");

                    b.Property<int>("PatronId");

                    b.HasKey("CopyPatronId");

                    b.HasIndex("CopyId");

                    b.HasIndex("PatronId");

                    b.ToTable("CopyPatron");
                });

            modelBuilder.Entity("Library.Models.Patron", b =>
                {
                    b.Property<int>("PatronId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("PatronId");

                    b.ToTable("Patrons");
                });

            modelBuilder.Entity("Library.Models.AuthorBook", b =>
                {
                    b.HasOne("Library.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Library.Models.Book", "Book")
                        .WithMany("Authors")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Library.Models.Copy", b =>
                {
                    b.HasOne("Library.Models.Book")
                        .WithMany("Copies")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Library.Models.CopyPatron", b =>
                {
                    b.HasOne("Library.Models.Copy")
                        .WithMany("Patrons")
                        .HasForeignKey("CopyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Library.Models.Patron")
                        .WithMany("Copies")
                        .HasForeignKey("PatronId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
