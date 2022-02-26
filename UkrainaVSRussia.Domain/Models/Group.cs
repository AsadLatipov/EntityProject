using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityProject.Domain.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string OpenedDate { get; set; }
        public virtual ICollection<Student> Students { get;}
        public virtual ICollection<Teacher> Teachers { get;}



    }
}
