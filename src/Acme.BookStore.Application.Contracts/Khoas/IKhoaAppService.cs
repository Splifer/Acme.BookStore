using Acme.BookStore.Khoas.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.Khoas
{
    public interface IKhoaAppService : ICrudAppService<
        KhoaDto,
        Guid,
        QueryKhoaDto,
        CreateUpdateKhoaDto,
        CreateUpdateKhoaDto>
    {
    }
}