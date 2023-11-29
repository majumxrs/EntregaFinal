using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    [Table("EntradaProduto")]
    public class TipoSaida
    {
        [Column("TipoSaidaId")]
        [Display(Name = "Código do produto")]
        public int Id { get; set; }

        [Column("TipoSaidaIdDescricao")]
        [Display(Name = "Motivo da saida")]
        public string TipoSaidaIdDescricao { get; set; } = string.Empty;
    }
}
