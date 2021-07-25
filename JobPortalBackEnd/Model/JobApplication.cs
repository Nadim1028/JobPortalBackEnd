using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JobPortalBackEnd.Model
{
    public class JobApplication
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int JobId { get; set; }
        public int JobSeekerId { get; set; }
        public int EmployerId { get; set; }
        public string CompanyName { get; set; }
        public string JobTitle { get; set; }
        public string JobType { get; set; }
        public string Filepath { get; set; }
        public string JobLocation { get; set; }
        public DateTime Deadline { get; set; }
        public string ApplicationDeadline { get; set; }
    }
}
