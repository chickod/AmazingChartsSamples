using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Domain;
using ManagementLayer;
using RepositoryLayer;

namespace ACTests
{
    [TestClass]
    public class PatientsTests
    {
        [TestMethod]
        public void RepositoryLayerTest()
        {
            PatientsRepository rep = new PatientsRepository();
            AllPatientsDto patients = rep.GetAll();

            Assert.IsNotNull(patients);
        }

        [TestMethod]
        public void ManagementLayerTest()
        {
            PatientManagement mgmt = new PatientManagement();
            AllPatientsDto patients = mgmt.GetAllPatients();

            Assert.IsNotNull(patients);
        }
    }
}
