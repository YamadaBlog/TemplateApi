using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Common.Core;

namespace Template.Common.DAO;

public class Doctor : Entity
{
    public string Name { get; set; }
    public string Specialty { get; set; }
    public int DepartmentId { get; set; }
    public Department Department { get; set; }
}
