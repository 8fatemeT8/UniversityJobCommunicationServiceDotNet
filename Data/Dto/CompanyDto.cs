namespace UniversityJobCommunicationServiceDotNet.Data.Dto
{
    public class CompanyDto : DtoBase
    {
        public string Name { get; set; }
        public int CompanyCategoryTypeIndex { get; set; }
        public string Bio { get; set; }
        public string Address { get; set; }
        public string LogoDataUrl { get; set; }
    }
}