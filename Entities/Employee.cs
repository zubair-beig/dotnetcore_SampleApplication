
using System.ComponentModel.DataAnnotations;

namespace myApp.Entities
{
    public class Employee
    {
        public Employee()
        {
        }

        public int Id { get; set; }

        [MaxLength(30)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }
        [MaxLength(250)]
        public string Description { get; set; }
    }

}