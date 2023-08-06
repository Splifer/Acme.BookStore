using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Khoas
{
    public class Khoa : AuditedAggregateRoot<Guid>
    {
        public string MaKhoa { get; set; }
        public string TenKhoa { get; set; }
        public string SoDienThoai { get; set; }
        public string Filter { get; set; }
        public string IsActive { get; set; }

    }
}