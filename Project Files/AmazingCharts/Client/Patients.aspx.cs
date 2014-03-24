using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Client.PatientsService;
using System.ServiceModel;

namespace Client
{
    public partial class Patients : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                PopulatePatientsDropDown();
                DisplayPatientInformation(5);
        }

        #region Non-Public Methods

        protected void ddlPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayPatientInformation(Convert.ToInt32(ddlPatients.SelectedValue));
        }

        private void DisplayPatientInformation(int patientID)
        {
            PatientsServiceClient proxy = new PatientsServiceClient();
            PatientDto patient = proxy.GetPatientByID(patientID);

            lblPatients.Text = patient.Name;
        }

        private void PopulatePatientsDropDown()
        {
            PatientsServiceClient proxy = new PatientsServiceClient();
            //System.Net.ServicePointManager.Expect100Continue = false;
            AllPatientsDto patientList = proxy.GetAllPatients();

            PatientDto[] patients = patientList.Patients;

            ddlPatients.DataTextField = "Name";
            ddlPatients.DataValueField = "PatientID";
            ddlPatients.DataSource = patients;
            ddlPatients.DataBind();
        }

        #endregion
    }
}