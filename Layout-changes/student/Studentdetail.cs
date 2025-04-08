//using Layout_changes.Controllers;
using Layout_changes.Models;

namespace Layout_changes.student
{
    public class Studentdetail
    {
        public List<Student> Getstudent()
        {
            return new List<Student>
                {
                    new Student { Id = 1, Name = "John", Class = "X", Address = "USA" },
                    new Student { Id = 2, Name = "Smith", Class = "X", Address = "UK" },
                    new Student { Id = 3, Name = "Ravi", Class = "X", Address = "India" },
                    new Student { Id = 4, Name = "Kumar", Class = "X", Address = "India" },
                    new Student { Id = 5, Name = "Raj", Class = "X", Address = "India" }
                };
        }
    }
}
