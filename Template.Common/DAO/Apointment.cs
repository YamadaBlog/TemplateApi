using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Template.Common.Core;

namespace Template.Common.DAO;

public class Apointment : Entity
{
    public DateTime Date { get; set; }
    public int PatientId { get; set; }
    public Patient Patient { get; set; }
    public int DoctorId { get; set; }
    public Doctor Doctor { get; set; }
}
