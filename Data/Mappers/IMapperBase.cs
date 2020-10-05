using System.Collections.Generic;

namespace UniversityJobCommunicationServiceDotNet.Data.Mappers
{
    public interface IMapperBase<TEntity, TDto, TDomain>
    {
        TEntity ToEntity(TDomain domain);
        TEntity ToEntity(TDto dto);
        TDomain ToDomain(TEntity entity);
        TDto ToDto(TEntity entity);
        List<TEntity> ToEntityList(List<TDomain> domains);
        List<TEntity> ToEntityList(List<TDto> dtos);
        List<TDomain> ToDomainList(List<TEntity> entities);
        List<TDto> ToDtoList(List<TEntity> entities);
    }
}