using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityJobCommunicationServiceDotNet.Data.Model
{
    [Table("resume")]
    public class Resume : EntityBase
    {
        public string Url { get; set; }
        [Column(name: "resume_uuid")] public string UUid { get; set; }
        public Employee Type { get; set; }
    }
}