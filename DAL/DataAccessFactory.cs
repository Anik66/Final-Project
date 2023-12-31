using DAL.Interfaces;
using DAL.Models;
using DAL.Models.Patient_Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Manager, string, bool> ManagerData()
        {
            return new ManagerRepo();
        }
        public static IRepo<Doctor, string, bool> DoctorData()
        {
            return new DoctorRepo();
        }
        public static IRepo<Fee, int, bool> FeeData()
        {
            return new FeeRepo();
        }
        public static IRepo<AppDetail, int, bool> AppDetailData()
        {
            return new AppDetailRepo();
        }
        public static IRepo<Token, string, Token> TokenData()
        {
            return new TokenRepo();
        }
        public static IAuth<bool> AuthData()
        {
            return new ManagerRepo();
        }
        public static IRepo<Patient, string, bool> PatientData() 
        { 
            return new PatientRepo(); 
        }
        public static IRepo<Appointment,int, bool> AppointmentData() 
        {
            return new AppointmentRepo();
        }
    }
}
