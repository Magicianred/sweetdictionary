using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Writer
    {
        [Key]
        public int WriterId { get; set; }
        [StringLength(50)]
        public string WriterFirstName { get; set; }
        [StringLength(50)]
        public string WriterLastName { get; set; }
        [StringLength(300)]
        public string WriterAbout { get; set; }
        [StringLength(100)]
        public string WriterImage { get; set; }
        [StringLength(100)]
        public string WriterMail { get; set; }
        [StringLength(100)]
        public string WriterPassword { get; set; }
        public ICollection<Heading> Headings { get; set; }
        public ICollection<Content> Contents { get; set; }
    }
}
