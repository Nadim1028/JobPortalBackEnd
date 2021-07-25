using Microsoft.AspNetCore.Mvc;
using JobPortalBackEnd.Model;
using JobPortalBackEnd.Repository;

namespace JobPortalBackEnd.Controllers
{
    public class StudentController : ControllerBase
    {
        private readonly StudentRepository _studentRepository = new StudentRepository();
        /* private readonly DatabaseContext _context;
         public StudentController(DatabaseContext context)
         {
             _context = context;

         }*/


        [HttpPost("api/student/add")]
        public IActionResult AddStudent([FromBody] Student student)
        {
            var addedStudent = _studentRepository.Add(student);
            return Ok(addedStudent);
        }

        [HttpGet("api/student/getByIdValue")]
        public IActionResult GetStudentByIdValue(int studentId, string sessionId)
        {
            var student = new Student();
            student.Id = studentId;
            student.Session = sessionId;
            student.FirstName = "Nadim";
            student.LastName = "Ahmed";

            return Ok(student);
        }

        [HttpGet("api/student/getById")]
        public IActionResult GetStudentById(int studentId)
        {
            var student = _studentRepository.GetById(studentId);
            return Ok(student);
        }

        [HttpGet("api/student/getAll")]
        public IActionResult GetAllStudents()
        {
            return Ok(_studentRepository.GetAll());
        }

        [HttpPost("api/student/update")]
        public IActionResult UpdateStudent([FromBody] Student student)
        {
            return Ok(_studentRepository.Update(student));
        }

        [HttpPost("api/student/delete")]
        public IActionResult DeleteStudent([FromBody] int studentId)
        {
            var student = _studentRepository.GetById(studentId);
            _studentRepository.Delete(student);
            return Ok();
        }

        /* [HttpGet("api/student/delete")]
         public IActionResult DeleteUser(int id)
         {
             var Id = Convert.ToInt16(id);
             var user = _context.Students.FirstOrDefault(x => x.Id == id);
             _context.Students.Remove(user);
             // _context.Staffs.RemoveRange
             //     (_context.Staffs.Where(x => x.StaffId == Id));
             _context.SaveChanges();

             return Ok(user);

         }*/

    }
}
