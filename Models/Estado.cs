﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    [Table("Estado")]
    public class Estado
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("EstadoNome")]
        [Display(Name = "Nome do estado")]
        public string EstadoNome { get; set; } = string.Empty;

        [ForeignKey("PaisId")]
        [Display(Name = "Pais")]
        public int PaisId { get; set; }
        public Pais? Pais { get; set; }
    }
}
