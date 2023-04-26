using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace leaverequest.Models
{
    public class leaveform
    {
        [Key]
        public int id { get; set; }
        public string LeaveType { get; set; }
        public string Session { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public int Total { get; set; }
        public string fromtime { get; set; }
        public string totime { get; set; }
        public long Contact { get; set; }
        public string Reason { get; set; }
        public string username { get; set; }
        [ForeignKey("username")]
        public virtual login Login { get; set; }


    }
}
