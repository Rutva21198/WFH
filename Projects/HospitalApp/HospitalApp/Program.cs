using HospitalApp.Domain;
using HospitalApp.Model;
using System;

namespace HospitalApp
{
    class Program
    {

        static void Main(string[] args)
        {
           bool carryon = true;
            while (carryon)
            {
                Console.WriteLine("Welcome in Hospital App...\n1. Add Patient \n2. View Patient\n3. Add Doctor\n4. View Doctor\n5. Take Appointment\n6. Allot Drugs\nEnter Your Choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Patient p = new Patient();
                        Console.WriteLine("Enter First Name : ");
                        p.FirstName = Console.ReadLine();
                        Console.WriteLine("Enter Last Name : ");
                        p.LastName = Console.ReadLine();
                        Console.WriteLine("Enter Age : ");
                        p.Age = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Gender : ");
                        var Gender = Console.ReadLine();
                        if (Gender.Equals("Female") || Gender.Equals("female"))
                        {
                            p.Gender = true;
                        }
                        if (Gender.Equals("Male") || Gender.Equals("male"))
                        {
                            p.Gender = false;
                        }
                        PatientDomain patientDomain = new PatientDomain();
                        patientDomain.AddPatient(p);

                        break;
                    case 2:
                        Console.WriteLine("\n====== View All Patients =====");

                        PatientDomain patient = new PatientDomain();

                        int j = 1;
                        foreach (Patient pt in patient.GetPatients())
                        {
                            Console.WriteLine("Patient - " + j);
                            Console.WriteLine("Id : " + pt.PatientId);
                            Console.WriteLine("Name : " + pt.FirstName + " " + pt.LastName);
                            Console.WriteLine("DoctorId : " + pt.Gender);
                            Console.WriteLine("------------------------------------------------");
                        }
                        break;

                    case 3:
                        Doctor dr = new Doctor();
                        Console.WriteLine("Enter Name : ");
                        dr.Name = Console.ReadLine();
                        Console.WriteLine("Enter Degree : ");
                        dr.Degree = Console.ReadLine();
                        Console.WriteLine("Enter WorkExperience : ");
                        dr.WorkExperience = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Gender : ");
                        Gender = Console.ReadLine();
                        if (Gender.Equals("Female") || Gender.Equals("female"))
                        {
                            dr.Gender = true;
                        }
                        if (Gender.Equals("Male") || Gender.Equals("male"))
                        {
                            dr.Gender = false;
                        }
                        Console.WriteLine("\n--------View Doctors Department----------");

                        DoctorDomain dpDomain = new DoctorDomain();

                        foreach (Departments dp in dpDomain.GetDepartments())
                        {
                            Console.WriteLine("DepartmentId : " + dp.DepartmentId);
                            Console.WriteLine("DepartmentName : " + dp.Department);
                        }
                        Console.WriteLine("Enter DepartmentId : ");
                        dr.DepartmentId = Convert.ToInt32(Console.ReadLine());
                        DoctorDomain doctorDomain1 = new DoctorDomain();
                        doctorDomain1.AddDoctor(dr);
                        break;

                    case 4:
                        Console.WriteLine("\n====== View All Doctors =====");

                        DoctorDomain doctorDomain = new DoctorDomain();

                        int i = 1;
                        foreach (Doctor doctor in doctorDomain.GetDoctors())
                        {
                            Console.WriteLine("Doctor - " + i);
                            Console.WriteLine("DoctorId : " + doctor.DoctorId);
                            Console.WriteLine("Name : " + doctor.Name);
                            Console.WriteLine("Degree : " + doctor.Degree);
                            Console.WriteLine("WorkExperience : " + doctor.WorkExperience);
                            Console.WriteLine("------------------------------------------------");
                        }
                        break;

                    case 5:
                        Appointment ap = new Appointment();
                        Console.WriteLine("Enter Patient Name : ");
                        ap.PatientName = Console.ReadLine();
                        Console.WriteLine("Enter Age : ");
                        ap.Age = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Gender : ");
                        Gender = Console.ReadLine();
                        if (Gender.Equals("Female") || Gender.Equals("female"))
                        {
                            ap.Gender = true;
                        }
                        if (Gender.Equals("Male") || Gender.Equals("male"))
                        {
                            ap.Gender = false;
                        }
                        Console.WriteLine("Enter Patient Problem : ");
                        ap.Problem = Console.ReadLine();
                        Console.WriteLine("Enter PatientId those already added : ");
                        ap.PatientId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Doctor Id : ");
                        ap.DoctorId = Convert.ToInt32(Console.ReadLine());
                        AppointmentDomain ad = new AppointmentDomain();
                        ad.AddAppointment(ap);
                        break;

                    case 6:
                        DrugAllocation da = new DrugAllocation();
                        Console.WriteLine("Enter Drug Id : ");
                        da.DrugId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Patient Id : ");
                        da.PatientId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Age : ");
                        da.DoctorId = Convert.ToInt32(Console.ReadLine());
                        DrugDomain dd = new DrugDomain();
                        dd.DrugAllocation(da);
                        break;

                    default:
                        Console.WriteLine("You Enter Invalid Choice \n Thank You for Visisting...");
                        Console.ReadLine();
                        break;
                }
                Console.WriteLine("\nDo You want continue? press y for yes\nEnter Key :");
                char c = Convert.ToChar(Console.ReadLine());
                if (c.Equals('y') || c.Equals('Y'))
                {
                    Console.Clear();
                    carryon = true;
                }
                else
                    carryon = false;
            }
        }
    }
}
