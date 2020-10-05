namespace UniversityJobCommunicationServiceDotNet.Data.Dto
{
    public class JobDto: DtoBase
    {
        public int JobCategoryTypeIndex { get; set; }
        public int CooperationTypeIndex { get; set; }
        public int RequiredGenderTypeIndex { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
    }
}