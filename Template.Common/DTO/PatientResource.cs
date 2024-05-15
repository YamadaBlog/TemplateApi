using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Common.Core;

namespace Template.Common.DTO;

public class PatientResource : EntityResource
{
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Gender { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
}
