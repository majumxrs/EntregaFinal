using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    [Table("Cidade")]
    public class Cidade
    {
        [Column("Id")]
        [Display(Name = "Cod. da Cidade")]
        public int Id { get; set;  }

        [Column("CidadeNome")]
        [Display(Name ="Nome da cidade" )]
        public string CidadeNome { get; set;  } = string.Empty;

        [ForeignKey("EstadoId")]
        [Display(Name = "Esatado")]
        public int EstadoId { get; set; }
        public Estado? Estado { get; set; }
    }
}
