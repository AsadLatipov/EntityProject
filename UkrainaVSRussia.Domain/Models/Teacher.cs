using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityProject.Domain.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Experience { get; set; }
        public string Department { get; set; }  = "Education";
        public virtual ICollection<Subject> Subjects { get; set; } 
        public int GroupId { get; set; }

        [ForeignKey(nameof(GroupId))]
        public Group Group { get;}
        public Teacher()
        {
            Subjects = new List<Subject>();
        }


    }
}
