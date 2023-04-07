using System.ComponentModel.DataAnnotations;

namespace leaverequest.DTO
{
    public class UpdateDTO
    {
        [Required]
        public string username { get; set; }
        [Required]
        public string password { get; set; }
    }
}
