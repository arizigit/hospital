using hospital;

Hospital myHospital = new Hospital();

Console.WriteLine("OK");

// Menu-driven program   
int choice = 0;
do
{
    Console.WriteLine("Hospital Management System");
    Console.WriteLine("-------------------------");
    Console.WriteLine("2. Print list of doctors");
    Console.WriteLine("3. Print list of patients");
    Console.WriteLine("4. Print list of rooms");
    Console.WriteLine("5. Print patients of a room");
    Console.WriteLine("6. Print inpatients attended by a doctor");
    Console.WriteLine("7. Print history of a patient");
    Console.WriteLine("8. Register a new patient");
    Console.WriteLine("9. Register a new hospitalization");
    Console.WriteLine("10. Discharge a patient");
    Console.WriteLine("0. Exit");
    Console.Write("Enter your choice: ");
    choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 2:
            myHospital.PrintPhysicians();
            break;
        case 3:
            myHospital.PrintPatients();
            break;
        case 4:
            myHospital.PrintRooms();
            break;
        case 5:
            Console.Write("Room ID: ");
            int id = Int32.Parse(Console.ReadLine());
            myHospital.PrintRoomPatients(id);
            break;
        /*
    case 6:
        myHospital.PrintInpatientsAttendedByDoctor();
        break;
    case 7:
        myHospital.PrintPatientHistory();
        break;
    case 8:
        myHospital.RegisterNewPatient();
        break;
    case 9:
        myHospital.RegisterNewHospitalization();
        break;
    case 10:
        myHospital.DischargePatient();
        break;
        */
        case 0:
            Console.WriteLine("Exiting...");
            break;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }
} while(choice != 0);


