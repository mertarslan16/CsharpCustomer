

using System.ComponentModel.DataAnnotations;

namespace UdemyProje1.Models
{
    public class Customer
    {
        [Range(1, int.MaxValue)]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age {  get; set; }   
    }
}
