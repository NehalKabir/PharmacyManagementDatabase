using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;

namespace PharmacyManagementAPI.Entities
{
    public class PatientInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
     
        public int PatientID {  get; set; }
        public string Name { get; set; }
        public int Age {  get; set; }
        public string Address { get; set; }

        //private int FieldID;

    }
   
}
