using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using UniversityJobCommunicationServiceDotNet.Data.Enums;

namespace UniversityJobCommunicationServiceDotNet.Data.Model
{
    [Table("job")]
    public class Job : EntityBase
    {
        public JobCategoryType JobCategoryTypeIndex { get; set; }
        public CooperationType CooperationTypeIndex { get; set; }
        public RequiredGenderType RequiredGenderTypeIndex { get; set; }
        // set text data type
        public string Description { get; set; }
        public string Title { get; set; }
        public Employer Employer { get; set; }
        public List<Employee> Employees { get; set; }
    }
}