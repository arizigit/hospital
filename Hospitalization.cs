using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital
{
    internal class Hospitalization
    {
        public int Id { get; set; }
        public Patient Patient { get; set; }
        public string Disease { get; set; }
        public DateTime AdmissionDate { get; set; }
        public DateTime? DischargeDate { get; set; }
        public Room Room { get; set; }
        public Physician AttendingPhysician { get; set; }
    }
}
