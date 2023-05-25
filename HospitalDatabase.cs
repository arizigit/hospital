using hospital;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital
{
    internal class HospitalDatabase 
    {
        public static List<Physician> GetPhysicians ()
        {
            List<Physician> physicians = new List<Physician>();

            physicians.Add(new Physician(1, "Doe", "John", 35, 1200));
            physicians.Add(new Physician(2, "Adams", "Sofia", 40, 1300));
            physicians.Add(new Physician(3, "Andrews", "Tom", 45, 1500));




            return physicians;
        }

        public static List<Patient> GetPatients()
        {
            List<Patient> patients = new List<Patient>();   

            return patients;
        }
    }
}








