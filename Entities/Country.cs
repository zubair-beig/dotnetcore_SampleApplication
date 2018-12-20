using System.ComponentModel.DataAnnotations;

namespace myApp.Entities
{   public class Country
    {
        public Country()
        {

        }
        public int ID { get; set; }
        [MaxLength(40)]
        public string DisplayName { get; set; }
        public string Name { get; set; }
    }
}