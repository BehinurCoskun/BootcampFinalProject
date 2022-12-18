using AuthenticationAuthorization.Context;
using AuthenticationAuthorization.Models;
using Azure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationAuthorization.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApartmentController : ControllerBase
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public ApartmentController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        [Authorize(Roles = UserRoles.Admin)]
        [HttpGet]
        public async Task<IActionResult> GetAllApartments()
        {
            return Ok(await _applicationDbContext.Apartments.ToListAsync());
        }
        [Authorize(Roles = UserRoles.Admin)]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetApartmenyById(int id)
        {
            return Ok();
        }
        [Authorize(Roles = UserRoles.Admin)]
        [HttpPost]
        public async Task<IActionResult> Post(ApartmentModel apartment)
        {
            return Ok();
        }
        [Authorize(Roles = UserRoles.Admin)]
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateApartmen(ApartmentModel apartment)
        {
            return NoContent();
        }
        [Authorize(Roles = UserRoles.Admin)]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteApartment(int id)
        {
            return NoContent();
        }
    }
}
