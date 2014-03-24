using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

using Domain;
using ManagementLayer;

namespace Services
{
    public class PatientsService : IPatientsService
    {
        IPatientManagement mgmt;

        /// <summary>
        /// Returns all Patients from the database
        /// </summary>
        /// <returns>AllPatientDto</returns>
        public AllPatientsDto GetAllPatients()
        {
            mgmt = new PatientManagement();
            //return new GetAllPatientsResponse { Patients = mgmt.GetAllPatients() };
            return mgmt.GetAllPatients();
        }

        /// <summary>
        /// Fetch a Patient from the database
        /// </summary>
        /// <param name="id">PatientID (int)</param>
        /// <returns>PatientDto</returns>
        public PatientDto GetPatientByID(int patientID)
        {
            mgmt = new PatientManagement();
            //return new GetPatientResponse { Patient = mgmt.GetPatientByID(getPatientRequest.patientID) };
            return mgmt.GetPatientByID(patientID);
        }
    }
}
