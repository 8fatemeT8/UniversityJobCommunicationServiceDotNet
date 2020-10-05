using System.Collections.Generic;

namespace UniversityJobCommunicationServiceDotNet.Data.Dto
{
    public class EmployerDto: UserDto
    {
        public CompanyDto Company { get; set; }
        public List<JobDto> Jobs { get; set; }    }
}