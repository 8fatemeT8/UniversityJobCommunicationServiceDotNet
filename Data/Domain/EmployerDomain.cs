using System.Collections.Generic;

namespace UniversityJobCommunicationServiceDotNet.Data.Domain
{
    public class EmployerDomain : UserDomain
    {
        public CompanyDomain Company { get; set; }
        public List<JobDomain> Jobs { get; set; }
    }
}