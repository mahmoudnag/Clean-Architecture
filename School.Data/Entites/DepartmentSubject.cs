using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.Entites
{
    public class DepartmentSubject
    {
        [Key]
        public int DepSubID { get; set; }
        public int DepID { get; set; }
        public int SubID { get; set; }
        [ForeignKey("SubID")]
        public virtual Subject  Subject { get; set; }
        [ForeignKey("DepID")]

        public virtual Department Department { get; set; }
    }
}
