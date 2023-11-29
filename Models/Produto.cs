using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Column("ProdutoId")]
        [Display(Name = "Código do produto")]
        public int Id { get; set; }

        [Column("ProdutoNome")]
        [Display(Name = "Nome")]
        public string ProdutoNome { get; set; } = string.Empty;

        [Column("Quantidadestoque")]
        [Display(Name = "Quantidade em estoque")]
        public int Quantidadestoque { get; set; }

        [ForeignKey("FornecedorId")]
        [Display(Name = "Fornecedor")]
        public int FornecedorId { get; set; }
        public Fornecedor? Fornecedor { get; set; }

        [ForeignKey("TipoProdutoId")]
        [Display(Name = "Tipo do Produto")]
        public int TipoProdutoId { get; set; }
        public TipoProduto? TipoProduto { get; set; }
    }
}
