using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain;
using RepositoryLayer;

namespace ManagementLayer
{
    public interface IPatientManagement
    {
        void AddPatient();
        void UpdatePatient();
        void DeletePatient();
        PatientDto GetPatientByID(int id);
        AllPatientsDto GetAllPatients();
    }
}
