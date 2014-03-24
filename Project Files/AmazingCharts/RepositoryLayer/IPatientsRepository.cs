using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccessLayer;
using Domain;

namespace RepositoryLayer
{
    public interface IPatientsRepository
    {
        void Add(PatientDto entity);
        void Update(PatientDto entity);
        void Delete(PatientDto entity);
        PatientDto GetByID(int id);
        AllPatientsDto GetAll();
    }
}
