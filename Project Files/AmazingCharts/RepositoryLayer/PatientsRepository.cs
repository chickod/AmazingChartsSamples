using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccessLayer;
using Domain;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.Entity;

namespace RepositoryLayer
{
    public class PatientsRepository : IPatientsRepository
    {
        ACEntities dbContext;
        
        /// <summary>
        /// Add a new Patient to the database
        /// </summary>
        /// <param name="entity">PatientDto</param>
        public void Add(PatientDto entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Update an existing Patient record
        /// </summary>
        /// <param name="entity">PatientDto</param>
        public void Update(PatientDto entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Delete a Patient from the database
        /// </summary>
        /// <param name="entity">PatientDto</param>
        public void Delete(PatientDto entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Fetch a Patient from the database
        /// </summary>
        /// <param name="id">PatientID (int)</param>
        /// <returns>PatientDto</returns>
        public PatientDto GetByID(int id)
        {
            PatientDto patient;

            //using (dbContext = new ACEntities())
            //{
            //    Patient pat = dbContext.uspGetPatient(id).FirstOrDefault();

            //    patient = new PatientDto
            //    {
            //        PatientID = pat.PatientID,
            //        FirstName = pat.FirstName,
            //        LastName = pat.LastName,
            //        DateOfBirth = pat.DateOfBirth,
            //        PhoneNumber = pat.PhoneNumber
            //    };
            //}

            dbContext = new ACEntities();

            Patient pat = dbContext.uspGetPatient(id).FirstOrDefault();

            patient = new PatientDto
            {
                PatientID = pat.PatientID,
                FirstName = pat.FirstName,
                LastName = pat.LastName,
                DateOfBirth = pat.DateOfBirth,
                PhoneNumber = pat.PhoneNumber
            };

            return patient;
        }

        /// <summary>
        /// Retrieve all Patients from the database
        /// </summary>
        /// <returns>AllPatientDto</returns>
        public AllPatientsDto GetAll()
        {
            AllPatientsDto patients = new AllPatientsDto();
            patients.Patients = new List<PatientDto>();

            //using (dbContext = new ACEntities())
            //{
            //    List<Patient> patientList = dbContext.uspGetAllPatients().ToList<Patient>();

            //    foreach (Patient p in patientList)
            //    {
            //        PatientDto newPatient = new PatientDto
            //        {
            //            PatientID = p.PatientID,
            //            FirstName = p.FirstName,
            //            LastName = p.LastName,
            //            DateOfBirth = p.DateOfBirth,
            //            PhoneNumber = p.PhoneNumber
            //        };
            //        patients.Patients.Add(newPatient);
            //    }
            //};

            dbContext = new ACEntities();

            List<Patient> patientList = dbContext.uspGetAllPatients().ToList<Patient>();

            foreach (Patient p in patientList)
            {
                PatientDto newPatient = new PatientDto
                {
                    PatientID = p.PatientID,
                    FirstName = p.FirstName,
                    LastName = p.LastName,
                    DateOfBirth = p.DateOfBirth,
                    PhoneNumber = p.PhoneNumber
                };
                patients.Patients.Add(newPatient);
            }
            return patients;
        }
    }
}
