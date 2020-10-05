using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UniversityJobCommunicationServiceDotNet.Data.Enums;

namespace UniversityJobCommunicationServiceDotNet.Data.Model
{
    [Table("user")]
    public class User : EntityBase
    {
        [Required] public string Username { get; set; }
        public string Password { get; set; }
        [Required] public EmailAddressAttribute Email { get; set; }
        [Required] public PersonRuleType PersonRuleTypeIndex { get; set; }
    }
}