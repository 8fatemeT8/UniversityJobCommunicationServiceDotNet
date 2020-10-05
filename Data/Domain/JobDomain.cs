namespace UniversityJobCommunicationServiceDotNet.Data.Domain
{
    public class JobDomain : DomainBase
    {
        public int JobCategoryTypeIndex { get; set; }
        public int CooperationTypeIndex { get; set; }
        public int RequiredGenderTypeIndex { get; set; }
        public string Description { get; set; }
        public CompanyDomain Company { get; set; }
        public string Title { get; set; }
    }
}