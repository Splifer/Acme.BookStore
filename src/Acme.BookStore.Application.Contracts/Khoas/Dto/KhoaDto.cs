using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.Khoas.Dto
{
    public class KhoaDto : AuditedEntityDto<Guid>
    {
        public string MaKhoa { get; set; }
        public string TenKhoa { get; set; }
        public string SoDienThoai { get; set; }
        public string Filter { get; set; }
        public string IsActive { get; set; }
    }
}