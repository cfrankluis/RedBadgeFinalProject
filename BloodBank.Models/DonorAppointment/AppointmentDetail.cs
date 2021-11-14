﻿using BloodBank.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Models.DonorAppointment
{
    public class AppointmentDetail
    {
        public int AppointmentID { get; set; }
        public Guid DonorId { get; set; }
        public DateTime AppoinmentTime { get; set; }
        public StatusValues Status { get; set; }
    }
}
