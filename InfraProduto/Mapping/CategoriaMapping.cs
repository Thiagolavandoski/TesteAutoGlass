//using APIProdutos.Models;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace APIProdutos.Mapping
//{
//    public class CategoriaMapping : IEntityTypeConfiguration<Categoria>
//    {
//        public void Configure(EntityTypeBuilder<Categoria> builder)
//        {
//            builder.HasKey(x => x.Id);
//            builder.HasIndex(x => x.Id)
//                .IsUnique(true);

//            builder.Property(x => x.Nome).IsRequired();

//            builder.Property(x => x.Origem).IsRequired();

//            builder.Property(x => x.Ativo).IsRequired();
//        }
//    }
//}
