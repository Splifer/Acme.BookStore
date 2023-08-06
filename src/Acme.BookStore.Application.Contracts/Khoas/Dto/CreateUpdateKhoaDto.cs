using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.BookStore.Khoas.Dto
{
    public class CreateUpdateKhoaDto
    {
        public string MaKhoa { get; set; }
        public string TenKhoa { get; set; }
        public string SoDienThoai { get; set; }
        public string IsActive { get; set; }
    }
}