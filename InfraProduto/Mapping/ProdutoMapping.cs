using APIProdutos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APIProdutos.Mapping
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(x => x.CodigoDoProduto);
            builder.HasIndex(x => x.CodigoDoProduto)
                .IsUnique(true);

            builder.Property(x => x.CodigoDoProduto).IsRequired();

            builder.Property(x => x.DescricaoDoProduto).IsRequired();

            builder.Property(x => x.SituacaoDoProduto);

            builder.Property(x => x.DataDeFabricação);

            builder.Property(x => x.DataDeValidade);

            builder.Property(x => x.CodigoDoFornecedor);

            builder.Property(x => x.DescricaoDoFornecedor);

            builder.Property(x => x.CNPJDoFornecedor);

        }
    }
}