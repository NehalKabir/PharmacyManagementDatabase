using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PharmacyManagementAPI.Entities;

namespace PharmacyManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctoInfoController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public DoctoInfoController(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;

        }

        [HttpPost]
        public IActionResult SaveDoctorInfo([FromBody] DoctorInfo ObjDoctorInfo)
        {   try
            {
                _context.DoctorInfo.Add(ObjDoctorInfo);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

            }
           
            return Ok();
        }

        [HttpGet]
        public IActionResult GetDoctorInfo()
        {
            var ListDoctorInfo = _context.DoctorInfo;


            return Ok(ListDoctorInfo);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDoctorInfo(int id)
        {
            try
            {

                var doctorInfo = _context.DoctorInfo.Find(id);
                if (doctorInfo == null)
                {
                    return NotFound();
                }
                _context.DoctorInfo.Remove(doctorInfo);
                _context.SaveChanges(true);
                return Ok();
            }
            catch (Exception ex)
            {

            }
            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult UpdateDoctorInfo(int id, DoctorInfo ObjDoctorInfo)
        {
            if(id != ObjDoctorInfo.DoctorID)
            {
                return BadRequest();
            }
            _context.Entry(ObjDoctorInfo).State = EntityState.Modified;
            try
            {
                _context.SaveChanges();
            }
            catch { }

        return Ok(); 
        }
    }

    }

