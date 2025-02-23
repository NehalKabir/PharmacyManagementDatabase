using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PharmacyManagementAPI.Entities;

namespace PharmacyManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IllnessController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public IllnessController(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;

        }

        [HttpPost]
        public IActionResult SaveIllnessInfo([FromBody] IllnessInfo ObjIllnessInfo)
        {
            try
            {
                _context.IllnessInfo.Add(ObjIllnessInfo);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

            }
            return Ok();

        }

        [HttpGet]
        public IActionResult GetIllnessInfo()
        {
           var ListIllnessInfo = _context.IllnessInfo;
            return Ok(ListIllnessInfo);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteIllnessInfo(int id)
        {
            try
            {
                var illnessInfo = _context.IllnessInfo.Find(id);
                if (illnessInfo == null)
                {
                    return NotFound();
                }
                _context.IllnessInfo.Remove(illnessInfo);
                _context.SaveChanges(true);
                return Ok();
            }
            catch (Exception ex)
            {
            }
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateIllnessInfo(int id, IllnessInfo ObjIllnessInfo)
        {
            if(id != ObjIllnessInfo.IllnessID)
            {
                return BadRequest();
            }
            _context.Entry(ObjIllnessInfo).State = EntityState.Modified;
            try
            {
                _context.SaveChanges();
            }
            catch  { }
            return Ok();

        }
    }
}
