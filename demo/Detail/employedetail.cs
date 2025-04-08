using demo.Models;
namespace demo.Detail
{
    public class Employedetail
    {
        public List<Employe> GetDetails()
        {
            return new List<Employe>
                {
                    new Employe { Id = 1, Name = "Rohan", Email = "rohan@123" , Phone = "8128102388" },
                    new Employe { Id = 2, Name = "Rohit", Email = "rohit@123" , Phone = "8128121388" },
                    new Employe { Id = 3, Name = "Rahul", Email = "rahul@123" , Phone = "8128122388" },
                };
        }
    }
}
