using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital
{
    internal class Hospital
    {
        private List<Physician> physicians;
        private List<Patient> patients;
        private List<Room> rooms;
        private List<Hospitalization> hospitalizations;
        private List<Nurse> nurses;
        public Hospital()
        {
            physicians = new List<Physician>();
            patients = new List<Patient>();
            rooms = new List<Room>();
            nurses = new List<Nurse>();
            hospitalizations = new List<Hospitalization>();

            physicians = HospitalDatabase.GetPhysicians();
            patients = HospitalDatabase.GetPatients();
            

        }
        // Add a physician to the hospital
        public void AddPhysician(Physician physician)
        {
            physicians.Add(physician);
        }

        // Add a patient to the hospital
        public void AddPatient(Patient patient)
        {
            patients.Add(patient);
        }

        // Add a room to the hospital
        public void AddRoom(Room room)
        {
            rooms.Add(room);
        }

        // Add a hospitalization to the hospital
        public void AddHospitalization(Hospitalization hospitalization)
        {
            hospitalizations.Add(hospitalization);
        }

        // Print a list of physicians
        public void PrintPhysicians()
        {
            Console.WriteLine("List of Physicians:");
            foreach (var physician in physicians)
            {
                Console.WriteLine($"Id: {physician.Id}, Name: {physician.FirstName} {physician.LastName}");
            }
        }

        // Print a list of patients
        public void PrintPatients()
        {
            Console.WriteLine("List of Patients:");
            foreach (var patient in patients)
            {
                Console.WriteLine($"Id: {patient.Id}, Name: {patient.FirstName} {patient.LastName}");
            }
        }

        // Print a list of rooms
        public void PrintRooms()
        {
            Console.WriteLine("List of Rooms:");
            foreach (var room in rooms)
            {
                Console.WriteLine($"Id: {room.Id}, Name: {room.Name}");
            }
        }

        // Print the patients of a room
        public void PrintRoomPatients(int roomId)
        {
            Room room = null;
            foreach(Room r in rooms)
            {
                if(r.Id == roomId)
                {
                    room = r;
                    break;
                }
            }
            if (room == null)
            {
                Console.WriteLine("Room not found");
            }
            else
            {
                Console.WriteLine($"Patients in Room {room.Name}:");
                foreach (var patient in room.Patients)
                {
                    Console.WriteLine($"{patient.FirstName} {patient.LastName}");
                }
            }
        }
        // Print the history of a patient
        public void PrintPatientHistory(Patient patient)
        {
            Console.WriteLine($"History of Patient {patient.FirstName} {patient.LastName}:");
            foreach (var hospitalization in hospitalizations)
            {
                if (hospitalization.Patient.Id == patient.Id)
                {
                    Console.WriteLine($"Hospitalization: {hospitalization.AdmissionDate} - {hospitalization.DischargeDate}");
                    Console.WriteLine($"Disease: {hospitalization.Disease}");
                    Console.WriteLine($"Attending Physician: {hospitalization.AttendingPhysician}");
                }
            }
        }

        // Register a new patient
        public void RegisterPatient(Patient patient)
        {
            patients.Add(patient);
            Console.WriteLine($"Patient {patient.FirstName} {patient.LastName} registered successfully.");
        }

        // Register a new hospitalization
        public void RegisterHospitalization(Hospitalization hospitalization)
        {
            hospitalizations.Add(hospitalization);
            Console.WriteLine($"Hospitalization for Patient {hospitalization.Patient.FirstName} {hospitalization.Patient.LastName} registered successfully.");
        }
        // Print the inpatients attended by a physician
        public void PrintDoctorInpatients(string physicianName)
        {
            Console.WriteLine($"Inpatients attended by {physicianName}:");
            // Implement code to retrieve and print the inpatients attended by the specified physician
        }


        // Discharge a patient
        public void DischargePatient(Patient patient)
        {
            // Implement code to discharge the patient from hospitalization
        }

    }
}

