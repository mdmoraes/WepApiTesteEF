using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WepApiTesteEF.Models
{
    [Table("estados")]
    public class Estado
    {
        public Estado()
        {
            Cidades = new HashSet<Cidade>();
        }

        [Key]
        [Column("estadoId")]
        public int EstadoId { get; set; }
        [Column("nome")]

        public string Nome { get; set; } = null!;
        [Column("sigla")]
        [StringLength(2)]

        public string Sigla { get; set; } = null!;

        [InverseProperty("Estado")]
        public virtual ICollection<Cidade> Cidades { get; set; }
    }
}
