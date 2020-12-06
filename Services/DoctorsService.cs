using DoctorsNearMeAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorsNearMeAPI.Services
{
    public class DoctorsService : IDoctorsService
    {
        private static List<Doctor> _doctorList;
        public DoctorsService()
        {
            if (_doctorList == null)
                _doctorList = new List<Doctor>();
        }
        public Doctor AddDoctor(Doctor doctor)
        {
            _doctorList.Add(doctor);
            return doctor;
        }
        public List<Doctor> GetDoctors()
        {
            return _doctorList;
        }
        public Doctor GetDoctorById(int id)
        {
            return _doctorList.FirstOrDefault(c => c.Id == id);
        }

        public Doctor UpdateDoctor(int id, Doctor doctor)
        {
            for (var index = 0; index < _doctorList.Count; index++)
            {
                if (_doctorList[index].Id == id)
                {
                    _doctorList[index] = doctor;
                }
            }
            return doctor;
        }

        public Doctor UpdateDoctorsPhoneAndAddress(int id, string phone, string address)
        {
            Doctor doctor = null;
            for (var index = 0; index < _doctorList.Count; index++)
            {
                if (_doctorList[index].Id == id)
                {
                    _doctorList[index].Phone = phone;
                    _doctorList[index].Address = address;
                    doctor = _doctorList[index];
                }
            }
            return doctor;
        }
        public int DeleteDoctor(int id)
        {
            for (var index = 0; index < _doctorList.Count; index++)
            {
                if (_doctorList[index].Id == id)
                {
                    _doctorList.RemoveAt(index);
                }
            }
            return id;
        }
    }
}
