using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Common.DTO;

namespace Template.Business.Patient;

public interface IPatient
{
    public PatientResource getElementByid (int id);
    public IEnumerable<PatientResource> GetAll ();
    public void Add(PatientResource resource);
    public void Update(PatientResource resource);
    public void Delete(int Id);
}
