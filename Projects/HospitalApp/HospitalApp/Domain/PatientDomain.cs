﻿using HospitalApp.Contex;
using HospitalApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HospitalApp.Domain
{
    class PatientDomain : MainContext
    {
        public void AddPatient(Patient patient)
        {
            try { 
                var db = new MainContext();
                db.patients.Add(patient);
                int res = db.SaveChanges();
                if (res > 0)
                    Console.WriteLine("Patient Add Successfully....");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void AddAppointment(Appointment appointment)
        {
            try {
                var db = new MainContext();
                db.appointments.Add(appointment);
                int res = db.SaveChanges();
                if (res > 0)
                    Console.WriteLine("Appointment Add Successfully....");
             }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public List<Patient> GetPatients()
        {
            return patients.ToList();
        }
    }
}
