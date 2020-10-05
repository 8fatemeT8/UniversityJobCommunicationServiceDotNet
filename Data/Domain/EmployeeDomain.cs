using System.Collections.Generic;

namespace UniversityJobCommunicationServiceDotNet.Data.Domain
{
    public class EmployeeDomain :UserDomain
    {
        public ResumeDomain Resume { get; set; }
        public List<JobDomain> Jobs { get; set; }
    }
}