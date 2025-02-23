using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PharmacyManagementAPI.Entities;

namespace PharmacyManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientIllnesMapController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public PatientIllnesMapController(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;

        }

        [HttpPost]
        public IActionResult SavePatientIllnessMap([FromBody] PatientIllnessMap ObjPatientIllnessMap)
        {
            try
            {
                _context.PatientIllnessMap.Add(ObjPatientIllnessMap);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

            }
            return Ok();
        }
        [HttpGet]
        public IActionResult GetPatientIllnessMap()
        {
           var ListGetPatientIllnessMap = _context.PatientIllnessMap;
            return Ok(ListGetPatientIllnessMap);
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePatientIllnessMap(int id)
        {
            try
            {
                var patientIllnessMapInfo = _context.PatientIllnessMap.Find(id);
                if (patientIllnessMapInfo == null)
                {
                    return NotFound();
                }
                _context.PatientIllnessMap.Remove(patientIllnessMapInfo);
                _context.SaveChanges(true);
                return Ok();

            }
            catch (Exception ex) { }

            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdatePatientIllnessMap(int id, PatientIllnessMap ObjPatientIllnesMap)
        {
            if( id != ObjPatientIllnesMap.IllnessID)
            {
                return BadRequest();
            }
            _context.Entry(ObjPatientIllnesMap).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            try
            {
                _context.SaveChanges();
            }
            catch { }
            return Ok();
        }
    }
}
