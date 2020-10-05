using System;

namespace UniversityJobCommunicationServiceDotNet.Data.Dto
{
    public class DtoBase
    {
        public int Id { get; set; }
        public TimeSpan InsetTime { get; set; }
        public TimeSpan UpdateTime { get; set; }
    }
}