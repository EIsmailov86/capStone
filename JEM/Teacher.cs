using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEM
{
    internal class Teacher
    {
        public int Id { get; set; }
        public int AdminId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int TeClassId { get; set; }
        public string ImageTeacher { get; set; }
    }
}
