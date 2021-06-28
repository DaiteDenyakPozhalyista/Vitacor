using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entities
{
    public class Result : Entity
    {
        public virtual Services Services { get; set; }
        public virtual Beast Beast { get; set; }
    }
}
