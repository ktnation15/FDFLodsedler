using FDFLodsedler.Interface;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FDFLodsedler.Model
{
    public class Børn
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Børn_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Navn { get; set; }

        //[Required]
        //[ForeignKey("Gruppe_Id")]
        //public BørneGruppe BørneGruppe { get; set; }
        [Column("Gruppe_Id")]
        public int? GruppeId { get; set; }



    }
}
