using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using RepositoryLayer;

using System.Diagnostics;
using System.IO;

namespace ManagementLayer
{
    public class PatientManagement : IPatientManagement
    {
        IPatientsRepository repository;
        static int logCount = 1;

        public void AddPatient()
        {
            throw new NotImplementedException();
        }

        public void UpdatePatient()
        {
            throw new NotImplementedException();
        }

        public void DeletePatient()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns a Patient from the database
        /// </summary>
        /// <param name="id">PatientID (int)</param>
        /// <returns>PatientDto</returns>
        public PatientDto GetPatientByID(int id)
        {
            repository = new PatientsRepository();
            PatientDto patient = repository.GetByID(id);
            patient.PhoneNumber = ParsePhoneNumber(patient.PhoneNumber);
            
            // Write patient contact information to text file
            WriteToTextFile(patient);

            // Write patient contact information to Windwos event log
            WriteToEventLog(patient);

            // Return patient to front end 
            return patient;
        }

        /// <summary>
        /// Returns all Patients from the database
        /// </summary>
        /// <returns>AllPatientsDto</returns>
        public AllPatientsDto GetAllPatients()
        {
            repository = new PatientsRepository();
            AllPatientsDto patients = repository.GetAll();

            return patients;
        }

        #region Private Methods

        /// <summary>
        /// Utility class to format PhoneNumber field for UI display
        /// </summary>
        /// <param name="number">string (number)</param>
        /// <returns>string</returns>
        private string ParsePhoneNumber(string number)
        {
            return (String.Format("{0}-{1}-{2}", number.Substring(0, 3), number.Substring(3, 3), number.Substring(6, 4)));
        }

        /// <summary>
        /// Utility class to write selected Patient information to EventLog
        /// </summary>
        /// <param name="patient">PatientDto</param>
        private void WriteToEventLog(PatientDto patient)
        {
            string app = "Amazing Charts";
            string name = "Amazing Charts Log";

            if (!EventLog.SourceExists(app))
                EventLog.CreateEventSource(app, name);

            EventLog.WriteEntry(app, patient.ToString(), EventLogEntryType.Information);
        }

        /// <summary>
        /// Utility class to write selected Patient information to a new text file
        /// </summary>
        /// <param name="patient">PatientDto</param>
        private void WriteToTextFile(PatientDto patient)
        {
            string path = @"C:\Logs";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            StringBuilder sb = new StringBuilder();
            sb.Append("C:\\Logs\\ACLog");
            sb.Append(++logCount);
            sb.Append(".txt");
            string filePath = sb.ToString();

            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                writer.WriteLine(String.Format("Date of Entry: {0}", DateTime.Now));
                writer.WriteLine("Selected Patient Information: {0}", patient.ToString());
            }
        }

        #endregion
    }
}
