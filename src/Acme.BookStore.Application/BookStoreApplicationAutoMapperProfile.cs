using Acme.BookStore.Khoas;
using Acme.BookStore.Khoas.Dto;
using AutoMapper;
using Volo.Abp.AutoMapper;

namespace Acme.BookStore;

public class BookStoreApplicationAutoMapperProfile : Profile
{
    public BookStoreApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<Khoa, KhoaDto>();
        CreateMap<CreateUpdateKhoaDto, Khoa>().IgnoreAuditedObjectProperties();
    }
}