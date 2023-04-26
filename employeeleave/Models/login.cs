using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace leaverequest.Models
{
    public class login
    {

        public int Id { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string username { get; set; }
      
        public string password { get; set; }
     
        public string EmailId { get; set; }
   
        public string DateofBirth { get; set; }

        public string Gender { get; set; }
 
        public string PhoneNumber { get; set; }
        public string Jobrole { get; set; }
    }
}
