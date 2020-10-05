using System.ComponentModel.DataAnnotations;

namespace UniversityJobCommunicationServiceDotNet.Data.Domain
{
    public class UserDomain : DomainBase
    {
        public string Username { get; set; }
        public EmailAddressAttribute Email { get; set; }
        public int PersonRuleTypeIndex { get; set; }
    }
}