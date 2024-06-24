using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WepApiTesteEF.Models
{
    [Table("clientes")]
    public class Cliente
    {
        [Key]
        [Column("cpf")]
        [StringLength(11)]
        
        public string Cpf { get; set; } = null!;
        [Column("nome")]
        
        public string Nome { get; set; } = null!;
        [Column("dataNascimento", TypeName = "date")]
        public DateTime DataNascimento { get; set; }
        [Column("sexo")]
        [StringLength(1)]
        
        public string Sexo { get; set; } = null!;
        [Column("endereco")]
        
        public string Endereco { get; set; } = null!;
        [Column("cidadeId")]
        public int CidadeId { get; set; }

        [ForeignKey("CidadeId")]
        [InverseProperty("Clientes")]
        public virtual Cidade Cidade { get; set; } = null!;
    }
}
