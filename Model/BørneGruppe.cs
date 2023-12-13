using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FDFLodsedler.Model
{
    public class BørneGruppe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Gruppe_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Navn { get; set; }

        //[Required]
        //[ForeignKey("Leder_Id")]
        //public Leder Leder { get; set; }

        [Column("Leder_Id")]
        public int? LederId { get; set; }
    }
}
