using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Common.Core;
using Template.Common.DAO;

namespace Template.Common.DTO;

public class ApointmentResource : EntityResource
{
    public DateTime Date { get; set; }
    public int PatientId { get; set; }
    public int DoctorId { get; set; }
}
