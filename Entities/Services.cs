using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entities
{
    public class Services : Entity
    {
        public string Name { get; set; }
        public double? Cost { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}
