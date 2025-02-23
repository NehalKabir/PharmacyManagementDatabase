using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PharmacyManagementAPI.Entities
{
    public class MedicineInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       
        public int MedicineID {  get; set; }
        public int NDC { get; set; }
        public string MedicineName { get; set; }
        public string GenericName { get; set; }

        public int Dosage {  get; set; }

    }
}
