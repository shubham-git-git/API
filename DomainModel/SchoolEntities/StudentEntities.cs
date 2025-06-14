using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.SchoolEntities
{
    public class StudentEntities
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; } = string.Empty;
        public string Class { get; set; } = string.Empty;
        public bool IsAdmitted { get; set; }
        public DateTime AdmissionDate { get; set; }
    }
}
