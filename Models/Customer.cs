using System.ComponentModel.DataAnnotations;

namespace APICrudClint.Models
{
    public class Customer
    {
        [StringLength(100)]
        public string Name { get; set; } = "";
        [StringLength(100)]
        public string Email { get; set; } = "";
        [StringLength(100)]
        public string Phone { get; set; } = "";
        [StringLength(100)]
        public string Address { get; set; } = "";
        [StringLength(100)]
        public string City { get; set; } = "";
        [StringLength(100)]
        public int Id { get; set; } 
    }
}
    

