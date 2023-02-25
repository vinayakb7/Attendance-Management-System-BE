using AttendanceManagement.Models;
using MySql.Data.MySqlClient;

namespace AttendanceManagement.Business
{
    public class AttendanceClass : IAttendanceClass
    {
        private readonly IConfiguration _configuration;
        public AttendanceClass(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public AttendanceModel attendance(AttendanceModel attendance)
        {
            string query = "call attendancemanagement.checkIn(?,?,?)";
            string sqlDataSource = _configuration.GetConnectionString("dbConnection");
            using (MySqlConnection mycon = new MySqlConnection(sqlDataSource))
            {

                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myCommand.Parameters.AddWithValue("@AITId", attendance.AITId);
                    myCommand.Parameters.AddWithValue("@Date", attendance.date);
                    myCommand.Parameters.AddWithValue("@CheckIn", attendance.CheckIn);
                    myCommand.ExecuteReader();
                    mycon.Close();
                }
                return attendance;
            }
        }

        public AttendanceModel CheckOut(AttendanceModel attendance)
        {
            string query = "call attendancemanagement.checkOut(?,?,?,?)";
            string sqlDataSource = _configuration.GetConnectionString("dbConnection");
            using (MySqlConnection mycon = new MySqlConnection(sqlDataSource))
            {

                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myCommand.Parameters.AddWithValue("@idd", attendance.AITId);
                    myCommand.Parameters.AddWithValue("@dt", attendance.date);
                    myCommand.Parameters.AddWithValue("@co", attendance.CheckOut);
                    myCommand.Parameters.AddWithValue("@sts", attendance.Status);
                    myCommand.ExecuteReader();
                    mycon.Close();
                }
                return attendance;
            }
        }

        public List<AttendanceModel> GetAttendance(string aitid,string date)
        {
            List<AttendanceModel> attendances = new List<AttendanceModel>();
            string query = "call attendancemanagement.getAttendaceDetails(?,?)";
            string sqlDataSource = _configuration.GetConnectionString("dbConnection");
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(sqlDataSource))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myCommand.Parameters.AddWithValue("@idd", aitid);
                    myCommand.Parameters.AddWithValue("@dt", date);
                    myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        AttendanceModel tempAttendance = new AttendanceModel();
                        tempAttendance.AttendanceId = Convert.ToInt32(myReader["Id"]);
                        tempAttendance.AITId = Convert.ToString(myReader["AITId"]);
                        tempAttendance.date = Convert.ToDateTime(myReader["Date"]);
                        tempAttendance.CheckIn = Convert.ToString(myReader["checkIn"]);
                        tempAttendance.CheckOut = Convert.ToString(myReader["checkOut"]);
                        String s = Convert.ToString(myReader["checkIn"]);
                        string[] subs = s.Split(':');
                        String s1 = subs[0];
                        String s2 = Convert.ToString(myReader["checkOut"]);
                        string[] subs2 = s2.Split(':');
                        String s3 = subs2[0];
                        int n1 = int.Parse(s1);
                        int n2 = int.Parse(s3);
                        if ((n2 - n1) >= 9)
                        {
                            tempAttendance.Status = "Present";
                        }
                        else
                        {
                            tempAttendance.Status = "Absent";
                        }
                        attendances.Add(tempAttendance);
                    }
                    mycon.Close();
                    return attendances;
                }
            }
        }

        public List<AttendanceModel> GetByWeek(string aitid, string date1, string date2)
        {
            List<AttendanceModel> attendances = new List<AttendanceModel>();
            string query = "call attendancemanagement.getByWeek(?,?,?)";
            string sqlDataSource = _configuration.GetConnectionString("dbConnection");
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(sqlDataSource))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myCommand.Parameters.AddWithValue("@idd", aitid);
                    myCommand.Parameters.AddWithValue("@dt1", date1);
                    myCommand.Parameters.AddWithValue("@dt2", date2);
                    myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        AttendanceModel tempAttendance = new AttendanceModel();
                        tempAttendance.AttendanceId = Convert.ToInt32(myReader["Id"]);
                        tempAttendance.AITId = Convert.ToString(myReader["AITId"]);
                        tempAttendance.date = Convert.ToDateTime(myReader["Date"]);
                        tempAttendance.CheckIn = Convert.ToString(myReader["checkIn"]);
                        tempAttendance.CheckOut = Convert.ToString(myReader["checkOut"]);
                        String s = Convert.ToString(myReader["checkIn"]);
                        string[] subs = s.Split(':');
                        String s1 = subs[0];
                        String s2 = Convert.ToString(myReader["checkOut"]);
                        string[] subs2 = s2.Split(':');
                        String s3 = subs2[0];
                        int n1 = int.Parse(s1);
                        int n2 = int.Parse(s3);
                        if ((n2 - n1) >= 9)
                        {
                            tempAttendance.Status = "Present";
                        }
                        else
                        {
                            tempAttendance.Status = "Absent";
                        }
                        attendances.Add(tempAttendance);
                    }
                    mycon.Close();
                    return attendances;
                }
            }
        }

        public List<AttendanceModel> GetCheckIn(AttendanceModel attendance)
        {
            List<AttendanceModel> attendances = new List<AttendanceModel>();
            string query = "call attendancemanagement.getCheckIn(?,?)";
            string sqlDataSource = _configuration.GetConnectionString("dbConnection");
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(sqlDataSource))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myCommand.Parameters.AddWithValue("@idd", attendance.AITId);
                    myCommand.Parameters.AddWithValue("@dt", attendance.date);
                    myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        AttendanceModel tempAttendance = new AttendanceModel();
                        tempAttendance.AttendanceId = Convert.ToInt32(myReader["Id"]);
                        tempAttendance.AITId = Convert.ToString(myReader["AITId"]);
                        tempAttendance.date = Convert.ToDateTime(myReader["Date"]);
                        tempAttendance.CheckIn = Convert.ToString(myReader["checkIn"]);
                        tempAttendance.CheckOut = Convert.ToString(myReader["checkOut"]);
                        tempAttendance.Status = Convert.ToString(myReader["Status"]);
                        attendances.Add(tempAttendance);
                    }
                    mycon.Close();
                    return attendances;
                }
            }
        }

        public List<AttendanceModel> GetByMonth(string aitid, string month, string year)
        {
            List<AttendanceModel> attendances = new List<AttendanceModel>();
            string query = "call attendancemanagement.getByMonth(?,?,?)";
            string sqlDataSource = _configuration.GetConnectionString("dbConnection");
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(sqlDataSource))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myCommand.Parameters.AddWithValue("@idd", aitid);
                    myCommand.Parameters.AddWithValue("@mnt", month);
                    myCommand.Parameters.AddWithValue("@yrs", year);
                    myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        AttendanceModel tempAttendance = new AttendanceModel();
                        tempAttendance.AttendanceId = Convert.ToInt32(myReader["Id"]);
                        tempAttendance.AITId = Convert.ToString(myReader["AITId"]);
                        tempAttendance.date = Convert.ToDateTime(myReader["Date"]);
                        tempAttendance.CheckIn = Convert.ToString(myReader["checkIn"]);
                        tempAttendance.CheckOut = Convert.ToString(myReader["checkOut"]);
                        String s = Convert.ToString(myReader["checkIn"]);
                        string[] subs = s.Split(':');
                        String s1 = subs[0];
                        String s2 = Convert.ToString(myReader["checkOut"]);
                        string[] subs2 = s2.Split(':');
                        String s3 = subs2[0];
                        int n1 = int.Parse(s1);
                        int n2 = int.Parse(s3);
                        if ((n2 - n1) >= 9)
                        {
                            tempAttendance.Status = "Present";
                        }
                        else
                        {
                            tempAttendance.Status = "Absent";
                        }
                        attendances.Add(tempAttendance);
                    }
                    mycon.Close();
                    return attendances;
                }
            }
        }

        public List<events> GetEvent(string aitid,string start,string end)
        {
            List<events> attendances = new List<events>();
            string query = "call attendancemanagement.getByWeek(?,?,?)";
            string sqlDataSource = _configuration.GetConnectionString("dbConnection");
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(sqlDataSource))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myCommand.Parameters.AddWithValue("@idd", aitid);
                    myCommand.Parameters.AddWithValue("@mnt", start);
                    myCommand.Parameters.AddWithValue("@yrs",end);
                    myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        events tempAttendance = new events();
                        String s = Convert.ToString(myReader["checkIn"]);
                        string[] subs = s.Split(':');
                        String s1 = subs[0];
                        String s2 = Convert.ToString(myReader["checkOut"]);
                        string[] subs2 = s2.Split(':');
                        String s3 = subs2[0];
                        int n1 = int.Parse(s1);
                        int n2 = int.Parse(s3);
                        if ((n2 - n1) >= 9) 
                        {
                            tempAttendance.title = "Present";
                        }
                        else
                        {
                            tempAttendance.title = "Absent";
                        }
                        tempAttendance.start = Convert.ToDateTime(myReader["date"]);
                        tempAttendance.end = Convert.ToDateTime(myReader["date"]);
                        attendances.Add(tempAttendance);
                    }
                    mycon.Close();
                    return attendances;
                }
            }
        }

        public List<AttendanceModel> GetByWeekCount(string aitid, string date1, string date2)
        {
            List<AttendanceModel> attendances = new List<AttendanceModel>();
            string query = "call attendancemanagement.getByWeekStatus(?,?,?)";
            string sqlDataSource = _configuration.GetConnectionString("dbConnection");
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(sqlDataSource))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myCommand.Parameters.AddWithValue("@idd", aitid);
                    myCommand.Parameters.AddWithValue("@dt1", date1);
                    myCommand.Parameters.AddWithValue("@dt2", date2);
                    myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        AttendanceModel tempAttendance = new AttendanceModel();
                        tempAttendance.AttendanceId = Convert.ToInt32(myReader["Id"]);
                        tempAttendance.AITId = Convert.ToString(myReader["AITId"]);
                        tempAttendance.date = Convert.ToDateTime(myReader["Date"]);
                        tempAttendance.CheckIn = Convert.ToString(myReader["checkIn"]);
                        tempAttendance.CheckOut = Convert.ToString(myReader["checkOut"]);
                        tempAttendance.Status = Convert.ToString(myReader["Status"]);
                        attendances.Add(tempAttendance);
                    }
                    mycon.Close();
                    return attendances;
                }
            }
        }
        public List<AttendanceModel> GetRegularization(string aitid)
        {
            List<AttendanceModel> attendances = new List<AttendanceModel>();
            string query = "call attendancemanagement.regularization(?)";
            string sqlDataSource = _configuration.GetConnectionString("dbConnection");
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(sqlDataSource))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myCommand.Parameters.AddWithValue("@idd", aitid);
                    myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        AttendanceModel tempAttendance = new AttendanceModel();
                        tempAttendance.AttendanceId = Convert.ToInt32(myReader["Id"]);
                        tempAttendance.AITId = Convert.ToString(myReader["AITId"]);
                        tempAttendance.date = Convert.ToDateTime(myReader["Date"]);
                        tempAttendance.CheckIn = Convert.ToString(myReader["checkIn"]);
                        tempAttendance.CheckOut = Convert.ToString(myReader["checkOut"]);
                        tempAttendance.Status = Convert.ToString(myReader["Status"]);
                        tempAttendance.Reason = Convert.ToString(myReader["reasonForRegularization"]);
                        tempAttendance.Description = Convert.ToString(myReader["descriptionForRegularization"]);
                        attendances.Add(tempAttendance);
                    }
                    mycon.Close();
                    return attendances;
                }
            }
        }

        public AttendanceModel attendance1(AttendanceModel attendance)
        {
            string query = "insert into attendance(AITId,Date,CheckIn,CheckOut,status,reasonForRegularization,descriptionForRegularization) values(?,?,?,?,?,?,?)";
            string sqlDataSource = _configuration.GetConnectionString("dbConnection");
            using (MySqlConnection mycon = new MySqlConnection(sqlDataSource))
            {

                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myCommand.Parameters.AddWithValue("@AITId", attendance.AITId);
                    myCommand.Parameters.AddWithValue("@Date", attendance.date);
                    myCommand.Parameters.AddWithValue("@CheckIn", attendance.CheckIn);
                    myCommand.Parameters.AddWithValue("@CheckOut", attendance.CheckOut);
                    myCommand.Parameters.AddWithValue("@Status", attendance.Status);
                    myCommand.Parameters.AddWithValue("@reasonForRegularization", attendance.Reason);
                    myCommand.Parameters.AddWithValue("@descriptionForRegularization", attendance.Description);
                    myCommand.ExecuteReader();
                    mycon.Close();
                }
                return attendance;
            }
        }

        public List<AttendanceModel> GetPresentCount(string aitid, string date1, string date2)
        {
            List<AttendanceModel> attendances = new List<AttendanceModel>();
            string query = "call attendancemanagement.getByWeek(?,?,?)";
            string sqlDataSource = _configuration.GetConnectionString("dbConnection");
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(sqlDataSource))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myCommand.Parameters.AddWithValue("@idd", aitid);
                    myCommand.Parameters.AddWithValue("@dt1", date1);
                    myCommand.Parameters.AddWithValue("@dt2", date2);
                    myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        AttendanceModel tempAttendance = new AttendanceModel();
                        tempAttendance.AttendanceId = Convert.ToInt32(myReader["Id"]);
                        tempAttendance.AITId = Convert.ToString(myReader["AITId"]);
                        tempAttendance.date = Convert.ToDateTime(myReader["Date"]);
                        tempAttendance.CheckIn = Convert.ToString(myReader["checkIn"]);
                        tempAttendance.CheckOut = Convert.ToString(myReader["checkOut"]);
                        tempAttendance.Status = Convert.ToString(myReader["Status"]);
                        string s = Convert.ToString(myReader["checkIn"]);
                        string[] subs = s.Split(':');
                        string s1 = subs[0];
                        string s2 = Convert.ToString(myReader["checkOut"]);
                        string[] subs2 = s2.Split(':');
                        string s3 = subs2[0];
                        int n1 = int.Parse(s1);
                        int n2 = int.Parse(s3);
                        if ((n2 - n1) >= 9)
                        {
                            attendances.Add(tempAttendance);
                        }
                    }
                    mycon.Close();
                    return attendances;
                }
            }
        }
        public List<AttendanceModel> GetAbsentCount(string aitid, string date1, string date2)
        {
            List<AttendanceModel> attendances = new List<AttendanceModel>();
            string query = "call attendancemanagement.getByWeek(?,?,?)";
            string sqlDataSource = _configuration.GetConnectionString("dbConnection");
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(sqlDataSource))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myCommand.Parameters.AddWithValue("@idd", aitid);
                    myCommand.Parameters.AddWithValue("@dt1", date1);
                    myCommand.Parameters.AddWithValue("@dt2", date2);
                    myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        AttendanceModel tempAttendance = new AttendanceModel();
                        tempAttendance.AttendanceId = Convert.ToInt32(myReader["Id"]);
                        tempAttendance.AITId = Convert.ToString(myReader["AITId"]);
                        tempAttendance.date = Convert.ToDateTime(myReader["Date"]);
                        tempAttendance.CheckIn = Convert.ToString(myReader["checkIn"]);
                        tempAttendance.CheckOut = Convert.ToString(myReader["checkOut"]);
                        tempAttendance.Status = Convert.ToString(myReader["Status"]);
                        String s = Convert.ToString(myReader["checkIn"]);
                        string[] subs = s.Split(':');
                        String s1 = subs[0];
                        String s2 = Convert.ToString(myReader["checkOut"]);
                        string[] subs2 = s2.Split(':');
                        String s3 = subs2[0];
                        int n1 = int.Parse(s1);
                        int n2 = int.Parse(s3);
                        if ((n2 - n1) < 9)
                        {
                            attendances.Add(tempAttendance);
                        }
                    }
                    mycon.Close();
                    return attendances;
                }
            }
        }

        public List<AttendanceModel> GetPresentByMonth(string aitid,string month,string year)
        {
            List<AttendanceModel> attendances = new List<AttendanceModel>();
            string query = "call attendancemanagement.getPresentByMonth(?,?,?)";
            string sqlDataSource = _configuration.GetConnectionString("dbConnection");
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(sqlDataSource))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myCommand.Parameters.AddWithValue("@idd", aitid);
                    myCommand.Parameters.AddWithValue("@mnt", month);
                    myCommand.Parameters.AddWithValue("@yrs", year);
                    myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        AttendanceModel tempAttendance = new AttendanceModel();
                        tempAttendance.AttendanceId = Convert.ToInt32(myReader["Id"]);
                        tempAttendance.AITId = Convert.ToString(myReader["AITId"]);
                        tempAttendance.date = Convert.ToDateTime(myReader["Date"]);
                        tempAttendance.CheckIn = Convert.ToString(myReader["checkIn"]);
                        tempAttendance.CheckOut = Convert.ToString(myReader["checkOut"]);
                        tempAttendance.Status = Convert.ToString(myReader["Status"]);
                        String s = Convert.ToString(myReader["checkIn"]);
                        string[] subs = s.Split(':');
                        String s1 = subs[0];
                        String s2 = Convert.ToString(myReader["checkOut"]);
                        string[] subs2 = s2.Split(':');
                        String s3 = subs2[0];
                        int n1 = int.Parse(s1);
                        int n2 = int.Parse(s3);
                        if ((n2 - n1) >= 9)
                        {
                            attendances.Add(tempAttendance);
                        }
                    }
                    mycon.Close();
                    return attendances;
                }
            }
        }

        public List<AttendanceModel> GetAbsentByMonth(string aitid, string month, string year)
        {
            List<AttendanceModel> attendances = new List<AttendanceModel>();
            string query = "call attendancemanagement.getPresentByMonth(?,?,?)";
            string sqlDataSource = _configuration.GetConnectionString("dbConnection");
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(sqlDataSource))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myCommand.Parameters.AddWithValue("@idd", aitid);
                    myCommand.Parameters.AddWithValue("@mnt", month);
                    myCommand.Parameters.AddWithValue("@yrs", year);
                    myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        AttendanceModel tempAttendance = new AttendanceModel();
                        tempAttendance.AttendanceId = Convert.ToInt32(myReader["Id"]);
                        tempAttendance.AITId = Convert.ToString(myReader["AITId"]);
                        tempAttendance.date = Convert.ToDateTime(myReader["Date"]);
                        tempAttendance.CheckIn = Convert.ToString(myReader["checkIn"]);
                        tempAttendance.CheckOut = Convert.ToString(myReader["checkOut"]);
                        tempAttendance.Status = Convert.ToString(myReader["Status"]);
                        String s = Convert.ToString(myReader["checkIn"]);
                        string[] subs = s.Split(':');
                        String s1 = subs[0];
                        String s2 = Convert.ToString(myReader["checkOut"]);
                        string[] subs2 = s2.Split(':');
                        String s3 = subs2[0];
                        int n1 = int.Parse(s1);
                        int n2 = int.Parse(s3);
                        if ((n2 - n1) < 9)
                        {
                            attendances.Add(tempAttendance);
                        }
                    }
                    mycon.Close();
                    return attendances;
                }
            }
        }

    }
}
