using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PharmacyManagementAPI.Entities
{
    public class IllnessInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       
        public int IllnessID { get; set; }
        public string Illness { get; set; }

        public DateTime IllnessDiagnosisDate { get; set; }

        public int IllnessStatus { get; set; }
    }
}
