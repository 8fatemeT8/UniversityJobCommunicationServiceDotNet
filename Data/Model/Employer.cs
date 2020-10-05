using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityJobCommunicationServiceDotNet.Data.Model
{
    [Table("employer")]
    public class Employer : User
    {
        public Company Company { get; set; }

        public HashSet<Job> Jobs { get; set; }
    }
}