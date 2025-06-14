using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.SchoolEntities
{
    public class AdmissionEntities
    {
        public int Id { get; set; }
        public string ApplicantName { get; set; } = string.Empty;
        public string AppliedClass { get; set; } = string.Empty;
        public DateTime AppliedDate { get; set; }
        public bool IsApproved { get; set; }
    }
}
