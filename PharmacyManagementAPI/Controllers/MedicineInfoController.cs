using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PharmacyManagementAPI.Entities;

namespace PharmacyManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicineInfoController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public MedicineInfoController(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;

        }
        [HttpPost]
        public IActionResult SaveMedicineInfo([FromBody] MedicineInfo OnjMedicineInfo)
        {
            try
            {
                _context.MedicineInfo.Add(OnjMedicineInfo);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

            }
            return Ok();
        }

        [HttpGet]
        public IActionResult GetMedicineInfo()
        {
           var ListMedicineInfo = _context.MedicineInfo;

            return Ok(ListMedicineInfo);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMedicineInfo(int id)
        {
            try
            {
                var medicineInfo = _context.MedicineInfo.Find(id);
                if (medicineInfo == null)
                {
                    return NotFound();
                }
                _context.MedicineInfo.Remove(medicineInfo);
                _context.SaveChanges(true);
                return Ok();
            }
            catch (Exception ex)
            {
            }
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateMedicineInfo(int id, MedicineInfo OnjMedicineInfo)
        {
            if (id != OnjMedicineInfo.MedicineID)
            {
                return BadRequest();
            }

            _context.Entry(OnjMedicineInfo).State = EntityState.Modified;

            try
            {
                 _context.SaveChanges();
            }
            catch { }
        return Ok(); }
    }
    
}
