using Microsoft.AspNetCore.Mvc;
using object_oriented_analysis_design_assignment.Contexts;
using object_oriented_analysis_design_assignment.Repositories;
using object_oriented_analysis_design_assignment.Interfaces;

namespace object_oriented_analysis_design_assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly ArticlesRepository _userRepo;

        public AdminController(ArticlesRepository userRepo)
        {
            _userRepo = userRepo;
        }



        [HttpPost]
        public async Task<IActionResult> Create(IArticlesRequest req)
        {
            if (ModelState.IsValid)
            {
                IArticlesResponse res = await _userRepo.CreateAsync(req);
                if (res != null)
                    return Created("", res);
            }

            return BadRequest();
        }
    }
}
