namespace UniversityJobCommunicationServiceDotNet.Data.Dto
{
    public class ChangePasswordDto
    {
        public string OldPass { get; set; }
        public string NewPass { get; set; }
        public string RepeatPass { get; set; }
    }
}