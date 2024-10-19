using Dependency_Injection.Managers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dependency_Injection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassRoomController : ControllerBase
    {
        private readonly ClassRoom _classRoom;


        public ClassRoomController(ClassRoom classRoom)
        {
            _classRoom = classRoom;
        }

        [HttpGet("get-teacher-info")]
        public IActionResult GetTeacherInfo()
        {

            var teacherInfo = _classRoom.GetTeacherInfo();
            return Ok(teacherInfo);
        }
    }
}
