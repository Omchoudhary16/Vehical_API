using DAL.Veh.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Veh.Interface;

namespace Web_API.Veh.Controllers
{
    [EnableCors("AllowAll")]
    [Route("api/[controller]")]
    [ApiController]
    public class VehController : ControllerBase
    {
        private IVehService _vehService;

        public VehController(IVehService vehService)
        {
            _vehService = vehService;
        }

        [HttpGet]
        public async Task<IEnumerable<Vehicle>> GetAll()
        {
            return await _vehService.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<Vehicle> FindById(int id)
        {
            return await _vehService.FindById(id);
        }

        [HttpPost]
        public async Task<IActionResult> Add (Vehicle vehicle)
        {
            await _vehService.Add(vehicle);
            return StatusCode(201);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Vehicle vehicle, int id)
        {
            await _vehService.Update(vehicle);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _vehService.Delete(id);
            return Ok();
        }
    }
}
