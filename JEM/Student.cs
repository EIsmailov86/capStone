using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JEM
{
    public class Student
    {
        public int Id { get; internal set; }
        public string Name { get; set; }
        public int GradeId { get; internal set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Bio { get; set; }
        public BudgetManager Budget { get; set; }
        public string SubjectName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int ClassId { get; set; }
        public string ImageStudent { get; set; }

    }
}
