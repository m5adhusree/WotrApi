using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WotrApi.Data;

namespace WotrApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ActivityBeneficiariesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ActivityBeneficiariesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _context.ActivityBeneficiaries.ToListAsync();
            return Ok(data);
        }
    }
}