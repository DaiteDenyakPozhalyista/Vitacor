using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entities
{
    public class Beast : Entity
    {
        public string Name { get; set; }
        public virtual Owner Owner { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual Vaccine Vaccines { get; set; } 
    }
}
