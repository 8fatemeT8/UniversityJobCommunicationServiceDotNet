
using System.Collections.Generic;

namespace UniversityJobCommunicationServiceDotNet.Data.Dto
{
    public class EmployeeDto: UserDto
    {
        public ResumeDto Resume { get; set; }
        public List<JobDto> Jobs { get; set; }
    }
}