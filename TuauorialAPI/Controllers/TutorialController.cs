using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TuauorialAPI.Interfaces;
using TuauorialAPI.Models;
using TuauorialAPI.Service;

namespace TuauorialAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TutorialController : ControllerBase
    {
        public ITutorialInterface _tutorialService { get; set; }
        public List<TestModel> testModels { get; set; }

        public TutorialController(ITutorialInterface tutorialService)
        {
            _tutorialService = tutorialService;
            testModels = _tutorialService.GetTestModels();
        }


        [HttpGet]
        public async Task<ActionResult<List<TestModel>>> GetTestModel()
        {
            try
            {
                var model = testModels;
                return Ok(model);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TestModel>> GetTestModelId(int id)
        {
            try
            {
                var model = testModels;
                var userId = model.Find(x => x.Id == id);
                if (userId == null)
                    return BadRequest("пользователь не найден");
                else
                    return Ok(userId);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<TestModel>> TestModelDelete(int id)
        {
            try
            {
                var model = testModels;
                var userId = model.Find(x => x.Id == id);
                if (userId == null)
                    return BadRequest("пользователь не найден");
                else
                {
                    model.Remove(userId);
                    return Ok("Пользователь удален");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
