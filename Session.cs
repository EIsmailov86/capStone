using System;

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
        public decimal RemainingBudget { get; set; }
    }
}
