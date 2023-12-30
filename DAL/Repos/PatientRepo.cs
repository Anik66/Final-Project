using DAL.Interfaces;
using DAL.Models;
using DAL.Models.Patient_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class PatientRepo : Repo, IRepo<Patient, string, Patient>
    {
        public Patient Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<Patient> Get()
        {
            throw new NotImplementedException();
        }

        public Patient Get(string id)
        {
            throw new NotImplementedException();
        }

        public Patient Insert(Patient obj)
        {
            throw new NotImplementedException();
        }

        public Patient Update(Patient obj)
        {
            throw new NotImplementedException();
        }
    }
}
