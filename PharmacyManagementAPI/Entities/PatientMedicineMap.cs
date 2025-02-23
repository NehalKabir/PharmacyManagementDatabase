using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PharmacyManagementAPI.Entities
{
    public class PatientMedicineMap
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        public int PatientMedicineMapID {  get; set; }
        public int PatientID {  get; set; }
        public int MedicineID { get; set; }
        public int DoctorID {  get; set; }
    }
}
