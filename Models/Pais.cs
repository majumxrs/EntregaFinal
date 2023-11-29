using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    [Table("Pais")]
    public class Pais
    {

        [Column("PaisId")]
        public int Id { get; }

        [Column("PaisNome")]
        [Display(Name = "Nome do Pais")]
        public string PaisNome { get; set; } = string.Empty;
    }
}
