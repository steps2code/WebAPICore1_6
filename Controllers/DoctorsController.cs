using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoctorsNearMeAPI.Models;
using DoctorsNearMeAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DoctorsNearMeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private IDoctorsService _service;
        public DoctorsController(IDoctorsService doctorsService)
        {
            _service = doctorsService;
        }
        [HttpPost]
        //[Consumes("application/xml")]
        public ActionResult<Doctor> AddDoctor(Doctor doctor)
        {
            return _service.AddDoctor(doctor);
        }

        [HttpGet]
        public ActionResult<List<Doctor>> GetDoctors()
        {
            return _service.GetDoctors();
        }

        [HttpGet("{id}")]
        public ActionResult<Doctor> GetDoctorById(int id)
        {
            return _service.GetDoctorById(id);
        }

        [HttpPut("{id}")]
        public ActionResult<Doctor> UpdateDoctor(int id, Doctor doctor)
        {
            return _service.UpdateDoctor(id, doctor);
        }

        [HttpPatch("{id}/{phone}/{address}")]
        public ActionResult<Doctor> UpdateDoctor(int id, string phone, string address)
        {
            return _service.UpdateDoctorsPhoneAndAddress(id, phone, address);
        }

        [HttpDelete("{id}")]
        public ActionResult<int> DeleteDoctor(int id)
        {
            return _service.DeleteDoctor(id);
        }
    }
}