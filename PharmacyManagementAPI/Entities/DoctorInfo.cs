using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace PharmacyManagementAPI.Entities
{
    public class DoctorInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       
        public int DoctorID {  get; set; }
        public string DoctorName { get; set; }
        public int DoctorLicense { get; set; }
        public string DoctorAddress { get; set; }
    }
}
