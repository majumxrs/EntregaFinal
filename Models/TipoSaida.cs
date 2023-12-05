using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    [Table("TipoSaida")]
    public class TipoSaida
    {
        [Column("Id")]
        [Display(Name = "Código do produto")]
        public int Id { get; set; }

        [Column("TipoSaidaIdDescricao")]
        [Display(Name = "Motivo da saida")]
        public string TipoSaidaIdDescricao { get; set; } = string.Empty;
    }
}
