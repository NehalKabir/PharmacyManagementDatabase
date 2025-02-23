using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PharmacyManagementAPI.Entities;

namespace PharmacyManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientMedicineMapController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public PatientMedicineMapController(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }
        [HttpPost]
        public IActionResult SavePatientMedicineMapInfo([FromBody] PatientMedicineMap ObjPatientMedicineMap)
        {
            return Ok();
        }

        [HttpGet]
        public IActionResult GetPatientMedicineMapInfo()
        {
            List<PatientMedicineMap> ListPatientMedicineMap = new List<PatientMedicineMap>();
            PatientMedicineMap ObjPatientMedicineMap = new PatientMedicineMap();
            ObjPatientMedicineMap.DoctorID = 123;
            ObjPatientMedicineMap.PatientID = 1;
            return Ok(ListPatientMedicineMap);
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePatientMedicineMapInfo(int id)
        {
            try
            {
                var patientMedicineMapInfo = _context.PatientMedicineMap.Find(id);
                if (patientMedicineMapInfo == null)
                {
                    return NotFound();
                }
                _context.PatientMedicineMap.Remove(patientMedicineMapInfo);
                _context.SaveChanges(true);
                return Ok();

            }
            catch (Exception ex) { }
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdatePatientMedicineMap(int id, PatientMedicineMap ObjPatientMedicineMap) { 
            if (id != ObjPatientMedicineMap.PatientMedicineMapID)
            {
                return BadRequest();
            }
            _context.Entry(ObjPatientMedicineMap).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            try
            {
                _context.SaveChanges();
            }
            catch { }
                return Ok(); }
    }
}
