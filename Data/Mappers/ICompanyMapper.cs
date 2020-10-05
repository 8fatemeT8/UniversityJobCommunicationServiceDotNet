using Mapster;
using UniversityJobCommunicationServiceDotNet.Data.Domain;
using UniversityJobCommunicationServiceDotNet.Data.Dto;
using UniversityJobCommunicationServiceDotNet.Data.Model;

namespace UniversityJobCommunicationServiceDotNet.Data.Mappers
{
    [Mapper]
    public interface ICompanyMapper : IMapperBase<Company, CompanyDto, CompanyDomain>
    {
    }
}