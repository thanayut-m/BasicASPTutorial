using BasicASPTutorial.Modals;
using Microsoft.AspNetCore.Mvc;

namespace BasicASPTutorial.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class StudentController : ControllerBase
    {
        [HttpGet("GetAllUser")]
        public Student GetAllUser()
        {
            Student s1 = new Student();
            s1.Student_Id = 1;
            s1.Student_Name = "iCat";
            s1.Student_Score = 30;
            s1.Student_Cr_at = DateTime.Now;
            return s1;
        }

        [HttpPost("CreateStudent")]
        public IActionResult CreateStudent([FromBody] Student student)
        {
            student.Student_Cr_at = DateTime.Now;
            return Ok(student);
        }

        [HttpDelete("DeleteStudent")]
        public IActionResult DeleteStudent([FromBody] Student student)
        {
            student.Student_Cr_at = DateTime.Now;
            return Ok(student);
        }

        [HttpPut("UpdateStudent")]
        public IActionResult UpdateStudent([FromBody] Student student)
        {
            try
            {
                if(student == null|| string.IsNullOrWhiteSpace(student.Student_Name) || student.Student_Score <= 0)
                {
                    return BadRequest("Invalid student data. Ensure name and score are valid.");
                }
                student.Student_Cr_at = DateTime.Now;
                return Ok(student);
            } catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error : {ex.Message}");
            }
        }
    }
}
