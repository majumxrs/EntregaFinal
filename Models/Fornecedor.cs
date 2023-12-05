using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    [Table("Fornecedor")]
    public class Fornecedor
    {
        [Column("Id")]
        [Display(Name = "Código do Fornecedor")]
        public int Id { get; set; }

        [Column("FornecedorNome")]
        [Display(Name = "Nome")]
        public string FornecedorNome { get; set; } = string.Empty;

        [Column("FornecedorEmail")]
        [Display(Name = "Email")]
        public string FornecedorEmail { get; set; } = string.Empty;

        [Column("FornecedorCnpj")]
        [Display(Name = "Cnpj")]
        public string FornecedorCnpj { get; set; } = string.Empty;
    }
}
