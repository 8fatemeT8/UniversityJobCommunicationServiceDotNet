using System;

namespace UniversityJobCommunicationServiceDotNet.Data.Domain
{
    public class DomainBase
    {
        public int Id { get; set; }
        public TimeSpan InsertTime { get; set; }
        public TimeSpan UpdateTime { get; set; }
    }
}