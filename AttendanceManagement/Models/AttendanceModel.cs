using System.ComponentModel.DataAnnotations;

namespace AttendanceManagement.Models
{
    public class AttendanceModel
    {
        public int AttendanceId { get; set; }
        public string? AITId { get; set; }
        public DateTime date { get; set; }
        public string? CheckIn { get; set; }
        public string? CheckOut { get; set; }
        public string? Status { get; set; }
        public string? Reason { get; set; }
        public string? Description { get; set; }
    }
    public class events
    {
        public string? title { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        public DateTime start { get; set; }
        public DateTime end { get; set; }
    }
}
