using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using object_oriented_analysis_design_assignment.Factories;
using object_oriented_analysis_design_assignment.Models.Dtos;

namespace object_oriented_analysis_design_assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public IActionResult Create()
        {
            var user = UserResponseFactory.Create();

            return Created("", user);
        }
    }
}
