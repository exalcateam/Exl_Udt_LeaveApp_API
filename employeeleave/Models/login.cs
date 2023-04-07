using System.ComponentModel.DataAnnotations;

namespace leaverequest.Models
{
    public class login
    {
        [Key]
      
      
        public int Id { get; set; }
        [Required]
        public string username { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        public string EmailId { get; set; }
        [Required]
        public string DateofBirth { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string JobRole { get; set; }

    }
}
