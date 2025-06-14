using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.SchoolEntities
{
    public class TeacherEntities
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Subject { get; set; } = string.Empty;
        public DateTime DateOfJoining { get; set; }
    }
}
