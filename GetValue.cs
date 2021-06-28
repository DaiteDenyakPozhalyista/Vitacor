using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class GetValue
    {
        Connect.Connection db = new Connect.Connection();
        public List<Entities.Doctor> GetDoctors()
        {
            return db.Doctors.ToList();
        }
        public List<Entities.Owner> GetOwner()
        {
            return db.Owners.ToList();
        }
        public List<Entities.Beast> GetBeast()
        {
            return db.Beasts.ToList();
        }
        public List<Entities.Services> GetService()
        {
            return db.Services.ToList();
        }
        public List<Entities.Vaccine> GetVaccine()
        {
            return db.Vaccines.ToList();
        }
        public List<Entities.Result> GetResult()
        {
            return db.Results.ToList();
        }
    }
}
