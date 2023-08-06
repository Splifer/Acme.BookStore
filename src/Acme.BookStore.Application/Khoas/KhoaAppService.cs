using Acme.BookStore.Khoas.Dto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Khoas
{
    public class KhoaAppService : CrudAppService<
        Khoa,
        KhoaDto,
        Guid,
        QueryKhoaDto,
        CreateUpdateKhoaDto,
        CreateUpdateKhoaDto>, IKhoaAppService
    {
        private readonly IRepository<Khoa, Guid> _khoaRepository; /*dung ket noi vs mongodb*/
        public KhoaAppService(IRepository<Khoa, Guid> khoaRepository) : base(khoaRepository)
        {
            _khoaRepository = khoaRepository;
        }

        public override async Task<KhoaDto> CreateAsync([FromForm] CreateUpdateKhoaDto input)
        {
            var entity = ObjectMapper.Map<CreateUpdateKhoaDto, Khoa>(input);
            entity.Filter = input.MaKhoa + " " + input.TenKhoa + " " + input.SoDienThoai;
            await _khoaRepository.InsertAsync(entity);
            var output = MapToGetOutputDto(entity);
            return output;
        }

        protected override KhoaDto MapToGetOutputDto(Khoa entity)
        {
            return new KhoaDto
            {
                Id = entity.Id,
                MaKhoa = entity.MaKhoa,
                TenKhoa = entity.TenKhoa,
                SoDienThoai = entity.SoDienThoai,
                Filter = entity.Filter,
                IsActive = entity.IsActive
                //LastModificationTime = DateTime.Now,
                //LastModifierId = entity.LastModifierId,
            };
        }

        public override Task DeleteAsync(Guid id)
        {
            return base.DeleteAsync(id);
        }

        public override Task<KhoaDto> GetAsync(Guid id)
        {
            return base.GetAsync(id);
        }

        public override Task<PagedResultDto<KhoaDto>> GetListAsync(QueryKhoaDto input)
        {
            return base.GetListAsync(input);
        }

        public override Task<KhoaDto> UpdateAsync(Guid id, CreateUpdateKhoaDto input)
        {
            return base.UpdateAsync(id, input);
        }

        //Ctr + . => Generate overides => Deselect all => 

    }
}