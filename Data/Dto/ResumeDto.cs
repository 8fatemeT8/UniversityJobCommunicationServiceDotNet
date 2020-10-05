namespace UniversityJobCommunicationServiceDotNet.Data.Dto
{
    public class ResumeDto: DtoBase
    {
        public string Url { get; set; }
        public EmployeeDto EmployeeDto { get; set; }
    }
}