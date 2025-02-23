using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PharmacyManagementAPI.Entities;

namespace PharmacyManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientInfoController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public PatientInfoController(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;

        }
        [HttpPost]
        
        public IActionResult SavePatientInfo([FromBody] PatientInfo ObjPatientInfo)
        {
            try
            {
                _context.PatientInfo.Add(ObjPatientInfo);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

            }


            return Ok();
        }
        [HttpGet]
        public IActionResult GetPatientInfo()
        {
           var ListPatientInfo = _context.PatientInfo;
            return Ok(ListPatientInfo);

        }
        [HttpDelete("{id}")]

        public IActionResult DeletePatientInfo(int id)
        {
            try
            {
                var patientInfo = _context.PatientInfo.Find(id);
                if (patientInfo == null)
                {
                    return NotFound();
                }
                _context.PatientInfo.Remove(patientInfo);
                _context.SaveChanges(true);
                return Ok();
            }
            catch (Exception ex)
            {
            }

            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult UpdatePatientInfo(int id, PatientInfo ObjPatientInfo) { 
            if(id != ObjPatientInfo.PatientID)
            {
                return BadRequest();
            }
            _context.Entry(ObjPatientInfo).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            try
            {
                _context.SaveChanges();
            }
            catch { }
            return Ok();
        }

        
    }
}
