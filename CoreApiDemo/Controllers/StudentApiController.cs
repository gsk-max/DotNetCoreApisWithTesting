using CoreApiDemo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreApiDemo.Controllers
{
  //  [Route("api/[controller]")]
    [ApiController]
    public class StudentApiController : ControllerBase
    {
        [HttpGet]
        [Route("api/student")]

        public List<Student> GetStudents()
        {
            return FetchStudents();
        }
        [HttpGet]
        [Route("api/student/{rno}")]

        public  Student  GetStudent(int rno)
        {
            return FetchStudents().FirstOrDefault(e=>e.RollNo.Equals(rno));
        }

        [NonAction]
        public List<Student> FetchStudents()
        {
           return new List<Student>()
            {
                 new Student(){ RollNo=1, StudentName="Ajay"},
                 new Student(){ RollNo=2, StudentName="Suresh"},
                 new Student(){ RollNo=3, StudentName="Sagar"},
                 new Student(){ RollNo=4, StudentName="Divya"},
                 new Student(){ RollNo=5, StudentName="Amit"}
            };
        }


    }
}
