using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace WebApi.Repositories.Config
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(
                new Book { Id = 1, Title = "ekmek", Price = 100 },
                new Book { Id = 2, Title = "ekmek", Price = 100 },
                new Book { Id = 3, Title = "ekmek", Price = 100 }
                );
        }
    }
}
