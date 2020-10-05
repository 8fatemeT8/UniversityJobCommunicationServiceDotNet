using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UniversityJobCommunicationServiceDotNet.Data.Enums;

namespace UniversityJobCommunicationServiceDotNet.Data.Model
{
    [Table("employee")]
    public class Employee : User
    {
        public Resume Resume { get; set; }

        public List<Job> Jobs { get; set; }

        [Required]
        public RequiredGenderType RequiredGenderTypeIndex { get; set; }
        
    }
}