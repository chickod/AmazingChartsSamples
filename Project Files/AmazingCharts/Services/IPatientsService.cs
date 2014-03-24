using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

using Domain;

namespace Services
{
    [ServiceContract]
    public interface IPatientsService
    {
        [OperationContract]
        AllPatientsDto GetAllPatients();

        [OperationContract]
        PatientDto GetPatientByID(int patientID);
    }
}

