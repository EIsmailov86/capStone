using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEM
{
    internal class Session
    {
        public int SessionId { get; set; }
        public int StudentId { get; set; }
        public int TeacherId { get; set; }
        public DateTime SessionDate { get; set; }
        public int SubjectId { get; set; }
        public string TimeSlot { get; set; }
        public decimal Cost { get; set; }
    }
}
