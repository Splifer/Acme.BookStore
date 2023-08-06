using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.BookStore.Common
{
    public class QueryResultRequestDto
    {
        [Range(0, int.MaxValue)]
        public virtual int SkipCount { get; set; }

        [Range(0, int.MaxValue)]
        public virtual int MaxResultCount { get; set; }
        public virtual string Sorting { get; set; } = "";
        public string Filter { get; set; } = "";
        public bool IsActive { get; set; }
    }
}