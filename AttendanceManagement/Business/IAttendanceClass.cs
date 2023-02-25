using AttendanceManagement.Models;

namespace AttendanceManagement.Business
{
    public interface IAttendanceClass
    {
        public AttendanceModel attendance(AttendanceModel attendance);

        public AttendanceModel attendance1(AttendanceModel attendance);
        public List<AttendanceModel> GetAttendance(string aitid, string date);
        public List<AttendanceModel> GetByWeek(string aitid, string date1, string date2);
        public List<AttendanceModel> GetByMonth(string aitid, string month, string year);
        public List<AttendanceModel> GetByWeekCount(string aitid, string date1, string date2);
        public List<AttendanceModel> GetRegularization(string aitid);
        public List<AttendanceModel> GetCheckIn(AttendanceModel attendance);
        public List<events> GetEvent(string aitid, string start, string end);
        public AttendanceModel CheckOut(AttendanceModel attendance);
        public List<AttendanceModel> GetPresentCount(string aitid, string date1, string date2);
        public List<AttendanceModel> GetAbsentCount(string aitid, string date1, string date2);
        public List<AttendanceModel> GetPresentByMonth(string aitid, string month, string year);
        public List<AttendanceModel> GetAbsentByMonth(string aitid, string month, string year);
    }
}
