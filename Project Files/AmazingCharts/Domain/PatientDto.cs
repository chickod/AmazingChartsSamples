using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;

namespace Domain
{
    [DataContract]
    [Serializable]
    public class PatientDto
    {
        #region Public Properties

        [DataMember]
        public int PatientID { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public DateTime DateOfBirth { get; set; }

        [DataMember]
        public string PhoneNumber { get; set; }

        [DataMember]
        public string Name
        {
            get { return FirstName + " " + LastName; }
        }

        #endregion
    }

    [DataContract]
    [Serializable]
    public class AllPatientsDto
    {
        [DataMember]
        public List<PatientDto> Patients { get; set; }
    }
}
