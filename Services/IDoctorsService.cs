using DoctorsNearMeAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorsNearMeAPI.Services
{
    public interface IDoctorsService
    {
        public Doctor AddDoctor(Doctor doctor);
        public List<Doctor> GetDoctors();
        public Doctor GetDoctorById(int id);
        public Doctor UpdateDoctor(int id, Doctor doctor);
        public Doctor UpdateDoctorsPhoneAndAddress(int id,string phone,string address);
        public int DeleteDoctor(int id);
    }
}
