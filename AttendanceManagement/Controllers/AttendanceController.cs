using AttendanceManagement.Business;
using AttendanceManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AttendanceManagement.Controllers
{
    [ApiController]
    public class AttendanceController : ControllerBase
    {
        private readonly IAttendanceClass _attendanceClass;
        public AttendanceController(IAttendanceClass attendanceClass)
        {
            _attendanceClass = attendanceClass;
        }

        [HttpPost]
        [Route("attendance")]
        public IActionResult attendance(AttendanceModel attendance)
        {
            try
            {
                return Ok(_attendanceClass.attendance(attendance));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("attendance1")]
        public IActionResult attendance1(AttendanceModel attendance)
        {
            try
            {
                return Ok(_attendanceClass.attendance1(attendance));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("getAttendanceByDate")]
        public IActionResult GetAttendance(string aitid, string date)
        {   
            try
            {
                return Ok(_attendanceClass.GetAttendance(aitid,date));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("getAttendanceByWeek")]
        public IActionResult GetByWeek(string aitid, string date1,string date2)
        {
            try
            {
                return Ok(_attendanceClass.GetByWeek(aitid,date1,date2));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("getAttendanceByMonth")]
        public IActionResult GetByMonth(string aitid, string month, string year)
        {
            try
            {
                return Ok(_attendanceClass.GetByMonth(aitid,month,year));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("getEvents")]
        public IActionResult GetEvents(string aitid,string start,string end)
        {
                return Ok(_attendanceClass.GetEvent(aitid,start,end));
        }

        [HttpGet]
        [Route("getAttendanceByWeekCount")]
        public IActionResult GetByWeekCount(string aitid, string date1, string date2)
        {
            try
            {
                return Ok(_attendanceClass.GetByWeekCount(aitid,date1,date2));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("getRegularization")]
        public IActionResult GetRegularization(string aitid)
        {
            try
            {
                return Ok(_attendanceClass.GetRegularization(aitid));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("getCheckIn")]
        public IActionResult GetCheckIn(AttendanceModel attendance)
        {
            try
            {
                return Ok(_attendanceClass.GetCheckIn(attendance));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("getCheckOut")]
        public IActionResult CheckOut(AttendanceModel attendance)
        {
            try
            {
                return Ok(_attendanceClass.CheckOut(attendance));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("getPresentCount")]
        public IActionResult PresentCount(string aitid, string date1, string date2)
        {
            try
            {
                return Ok(_attendanceClass.GetPresentCount(aitid,date1,date2));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("getAbsentCount")]
        public IActionResult AbsentCount(string aitid, string date1, string date2)
        {
            try
            {
                return Ok(_attendanceClass.GetAbsentCount(aitid, date1, date2));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("getMonthlyPresentCount")]
        public IActionResult MonthlyPresentCount(string aitid, string month, string year)
        {
            try
            {
                return Ok(_attendanceClass.GetPresentByMonth(aitid, month, year));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("getMonthlyAbsentCount")]
        public IActionResult MonthlyAbsentCount(string aitid, string month, string year)
        {
            try
            {
                return Ok(_attendanceClass.GetAbsentByMonth(aitid, month, year));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
