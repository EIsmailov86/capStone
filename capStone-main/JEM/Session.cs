using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEM
{
    public class Session
    {
        public int SessionId { get; set; }
        public string StudentName { get; set; }
        public string TeacherName { get; set; }
        public DateTime SessionDate { get; set; }
        public string GradeYear { get; set; }
        public string SubjectName { get; set; }
        public string TimeSlot { get; set; }
        public decimal Cost { get; set; }
    }
}
