using System;

namespace UniversityJobCommunicationServiceDotNet.Data.Model
{
    public class EntityBase
    {
        public int Id { get; set; }
        public TimeSpan InsetTime { get; set; }
        public TimeSpan UpdateTime { get; set; }
    }
}