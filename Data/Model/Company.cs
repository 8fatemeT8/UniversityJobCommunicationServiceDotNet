using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Mapster;
using UniversityJobCommunicationServiceDotNet.Data.Enums;

namespace UniversityJobCommunicationServiceDotNet.Data.Model
{
    [Table("company")]
    public class Company : EntityBase
    {
        [Required] public string Name { get; set; }

        public CompanyCategoryType CompanyCategoryTypeIndex { get; set; }

        [MaxLength(1024)] public string Bio { get; set; }

        public string Address { get; set; }

        public Employer Employer { get; set; }

        public string LogoDataUrl { get; set; }
    }
}