using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WepApiTesteEF.Models
{
    [Table("cidades")]
    public class Cidade
    {
        public Cidade()
        {
            Clientes = new HashSet<Cliente>();
        }

        [Key]
        [Column("cidadeId")]
        public int CidadeId { get; set; }
        [Column("nome")]
        
        public string Nome { get; set; } = null!;
        [Column("estadoId")]
        public int EstadoId { get; set; }

        [ForeignKey("EstadoId")]
        [InverseProperty("Cidades")]
        public virtual Estado Estado { get; set; } = null!;
        [InverseProperty("Cidade")]
        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}
