using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PharmacyManagementAPI.Entities
{
    public class PatientIllnessMap
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PatientIllnessID {  get; set; }
        public int PatientID { get; set; }
        public int IllnessID { get; set; }

    }
}
