using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorsNearMeAPI.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Education { get; set; }
        public string Description { get; set; }
        public string Experience { get; set; }
        public int ConsultingFees { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string ImagePath { get; set; }
        public string IsVerified { get; set; }
    }
}
