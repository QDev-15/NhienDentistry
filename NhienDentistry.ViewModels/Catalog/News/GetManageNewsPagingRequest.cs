using NhienDentistry.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace NhienDentistry.ViewModels.Catalog.News

{
    public class GetManageNewsPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }

        public string LanguageId { get; set; }

        public int? CategoryId { get; set; }
    }
}